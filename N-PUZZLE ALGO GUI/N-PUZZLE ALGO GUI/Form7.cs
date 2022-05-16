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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 200);
            new SiticoneShadowForm(this);
            new SiticoneDragControl(panel1);
            new SiticoneDragControl(logo);
        }
        public bool isManhatten2(bool f)
        {
            return f;
        }
        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            isManhatten2(false);
            Form6 f6 = new Form6(); 
            f6.Show();
            this.Close();
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            isManhatten2(true);
            Form6 f6 = new Form6();
            f6.Show();
            this.Close();
        }
    }
}
