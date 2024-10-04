using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Generator
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int min) && int.TryParse(textBox2.Text, out int max))
            {
                if (min > max)
                {
                    MessageBox.Show("Минимальное значение не может быть больше максимального.");
                }
                else
                {
                    int randomNumber = random.Next(min, max + 1);
                    label1.Text = $"Случайное число: {randomNumber}";
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа.");
            }
        }
    }
}