using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M64MM.Additions;
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
            ToolCommand tc = new ToolCommand("Codename Orchestrator");
            ToolCommand tcAnarchy = new ToolCommand("Anarchy");
            tc.Summoned += (a, b) => { tf.Show(); };
            tcAnarchy.Summoned += (a, b) => { frmA.ShowDialog(); };
            tcl.Add(tc);
            tcl.Add(tcAnarchy);
            return tcl;
        }

        public void Initialize()
        {
            
            if (tf == null)
            {
                tf = new TestForm();
                frmA = new frmAnarchy();
            }
        }

        public void OnBaseAddressFound()
        {

        }

        public void OnBaseAddressZero()
        {

        }

        public void OnCoreEntAddressChange(uint addr)
        {

        }

        public void Reset()
        {

        }

        public void Update()
        {
            if (!tf.IsHandleCreated) return;
            tf?.Invoke(new MethodInvoker(() =>
            {
                tf?.UpdateVals();

                if (KIOBase.Ready)
                {
                    if (!KIOBase.tb.IsHandleCreated) return;
                    KIOBase.tb?.Invoke(new MethodInvoker(() =>
                        {
                            KIOBase.tb.UpdateAllLabels();
                            if (KIOBase.mainTL.Playing)
                            {
                                KIOBase.mainTL.TrackheadPosition++;
                                if (KIOBase.mainTL.TrackheadPosition >= KIOBase.mainTL.Length)
                                {
                                    KIOBase.mainTL.Playing = false;
                                }
                            }
                        }
                         ));
                }
            }));

        }
    }
}
