using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Lab3Task1 : Form
    {
        public Lab3Task1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shoes pair = new Shoes(13, "сапоги", 3000, "крокодил");
            groupBox1.Text = pair.ShowInfo();
            pictureBox1.Image = ConsoleApp1.Properties.Resources._1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clothes jacket = new Clothes(25, "куртка кож.", 15000, "козья кожа");
            groupBox1.Text = jacket.ShowInfo();
            pictureBox1.Image = ConsoleApp1.Properties.Resources._2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Electronics phone = new Electronics(130, "Huawai", 25000, "Китай", "12X");
            groupBox1.Text = phone.ShowInfo();
            pictureBox1.Image = ConsoleApp1.Properties.Resources._3;
        }
    }
}
