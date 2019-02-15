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
        private HashSet<char> allowedChars = new HashSet<char>
        {
            ',',
            '.',
            '-'
        };

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

        private void coordBox_Validating(object sender, CancelEventArgs e)
        {
            var textBox = (TextBox)sender;
            if(string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "0";
                return;
            }

            try
            {
                var culture = CultureInfo.InvariantCulture;
                var commasReplaced = textBox.Text.Replace(',', '.');
                var value = float.Parse(commasReplaced, culture);
                textBox.Text = value.ToString(culture);
                errorProvider.SetError(textBox, null);

                switch(textBox.Tag)
                {
                    case "X": X = value; break;
                    case "Y": Y = value; break;
                    case "Z": Z = value; break;
                }
            }
            catch(FormatException)
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, "Неверный формат");
            }
        }

        private void coordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsDigit(c) || char.IsControl(c) || allowedChars.Contains(c))
                return;
            e.Handled = true;
        }
    }
}
