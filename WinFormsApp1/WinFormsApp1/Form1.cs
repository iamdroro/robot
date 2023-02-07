using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Robot robot1 = new Robot();
            Robot robot2 = new Robot();
            Robot robot3 = new Robot();
            Random rnd = new Random();
            int b =int.Parse(textBox1.Text);
            int c = int.Parse(textBox2.Text);
            int d = int.Parse(textBox3.Text);
            robot1.min(b);
           
            label1.Text = "Количество жизней робота2 вначале игры " + Convert.ToString(b);
             label2.Text = "Количество жизней робота2 после игры " + Convert.ToString(robot1.getlife());
            label7.Text = "Количество жизней робота1 вначале игры " + Convert.ToString(c);
            label6.Text = "Количество жизней робота1 после игры " + Convert.ToString(robot1.getlife());
            label9.Text = "Количество жизней робота3 вначале игры " + Convert.ToString(d);
            label8.Text = "Количество жизней робота3 после игры " + Convert.ToString(robot1.getlife());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
