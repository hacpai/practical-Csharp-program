using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Random rnd = new Random();
        int l, r;
        string op;
        int result;
  /*      private void BtnNew_Click(object sender, EventArgs e)
        {
            l = rnd.Next(9) + 1;
            r = rnd.Next(9) + 1;
            int iOp;
            iOp = rnd.Next(2);
            switch (iOp)
            {
                case 0:
                    op = "+";
                    result = l + r;
                    break;
                case 1:
                    op = "-";
                    result = l - r;
                    break;
            }
            lblL.Text = l.ToString();
            lblOp.Text = op;
            lblR.Text = r.ToString();
            txtAns.Text = "";
        }
    */
        private void BtnCmt_Click(object sender, EventArgs e)
        {
            string sAns = txtAns.Text;
            double dAns = double.Parse(sAns);
            string disp = "" + l + op + r + "=" + sAns + "";
            timer1.Enabled = true;
            if ( Math.Abs(dAns - result) < 1e-3 )
            {
                disp += "☑️";
                lBxRst.BackColor = Color.FromArgb(124, 252, 0);
            }
            else
            {
                disp += "✖️";
                lBxRst.BackColor = Color.FromArgb(255, 0, 0);
            }
            
            lBxRst.Items.Add(disp);
        }

        private void lBxRst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            l = rnd.Next(9) + 1;
            r = rnd.Next(9) + 1;
            int iOp;
            iOp = rnd.Next(2);
            switch (iOp)
            {
                case 0:
                    op = "+";
                    result = l + r;
                    break;
                case 1:
                    op = "-";
                    result = l - r;
                    break;
            }
            lblL.Text = l.ToString();
            lblOp.Text = op;
            lblR.Text = r.ToString();
            txtAns.Text = "";
            if (txtAns.Text == "")
            {
                timer1.Enabled = false;
            }
        }
    }
}
