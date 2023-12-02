using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void n1(object sender, EventArgs e)
        {   if (gamotvla.Text=="0"){
             gamotvla.Text="1";

            }
            else {
                gamotvla.Text+="1";

            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "2";

            }
            else
            {
                gamotvla.Text += "2";

            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "3";

            }
            else
            {
                gamotvla.Text += "3";

            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "4";

            }
            else
            {
                gamotvla.Text += "4";

            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "5";

            }
            else
            {
                gamotvla.Text += "5";

            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "6";

            }
            else
            {
                gamotvla.Text += "6";

            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "7";

            }
            else
            {
                gamotvla.Text += "7";

            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "8";

            }
            else
            {
                gamotvla.Text += "8";

            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (gamotvla.Text == "0")
            {
                gamotvla.Text = "9";

            }
            else
            {
                gamotvla.Text += "9";

            }
        }
    }
}
