using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace N_PUZZLE_ALGO_GUI
{
    public partial class Form2 : Form
    {
        int count;
        public Form2()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 200);
            new SiticoneShadowForm(this);
            new SiticoneDragControl(panel1);
            new SiticoneDragControl(logo);
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 3)
            {
                MessageBox.Show("انا كنت عايز امشيها علي ال دو");
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 3)
            {
                MessageBox.Show("انا كنت عايز امشيها علي ال دو");

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 3)
            {
                MessageBox.Show("انا كنت عايز امشيها علي ال دو");
            }
        }
    }
}
