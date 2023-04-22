using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mathlab;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown2.Value;
            double c = (double)numericUpDown3.Value;
            double d = (double)numericUpDown4.Value;
            double f = 0.5;
            if (checkBox1.Checked == true)
            {
                double s1 = Matan.VerSumm(a, b);
                double s2 = Matan.VerSumm(d, c);
                double z = Matan.VerUn(a, s1);
                double y = Matan.VerUn(c, s2);
                double j = Matan.VerVer(z, f);
                double k = Matan.VerVer(y, f);
                double result = Matan.VerOt(k, j);
                String temp = "";
                temp += Convert.ToString(result);
                MessageBox.Show(temp,"Answer");
            }
            else if (checkBox2.Checked == true)
            {
                double s1 = Matan.VerSumm(a, b);
                double s2 = Matan.VerSumm(d, c);
                double z = Matan.VerUn(b, s1);
                double y = Matan.VerUn(d, s2);
                double j = Matan.VerVer(z, f);
                double k = Matan.VerVer(y, f);
                double result = Matan.VerOt(k, j);
                String temp = "";
                temp += Convert.ToString(result);
                MessageBox.Show(temp ,"Answer");
            }
            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
