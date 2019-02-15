using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DimensionManager
{
    struct CoordianteSystem
    {
        public Vector3 Origin { get; set; }
        public Vector3 AxisX { get; set; }
        public Vector3 AxisY { get; set; }
        public Vector3 AxisZ { get; set; }

        public CoordianteSystem(Vector3 origin, Vector3 axisX, Vector3 axisY, Vector3 axisZ)
        {
            Origin = origin;
            AxisX = axisX;
            AxisY = axisY;
            AxisZ = axisZ;
        }

        public Vector3 GetLocalPoint(Vector3 globalPoint)
        {
            var relative = globalPoint - Origin;
            var localX = Vector3.Dot(AxisX, relative);
            var localY = Vector3.Dot(AxisY, relative);
            var localZ = Vector3.Dot(AxisZ, relative);
            return new Vector3(localX, localY, localZ);
        }
    }
}
