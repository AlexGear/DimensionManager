using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Numerics;

namespace DimensionManager
{
    public partial class CoordsBox : UserControl
    {
        private float x = 0;
        private float y = 0;
        private float z = 0;

        public float X
        {
            get { return x; }
            set
            {
                x = value;
                ValueChanged?.Invoke(this);
            }
        }
        public float Y
        {
            get { return y; }
            set
            {
                y = value;
                ValueChanged?.Invoke(this);
            }
        }
        public float Z
        {
            get { return z; }
            set
            {
                z = value;
                ValueChanged?.Invoke(this);
            }
        }

        public event Action<CoordsBox> ValueChanged;

        public Vector3 Vector => new Vector3(x, y, z);

        public CoordsBox()
        {
            InitializeComponent();
        }

        private void coordBox_ValueChanged(DecimalBox box)
        {
            switch (box.Tag)
            {
                case "X": X = box.Value; break;
                case "Y": Y = box.Value; break;
                case "Z": Z = box.Value; break;
            }
        }
    }
}
