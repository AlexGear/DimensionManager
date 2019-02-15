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
    public partial class CoordsBox : UserControl
    {
        public System.Numerics.

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
            }
            catch(FormatException)
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, "Неверный формат");
            }
        }
    }
}
