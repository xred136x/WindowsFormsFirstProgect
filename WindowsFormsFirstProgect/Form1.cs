using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsFirstProgect
{
    public partial class Calculator : Form
    {
        float a, b;
        int count;
        string path = "historyCalculate.txt";
        string text;
        public Calculator()
        {
            InitializeComponent();
        }

        

        private void Null_Click(object sender, EventArgs e)
        {
            Console.Text = Console.Text + 0;
        }

        private void One_Click(object sender, EventArgs e)
        {
            Console.Text = Console.Text + 1;
        }

        private void Console_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void three_Click(object sender, EventArgs e)
        {
            Console.Text = Console.Text + 3;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Console.Text = Console.Text + 2;
        }

        private void four_Click(object sender, EventArgs e)
        {
            Console.Text = Console.Text + 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            Console.Text = Console.Text + 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            Console.Text = Console.Text + 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Console.Text = Console.Text + 7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Console.Text = Console.Text + 8;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            a = float.Parse(Console.Text);
            Console.Clear();
            count = 1;
            
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            a = float.Parse(Console.Text);
            Console.Clear();
            count = 2;
            
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            a = float.Parse(Console.Text);
            Console.Clear();
            count = 3;
            
        }

        private void divide_Click(object sender, EventArgs e)
        {
            a = float.Parse(Console.Text);
            Console.Clear();
            count = 4;
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Console.Clear();
        }

        private void equally_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(Console.Text);
                    text = $"{a} + {Console.Text} = {b}";
                    Console.Text = b.ToString();
                    using (StreamWriter stream = new StreamWriter(path, true))
                    {
                        stream.WriteLine(text);
                    }
                    break;
                case 2:
                    b = a - float.Parse(Console.Text);
                    text = $"{a} - {Console.Text} = {b}";
                    Console.Text = b.ToString();
                    using (StreamWriter stream = new StreamWriter(path, true))
                    {
                        stream.WriteLine(text);
                    }
                    break;
                case 3:
                    b = a * float.Parse(Console.Text);
                    text = $"{a} * {Console.Text} = {b}";
                    Console.Text = b.ToString();
                    using (StreamWriter stream = new StreamWriter(path, true))
                    {
                        stream.WriteLine(text);
                    }
                    break;
                case 4:
                    if (float.Parse(Console.Text) != 0)
                    {
                        b = a / float.Parse(Console.Text);
                        text = $"{a} / {Console.Text} = {b}";
                        Console.Text = b.ToString();
                        using (StreamWriter stream = new StreamWriter(path, true))
                        {
                            stream.WriteLine(text);
                        }
                        break;
                    }
                    else
                        Console.Text = "error";break;

                default:
                    break;
            }

        }
        private void nine_Click(object sender, EventArgs e)
        {
            Console.Text = Console.Text + 9;
        }
    }
}
