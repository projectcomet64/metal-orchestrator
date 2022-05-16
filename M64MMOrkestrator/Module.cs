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

        private const long CamStatBase = 0x3E001c;

        public string SafeName => "METAL Orchestrator";

        public string Description => "SUPER!! Advanced Camera Control. Full name is METAL: Kikai Orchestrator";

        public Image AddonIcon => Resources.orchestrator_64;

        public void Close(EventArgs e)
        {

        }

        public List<ToolCommand> GetCommands()
        {
            List<ToolCommand> tcl = new List<ToolCommand>();
            ToolCommand tc = new ToolCommand("Open Orchestrator...");
            tc.Summoned += (a, b) => { KIOBase.MainForm.Show(); };
            tcl.Add(tc);
            return tcl;
        }

        public void Initialize()
        {

            if (KIOBase.Inited == false)
            {
                KIOBase.Init();
            }
        }

        public void OnBaseAddressFound()
        {
            if (Core.CoreEntityAddress > 0)
            {
                byte[] statBytes = Core.ReadBytes(Core.BaseAddress + CamStatBase, 2);
                // Game running and Mario is present
                KIOBase.Init();
                KIOBase.Status = statBytes[0] != 0xFF ? KIOStatus.DIRTY : KIOStatus.READY;
                if (KIOBase.MainForm.IsHandleCreated)
                    KIOBase.MainForm?.Invoke(new MethodInvoker(() => { KIOBase.MainForm.ChangeEnsembleStatus(KIOBase.Status); }));
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
            if (KIOBase.MainForm.IsHandleCreated)
                KIOBase.MainForm?.Invoke(new MethodInvoker(() => { KIOBase.MainForm.ChangeEnsembleStatus(KIOBase.Status); }));
        }

        public void OnCoreEntAddressChange(uint addr)
        {

            byte[] statBytes = Core.ReadBytes(Core.BaseAddress + CamStatBase, 2);
            // Level changed, KI-O flag not present (also savestate)
            if (statBytes[0] != 0xFF)
            {
                KIOBase.Status = KIOStatus.DIRTY;
            }

            if (statBytes[1] != 0x00)
            {
                KIOBase.Status = KIOStatus.WTF;
            }

            if (KIOBase.MainForm.IsHandleCreated)
                KIOBase.MainForm?.Invoke(new MethodInvoker(() => { KIOBase.MainForm.ChangeEnsembleStatus(KIOBase.Status); }));

            if (addr != 0 && KIOBase.Status == KIOStatus.HOLDON)
            {
                KIOBase.InjectCamHack();
                KIOBase.Status = KIOStatus.READY;
                if (KIOBase.MainForm.IsHandleCreated)
                    KIOBase.MainForm?.Invoke(new MethodInvoker(() => { KIOBase.MainForm.ChangeEnsembleStatus(KIOBase.Status); }));
            }
        }

        public void Reset()
        {
            KIOBase.Status = KIOStatus.DIRTY;
        }

        public void Update()
        {
            if (KIOBase.MainForm.IsHandleCreated)
            {
                KIOBase.MainForm.BeginInvoke(new MethodInvoker(() => { KIOBase.MainForm.UpdateValues(); }));
            }

            if (KIOBase.Status == KIOStatus.READY)
            {
                byte[] statBytes = Core.ReadBytes(Core.BaseAddress + CamStatBase, 2);
                if (statBytes[0] != 0xFF)
                {
                    KIOBase.Status = KIOStatus.DIRTY;
                }

                if (statBytes[1] != 0x00)
                {
                    KIOBase.Status = KIOStatus.WTF;
                }
            }



            if (KIOBase.Status == KIOStatus.HOLDON && !Core.ValidateAnimDataAddress())
            {
                KIOBase.InjectCamHack();
                KIOBase.Init();
            }

            if (KIOBase.Status == KIOStatus.READY)
            {
                if (!KIOBase.mainTL.Playing) return;

                if (KIOBase.mainTL.TrackheadPosition >= KIOBase.mainTL.Length)
                {
                    KIOBase.mainTL.Playing = false;
                }
                KIOBase.mainTL.TrackheadPosition++;
            }
        }
    }
}
