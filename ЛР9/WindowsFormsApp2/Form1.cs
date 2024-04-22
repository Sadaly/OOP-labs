using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList Fractions, ImproperFractions;
        bool notSorted = false;
        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (((Convert.ToUInt32(DenominatorTextBox.Text) == 0) && (Convert.ToUInt32(NumeratorTextBox.Text) == 0) && (Convert.ToInt32(IntegerPartTextBox.Text) != 0)) || ((Convert.ToUInt32(DenominatorTextBox.Text) != 0) && !((Convert.ToInt32(IntegerPartTextBox.Text) == 0) && (Convert.ToUInt32(NumeratorTextBox.Text) == 0))))
            {
                {
                    Fraction num = new Fraction(Convert.ToInt32(IntegerPartTextBox.Text), Convert.ToUInt32(NumeratorTextBox.Text), Convert.ToUInt32(DenominatorTextBox.Text));
                    bool trig = true;
                    for (int j = 0; j < Output.RowCount - 1; j++)
                    {
                        Fraction temp = new Fraction((int)Output[0, j].Value, (uint)Output[1, j].Value, (uint)Output[2, j].Value);
                        if (temp.Equal(num))
                        {
                            MessageBox.Show("Значение уже есть в таблице");
                            trig = false;
                            break;
                        }
                    }
                    for (int j = 0; j < ImproperFractions.Count; j++)
                    {
                        Fraction temp = new Fraction(num.IntegerPart, num.Numerator, num.Denominator);
                        // temp = num (локальная экземпляр temp становится ссылкой на num, почему?)
                        temp.MakeProper();
                        if (((Fraction)ImproperFractions[j]).Equal(temp))
                        {
                            MessageBox.Show("Эта дробь уже была внесена в список неправильных");
                            trig = false;
                            break;
                        }
                    }

                    if (trig)
                    {
                        Fractions.Add(num);
                        Output.Rows.Add(num.IntegerPart, num.Numerator, num.Denominator);
                        notSorted = true;
                    }
                }
            }
            else
                MessageBox.Show("Недопустимое число");
        }
        private void SortCollection_Click(object sender, EventArgs e)
        {
            Output.Rows.Clear();
            for (int i = 0; i < Fractions.Count; i++)
                if (((Fraction)Fractions[i]).IsImproper())
                {
                    ((Fraction)Fractions[i]).MakeProper();
                    ImproperFractions.Add(((Fraction)Fractions[i]));
                    Fractions.RemoveAt(i);
                    i--;
                }
            for (int i = 0; i < ImproperFractions.Count - 1; i++)
            {
                for (int j = i + 1; j < ImproperFractions.Count; j++)
                {
                    if (((Fraction)ImproperFractions[j]).CompareTo(ImproperFractions[i]) == 1)
                    {
                        Fraction temp = (Fraction)ImproperFractions[i];
                        ImproperFractions[i] = ImproperFractions[j];
                        ImproperFractions[j] = temp;
                    }
                }
            }
            for (int i = 0; i < Fractions.Count - 1; i++)
            {
                for (int j = i + 1; j < Fractions.Count; j++)
                {
                    if (((Fraction)Fractions[j]).CompareTo(Fractions[i]) == 1)
                    {
                        Fraction temp = (Fraction)Fractions[i];
                        Fractions[i] = Fractions[j];
                        Fractions[j] = temp;
                    }
                }
                Output.Rows.Add(((Fraction)Fractions[i]).IntegerPart, ((Fraction)Fractions[i]).Numerator, ((Fraction)Fractions[i]).Denominator);
            }
            if (Fractions.Count > 0)
                Output.Rows.Add(((Fraction)Fractions[Fractions.Count - 1]).IntegerPart, ((Fraction)Fractions[Fractions.Count - 1]).Numerator, ((Fraction)Fractions[Fractions.Count - 1]).Denominator);
            notSorted = false;
        }
        private void ImproperFractionsPrint(object sender, EventArgs e)
        {
            DeletedBox.Text = "";
            foreach (Fraction fraction in ImproperFractions)
                DeletedBox.Text += fraction.Print() + "\n";
        }

        private void ShowAmount(object sender, EventArgs e)
        {
            if (notSorted)
                MessageBox.Show("Сначала отсортируйте список!");
            else
                MessageBox.Show("Количество правильных дробей: " + Fractions.Count.ToString() + ". Неправильных: " + ImproperFractions.Count.ToString());
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fractions.Clear();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (open.ShowDialog() != System.Windows.Forms.DialogResult.OK) { return; }
            StreamReader read = new StreamReader(open.FileName);
            string s = "";
            while ((s = read.ReadLine()) != null)
            {
                string[] str = s.Split('|');
                Fractions.Add(new Fraction(Convert.ToInt32(str[0]), Convert.ToUInt32(str[1]), Convert.ToUInt32(str[2])));
            }
            read.Close();

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (save.ShowDialog() != System.Windows.Forms.DialogResult.OK) { return; }
            StreamWriter write = new StreamWriter(save.FileName);
            foreach (Fraction item in Fractions)
            {
                write.WriteLine(item.IntegerPart + "|" + item.Numerator + "|" + item.Denominator);
            }
            write.Close();

        }

        private void сериализацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Serialize file(*.bin)|*.bin|Все файлы(*.*)|*.*";
            if (save.ShowDialog() != System.Windows.Forms.DialogResult.OK) { return; }
            FileStream stream = new FileStream(save.FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, Fractions);
            stream.Close();

        }

        private void десериализацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Serialize file(*.bin)|*.bin|Все файлы(*.*)|*.*";
            if (open.ShowDialog() != System.Windows.Forms.DialogResult.OK) { return; }
            FileStream stream = new FileStream(open.FileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Fractions = (ArrayList)bf.Deserialize(stream);
            stream.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fractions = new ArrayList();
            ImproperFractions = new ArrayList();
        }
    }
}
