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
    public partial class Form4 : Form
    {
        
        public bool isManhatten(bool f)
        {
            return f;
        }

        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 200);
            new SiticoneShadowForm(this);
            new SiticoneDragControl(panel1);
            new SiticoneDragControl(logo);

        }

        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();

        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            isManhatten(false);

            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();

        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            isManhatten(true);

            Form3 f3 = new Form3();
            
            f3.Show();
            this.Hide();



        }
    }
}
