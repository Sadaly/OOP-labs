using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;

namespace WindowsFormsApp2
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
            ComputerComponents new_component = new ComputerComponents();
            if (ManufacturerText.Text != "")
                new_component.manufacturer = ManufacturerText.Text;
            if (NameText.Text != "")
                new_component.name = NameText.Text;
            if (ModelText.Text != "")
                new_component.model = ModelText.Text;
            if (PriceText.Text != "")
                new_component.price = Convert.ToInt32(PriceText.Text);
            if (WasOpenedCheck.Checked)
                new_component.WasOpened = true;
            MessageBox.Text = "Окно вывода" + new_component.ShowInfo();
        }

        private void MessageBox_Enter(object sender, EventArgs e)
        {

        }

        private void WasOpenedCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
