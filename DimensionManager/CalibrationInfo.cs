using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionManager.SerializableObjects
{
    [Serializable]
    public class CalibrationInfo
    {
        public float CriticalAngle { get; set; }

        public float AzimuthAntennaOffsetX { get; set; }
        public float AzimuthAntennaOffsetY { get; set; }

        public float MastRotateOffsetX { get; set; }
        public float MastRotateOffsetY { get; set; }
        public float MastRotateOffsetZ { get; set; }

        public float BitOffsetX { get; set; }
        public float BitOffsetY { get; set; }
        public float BitOffsetZ { get; set; }

        public float MastAngleOffset { get; set; }

        public float DrillRollOffset { get; set; }
        public float DrillPitchOffset { get; set; }

        public float PlatformOffsetZ { get; set; }

        public float SourceMastRotateOffsetX { get; set; }
        public float SourceMastRotateOffsetY { get; set; }

        public float SourceBitOffsetX { get; set; }
        public float SourceBitOffsetY { get; set; }
        public float SourceBitOffsetZ { get; set; }

        public SourceFrontRightJack SourceFrontRightJack { get; set; }
        public SourceFrontLeftJack SourceFrontLeftJack { get; set; }
        public SourceBackJack SourceBackJack { get; set; }
        public FrontRightJack FrontRightJack { get; set; }
        public FrontLeftJack FrontLeftJack { get; set; }
        public BackJack BackJack { get; set; }
    }

    [Serializable]
    public class SourceFrontRightJack
    {
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
    }

    [Serializable]
    public class SourceFrontLeftJack
    {
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
    }

    [Serializable]
    public class SourceBackJack
    {
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
    }

    [Serializable]
    public class FrontRightJack
    {
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
    }

    [Serializable]
    public class FrontLeftJack
    {
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
    }

    [Serializable]
    public class BackJack
    {
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
    }
}
