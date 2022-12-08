using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                if (n <= 0) MessageBox.Show("Размер массива не может быть неположительным");
                else
                {
                    double number = Convert.ToDouble(textBox2.Text);
                    int[] arr = new int[n];
                    string[] a = textBox3.Text.Split(' ');
                    if (a.Length > n) MessageBox.Show("Вы ввели больше числе, чем необходиом, данные будут обрезаны!!!");
                    for (int i = 0; i < n; i++)
                    {
                        if (Convert.ToInt32(a[i]) < number) arr[i] = Convert.ToInt32(a[i]) * 2;
                        else arr[i] = Convert.ToInt32(a[i]);
                    }

                    textBox8.Text = "";
                    for (int i = 0; i < n; i++)
                    {
                        textBox8.Text += arr[i];
                        if (i < arr.Length - 1) textBox8.Text += (", ");
                    }
                }
            }
            catch { MessageBox.Show("Некорректный ввод данных"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox4.Text);
                int m = Convert.ToInt32(textBox5.Text);
                if (n <= 0 || m <= 0) MessageBox.Show("Размер массива не может быть неположительным");
                else
                {
                    double number = Convert.ToDouble(textBox6.Text);
                    int[,] arr = new int[n, m];
                    string[] a = textBox7.Text.Split('\n');
                    if (a.Length > n) MessageBox.Show("Вы ввели больше числе, чем необходиом, данные будут обрезаны!!!");
                    for (int i = 0; i < n; i++)
                    {
                        string[] b = a[i].Split(' ');
                        for (int j = 0; j < m; j++)
                        {
                            if (b.Length > m) MessageBox.Show("Вы ввели больше числе, чем необходиом, данные будут обрезаны!!!");
                            if (Convert.ToDouble(b[j]) < number) arr[i, j] = Convert.ToInt32(b[j]) * 2;
                            else arr[i, j] = Convert.ToInt32(b[j]);
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++) textBox9.Text += arr[i, j] + "  ";
                        textBox9.Text += Environment.NewLine;
                    }
                }
            }
            catch { MessageBox.Show("Некорректный ввод данных"); }
        }
    }
}
