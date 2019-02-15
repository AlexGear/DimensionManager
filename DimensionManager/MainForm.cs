using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimensionManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            axisSelectCombo.SelectedIndex = 0;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "XML File | *.xml";
                if (DialogResult.OK != dialog.ShowDialog(this))
                {
                    return;
                }
                Save(dialog.FileName);
            }
        }

        private void Save(string fileName)
        {
            Console.WriteLine(fileName);
        }
    }
}
