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

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Monitor monitor = new Monitor(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt16(textBox4.Text), Convert.ToBoolean(textBox5.Text), textBox6.Text, Convert.ToInt16(textBox7.Text));
                Output.Text = monitor.ShowInfo();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
            if (checkBox2.Checked)
            {
                VideoCard videoCard = new VideoCard(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt16(textBox4.Text), Convert.ToBoolean(textBox5.Text), Convert.ToInt16(textBox6.Text), Convert.ToInt16(textBox7.Text), Convert.ToInt16(textBox8.Text));
                Output.Text = videoCard.ShowInfo();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
            }
            if (checkBox3.Checked)
            {
                Processor processor = new Processor(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt16(textBox4.Text), Convert.ToBoolean(textBox5.Text), Convert.ToInt16(textBox6.Text), Convert.ToInt16(textBox7.Text), Convert.ToInt16(textBox8.Text));
                Output.Text = processor.ShowInfo();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            if (checkBox1.Checked)
            {
                groupBox1.Text = "Производитель: ";
                groupBox2.Text = "Название: ";
                groupBox3.Text = "Модель: ";
                groupBox4.Text = "Цена: ";
                groupBox5.Text = "Б / У: ";
                groupBox6.Text = "Расширение: ";
                groupBox7.Text = "Гц: ";
                groupBox8.Visible = false;
                textBox8.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            if (checkBox3.Checked)
            {
                groupBox8.Visible = true;
                textBox8.Visible = true;
                groupBox1.Text = "Производитель: ";
                groupBox2.Text = "Название: ";
                groupBox3.Text = "Модель: ";
                groupBox4.Text = "Цена: ";
                groupBox5.Text = "Б / У: ";
                groupBox6.Text = "Поколение: ";
                groupBox7.Text = "Количество ядер: ";
                groupBox8.Text = "МГц: ";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            if (checkBox2.Checked)
            {
                groupBox8.Visible = true;
                textBox8.Visible = true;
                groupBox1.Text = "Производитель: ";
                groupBox2.Text = "Название: ";
                groupBox3.Text = "Модель: ";
                groupBox4.Text = "Цена: ";
                groupBox5.Text = "Б / У: ";
                groupBox6.Text = "МГц: ";
                groupBox7.Text = "Видеопамять (ГБ): ";
                groupBox8.Text = "Энергопотребление (Вт):";
            }
        }
    }
}
