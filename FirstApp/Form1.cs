using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        Timer timer=new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            timer.Start();  
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            titleLbl.Text = DateTime.Now.ToLongTimeString();
        }

            Label mylabel=new Label();
        private void changeBtn_Click(object sender, EventArgs e)
        {

            this.BackgroundImage = Properties.Resources.mario;

            titleLbl.Text = "Our first Lesson";
            titleLbl.ForeColor = Color.DeepPink;

            mylabel.Text = "i am second label";
            mylabel.ForeColor = Color.Red;
            mylabel.Location = new Point(0, 180);
            mylabel.Size = new Size(600, 200);
            mylabel.Font = new Font("Verdana", 30, FontStyle.Italic);
            mylabel.MouseDown += Mylabel_MouseDown;



            this.Controls.Add(mylabel);

        }

        private void Mylabel_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.DeepSkyBlue;
            }
            else if(e.Button == MouseButtons.Right)
            {
                this.BackColor = Color.Orange;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X : {e.X}  Y : {e.Y}";
        }
    }
}
