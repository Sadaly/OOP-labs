using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
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

        private void button1_Click(object sender, EventArgs e)
        {
            Order order1 = new Order(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text), textBox3.Text, Convert.ToInt16(textBox4.Text));
            Order order2 = new Order(Convert.ToInt16(textBox5.Text), Convert.ToInt16(textBox6.Text), textBox7.Text, Convert.ToInt16(textBox8.Text));
            //textBox1.Clear();
            //textBox2.Clear();
            //textBox3.Clear();
            //textBox4.Clear();
            //textBox5.Clear();
            //textBox6.Clear();
            //textBox7.Clear();
            //textBox8.Clear();
            if (order1 > order2)
                groupBox1.Text = "\nВес заказа 1 > веса заказа 2.";
            else
                groupBox1.Text = "\nВес заказа 2 > веса заказа 1.";
            Order new_order = order1 + order2;
            groupBox1.Text += new_order.ShowInfo();
        }
    }
}
