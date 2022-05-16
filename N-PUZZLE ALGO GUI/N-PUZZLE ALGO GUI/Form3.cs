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
    
    public partial class Form3 : Form
    {
        static int gg = 0;

        public Form3()
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
            this.Hide();
        }
        Label add_label(int i , int n)
        {
            
            Label l = new Label();
            l.Name = i.ToString();
            l.Text = i.ToString();
            l.ForeColor = Color.White;
            l.BackColor = Color.Black;
            l.Font = new Font("Serif" , 24 , FontStyle.Bold);
            l.Width = 527/n;
            l.Height = 527/n; 
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Margin = new Padding(5);

            return l;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            

            //int []arr = { 2, 3, 4, 7, 9, 4, 6, 9, 0 };
            //int n = 3;
            //int nn = n * n;
            int n = 10;         
            int nn = n * n;
            int[] arr = new int[n*n]; //{ 2, 3, 4, 7, 9, 4, 6, 9, 0 ,1,2,3,4,5 ,2,1};

            //List<string> list = new List<string>();

            //list.Add("015327864");
            //list.Add("012365478");

            this.Hide();
          

            for (int i = 0;i < nn; i++)
            {
                arr[i] = i;

                Label l = add_label(arr[i], n);

                //Label l =  add_label(list[gg][i],n);
                flowLayoutPanel1.Controls.Add(l);

            }
           
            this.Show();

       

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {
            gg = 1;
            Form3 fn = new Form3();
            fn.Show();
            //System.Threading.Thread.Sleep(3);
            this.Close();


        }

        private void siticoneImageButton2_Click(object sender, EventArgs e)
        {
            gg = 1;
            Form3 fn = new Form3();
            fn.Show();
            //System.Threading.Thread.Sleep(3);
            this.Close();

        }
    }
}
