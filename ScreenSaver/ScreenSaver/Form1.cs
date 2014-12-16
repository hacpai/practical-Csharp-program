using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int deltX = 10;
        int deltY= 8;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Left += deltX;
            this.label1.Top += deltY;
            if ( this.label1.Top < 0 || this.label1.Top + this.label1.Height > this.Height )
            {
                deltY = -deltX;
            }
            if ( this.label1.Width < 0 || this.label1.Width + this.label1.Width > this.Width)
            {
                deltX = -deltX;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }
    }
}
