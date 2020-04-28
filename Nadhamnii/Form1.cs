using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nadhamnii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();
        Form4 frm4 = new Form4();
        Form5 frm5 = new Form5();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();


        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

        }

        private void picfb_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = frm2.Left.ToString();
            frm2.Left += 10;
            if(frm2.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //label1.Text = frm2.Left.ToString();
            frm2.Left -= 10;
            if (frm2.Left <= 525)
            {
                timer2.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            frm2.Show();
            frm3.Show();
            frm4.Show();
            frm5.Show();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picgoogle_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            frm3.Left += 10;
            if (frm3.Left >= 830)
            {
                timer3.Stop();
                this.TopMost = false;
                frm3.TopMost = true;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            frm3.Left -= 10;
            if (frm3.Left <= 525)
            {
                timer4.Stop();
            }
        }

       

        private void pictwitt_Click(object sender, EventArgs e)
        {
            timer5.Start();
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            frm4.Left += 10;
            if (frm4.Left >= 830)
            {
                timer5.Stop();
                this.TopMost = false;
                frm4.TopMost = true;
                timer6.Start();
                
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            frm4.Left -= 10;
            if (frm4.Left <= 525)
            {
                timer6.Stop();
                
            }
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            timer7.Start();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            frm5.Left += 10;
            if (frm5.Left >= 830)
            {
                timer7.Stop();
                this.TopMost = false;
                frm5.TopMost = true;
                timer8.Start();

            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            frm5.Left -= 10;
            if (frm5.Left <= 525)
            {
                timer8.Stop();

            }
        }
    }
}

