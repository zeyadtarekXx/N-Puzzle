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
    public partial class Form1 : Form
    {
    


        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 200);
            new SiticoneShadowForm(this);
            new SiticoneDragControl(panel1);
            new SiticoneDragControl(logo);
            //WindowState = FormWindowState.Maximized;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            Form4 f3 = new Form4();
            f3.Show();
            this.Hide();
        }

        private void siticoneGradientButton4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }
    }
}
