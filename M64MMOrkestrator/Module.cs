using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M64MM.Additions;
using M64MM.Utils;
using M64MMOrkestrator.Properties;

namespace M64MMOrkestrator
{
    public class Module : IModule
    {
        public string SafeName => "M64MM Action!";

        public string Description => "The most advanced Camera control, overriding the original game's";

        public Image AddonIcon => Resources.defaultAddonIcon;

        public TestForm tf;


        public frmAnarchy frmA;

        public void Close(EventArgs e)
        {

        }

        public List<ToolCommand> GetCommands()
        {
            List<ToolCommand> tcl = new List<ToolCommand>();
            ToolCommand tc = new ToolCommand("Codename KI-O");
            ToolCommand tcAnarchy = new ToolCommand("Anarchy");
            tc.Summoned += (a, b) => { KIOBase._mainForm.Show(); };
            tcAnarchy.Summoned += (a, b) => { frmA.ShowDialog(); };
            tcl.Add(tc);
            tcl.Add(tcAnarchy);
            return tcl;
        }

        public void Initialize()
        {

            if (KIOBase.Inited == false)
            {
                tf = new TestForm();
                KIOBase.Init();
                frmA = new frmAnarchy();
            }
        }

        public void OnBaseAddressFound()
        {
            if (Core.CoreEntityAddress > 0)
            {
                // Game running and Mario is present
                KIOBase.Init();
                KIOBase.Status = KIOStatus.DIRTY;
                if (KIOBase._mainForm.IsHandleCreated)
                    KIOBase._mainForm?.Invoke(new MethodInvoker(() => { KIOBase._mainForm.ChangeEnsembleStatus(KIOBase.Status); }));
            }
            else
            {
                KIOBase.InjectCamHack();
                KIOBase.Init();
            }

        }

        public void OnBaseAddressZero()
        {
            KIOBase.Status = KIOStatus.NOT_READY;
            if (KIOBase._mainForm.IsHandleCreated)
                KIOBase._mainForm?.Invoke(new MethodInvoker(() => { KIOBase._mainForm.ChangeEnsembleStatus(KIOBase.Status); }));
        }

        public void OnCoreEntAddressChange(uint addr)
        {
            if (addr != 0 && KIOBase.Status == KIOStatus.HOLDON)
            {
                KIOBase.InjectCamHack();
                KIOBase.Status = KIOStatus.READY;
                if (KIOBase._mainForm.IsHandleCreated)
                    KIOBase._mainForm?.Invoke(new MethodInvoker(() => { KIOBase._mainForm.ChangeEnsembleStatus(KIOBase.Status); }));
            }
        }

        public void Reset()
        {
            KIOBase.Status = KIOStatus.DIRTY;
        }

        public void Update()
        {
            if (KIOBase.Status == KIOStatus.HOLDON && !Core.ValidateAnimDataAddress())
            {
                KIOBase.InjectCamHack();
                KIOBase.Init();
            }

            if (KIOBase.Status != KIOStatus.READY)
            {
                if (KIOBase.mainTL.Playing)
                {
                    if (KIOBase.mainTL.TrackheadPosition >= KIOBase.mainTL.Length)
                    {
                        KIOBase.mainTL.Playing = false;
                    }
                    KIOBase.mainTL.TrackheadPosition++;
                }
            }
        }
    }
}
