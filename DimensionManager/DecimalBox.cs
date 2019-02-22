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

namespace DimensionManager
{
    public partial class DecimalBox : UserControl
    {
        private static readonly Color ErrorColor = Color.FromArgb(255, 100, 100);
        private static List<char> DecimalPoints = new List<char>
        {
            ',',
            '.',
        };

        private float value;
        public float Value
        {
            get { return value; }
            set
            {
                this.value = value;
                ValueChanged?.Invoke(this);
            }
        }

        public event Action<DecimalBox> ValueChanged;

        public DecimalBox()
        {
            InitializeComponent();
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
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
                textBox.BackColor = SystemColors.Window;

                this.Value = value;
            }
            catch (FormatException)
            {
                e.Cancel = true;
                textBox.BackColor = ErrorColor;
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsDigit(c) || char.IsControl(c))
                return;
            if (c == '-' && !textBox.Text.Contains(c))
                return;
            if (IsDecimalPoint(c) && !textBox.Text.Any(IsDecimalPoint))
                return;

            e.Handled = true;
        }

        private static bool IsDecimalPoint(char c)
        {
            return DecimalPoints.Contains(c);
        }
    }
}
