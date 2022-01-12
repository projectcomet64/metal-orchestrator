﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using M64MM.Utils;
using M64MMOrkestrator.KIO;
using M64MMOrkestrator.Properties;

namespace M64MMOrkestrator
{
    public enum KIOStatus
    {
        NOT_READY,
        READY,
        HOLDON,
        DIRTY
    }

    public static class KIOBase
    {

        public static FrmMain _mainForm;

        public static KIOStatus Status { get; set; }

        public static bool Inited { get; set; }

        // TODO: Make extension method for Vector3 "FromBytes"
        public static Vector3 CamPos
        {
            get
            {
                Vector3 v = new Vector3();
                byte[] camposVals = Core.ReadBytes(Core.BaseAddress + 0x3E0004, 12);
                v.X = BitConverter.ToSingle(camposVals, 0);
                v.Y = BitConverter.ToSingle(camposVals, 4);
                v.Z = BitConverter.ToSingle(camposVals, 8);
                return v;
            }

            set
            {
                byte[] valsX = BitConverter.GetBytes(value.X);
                byte[] valsY = BitConverter.GetBytes(value.Y);
                byte[] valsZ = BitConverter.GetBytes(value.Z);
                byte[] fullvals = new byte[valsX.Length * 3];
                valsX.CopyTo(fullvals, 0);
                valsY.CopyTo(fullvals, 4);
                valsZ.CopyTo(fullvals, 8);
                Core.WriteBytes(Core.BaseAddress + 0x3E0004, fullvals, false);
            }
        }

        public static Vector3 MarioPos
        {
            get
            {
                Vector3 v = new Vector3();
                byte[] marioposVals = Core.ReadBytes(Core.BaseAddress + 0x33B1AC, 12);
                v.X = BitConverter.ToSingle(marioposVals, 0);
                v.Y = BitConverter.ToSingle(marioposVals, 4);
                v.Z = BitConverter.ToSingle(marioposVals, 8);
                return v;
            }

            set
            {
                byte[] valsX = BitConverter.GetBytes(value.X);
                byte[] valsY = BitConverter.GetBytes(value.Y);
                byte[] valsZ = BitConverter.GetBytes(value.Z);
                byte[] fullvals = new byte[valsX.Length * 3];
                valsX.CopyTo(fullvals, 0);
                valsY.CopyTo(fullvals, 4);
                valsZ.CopyTo(fullvals, 8);
                Core.WriteBytes(Core.BaseAddress + 0x33B1AC, fullvals, false);
            }
        }

        public static Vector3 CamLookAtPos
        {
            get
            {
                Vector3 v = new Vector3();
                byte[] camposVals = Core.ReadBytes(Core.BaseAddress + 0x3E0010, 12);
                v.X = BitConverter.ToSingle(camposVals, 0);
                v.Y = BitConverter.ToSingle(camposVals, 4);
                v.Z = BitConverter.ToSingle(camposVals, 8);
                return v;
            }

            set
            {
                byte[] valsX = BitConverter.GetBytes(value.X);
                byte[] valsY = BitConverter.GetBytes(value.Y);
                byte[] valsZ = BitConverter.GetBytes(value.Z);
                byte[] fullvals = new byte[valsX.Length * 3];
                valsX.CopyTo(fullvals, 0);
                valsY.CopyTo(fullvals, 4);
                valsZ.CopyTo(fullvals, 8);
                Core.WriteBytes(Core.BaseAddress + 0x3E0010, fullvals, false);
            }
        }

        private static XYAngle _camAngle;

        public static XYAngle CamAngle
        {
            get => XYAngle.FromVectorPair(CamPos, CamLookAtPos);
            set
            {

                Vector3 lookat = value.LookAtFromPosition(CamPos);
                CamLookAtPos = lookat;
            }
        }

        public static Timeline mainTL;
        public static Vector3KeyframeRack camPosKeyframeRack = new(new Keyframe<Vector3>(Vector3.One), () => CamPos)
        {
            Name = "Cam Position"
        };
        public static XYAngleKeyframeRack angleKeyframeRack = new(new Keyframe<XYAngle>(new XYAngle()), () => CamAngle)
        {
            Name = "Cam Angle"
        };

        public static void Ensemble()
        {
            if (Status == KIOStatus.NOT_READY && Core.BaseAddress == 0)
            {
                return;
            }
            Status = KIOStatus.HOLDON;
            if (!_mainForm.IsHandleCreated) return;
            _mainForm?.Invoke(new MethodInvoker(() => { _mainForm.ChangeEnsembleStatus(Status); }));
        }

        public static void InjectCamHack()
        {
            Core.WriteBytes(Core.BaseAddress + 0x245000 + 0x6316c, Resources._6316c, true);
            Core.WriteBytes(Core.BaseAddress + 0x245000 + 0x31440, Resources._31440, true);
            Core.WriteBytes(Core.BaseAddress + 0x245000 + 0x42ce0, Resources._42ce0, true);
        }

        public static void Init()
        {
            if (!Inited)
            {
                mainTL = new Timeline();
                mainTL.AddRack("campos", camPosKeyframeRack);
                mainTL.AddRack("camrot", angleKeyframeRack);
                camPosKeyframeRack.OnCurrentFrameChanged += () => { CamPos = camPosKeyframeRack.CalculateInterpolation(); };
                angleKeyframeRack.OnCurrentFrameChanged += () => { CamAngle = angleKeyframeRack.CalculateInterpolation(); };

                // keep it cool buddy, wait for the signal
                mainTL.Synchronize = false;
                _mainForm = new FrmMain();
                Inited = true;
            }
            Ensemble();
        }

    }
}
