using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void программаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Difference obj1 = new Difference(Convert.ToInt32(textBoxEarth.Text), Convert.ToInt32(textBoxMars.Text));
                textBoxDifference.Text = obj1.res.ToString();
            }

            catch
            {
                if (string.IsNullOrEmpty(textBoxEarth.Text))
                {
                    errorProviderNullEarth.SetError(textBoxEarth, "Поля не должны быть пустыми.");
                }
                else
                {
                    errorProviderNullEarth.Clear(); // Очистка ошибки, если поле не пустое
                }

                if (string.IsNullOrEmpty(textBoxMars.Text))
                {
                    errorProviderNullMars.SetError(textBoxMars, "Поля не должны быть пустыми.");
                }
                else
                {
                    errorProviderNullMars.Clear(); // Очистка ошибки, если поле не пустое
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                KmLargerPlanet obj2 = new KmLargerPlanet(Convert.ToInt32(textBoxEarth.Text), Convert.ToInt32(textBoxMars.Text));
                textBoxMoreThan.Text = obj2.res.ToString();
            }
           
            catch
            {
                if (string.IsNullOrEmpty(textBoxEarth.Text))
                {
                    errorProviderNullEarth.SetError(textBoxEarth, "Поля не должны быть пустыми.");
                }
                else
                {
                    errorProviderNullEarth.Clear(); // Очистка ошибки, если поле не пустое
                }

                if (string.IsNullOrEmpty(textBoxMars.Text))
                {
                    errorProviderNullMars.SetError(textBoxMars, "Поля не должны быть пустыми.");
                }
                else
                {
                    errorProviderNullMars.Clear(); // Очистка ошибки, если поле не пустое
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxEarth.Clear();
            textBoxMars.Clear();
            textBoxDifference.Clear();
            textBoxMoreThan.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void программаБольшеНаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void textBoxEarth_TextChanged(object sender, EventArgs e)
        {
            int inputNumber;
            if (!int.TryParse(textBoxEarth.Text, out inputNumber))
            {
                errorProviderSymbolEarth.SetError(textBoxEarth, "Ошибка. Пожалуйста, введите целочисленное значение.");
            }
            else
            {
                errorProviderSymbolEarth.Clear(); // Очистка ошибки, если введены целые числа
            }

            if (string.IsNullOrEmpty(textBoxEarth.Text))
            {
                errorProviderNullEarth.SetError(textBoxEarth, "Поля не должны быть пустыми.");
            }
            else
            {
                errorProviderNullEarth.Clear(); // Очистка ошибки, если поле не пустое
            }
        }

        private void textBoxMars_TextChanged(object sender, EventArgs e)
        {
            int inputNumber;
            if (!int.TryParse(textBoxMars.Text, out inputNumber))
            {
                errorProviderSymbolMars.SetError(textBoxMars, "Ошибка. Пожалуйста, введите целочисленное значение.");
            }
            else
            {
                errorProviderSymbolMars.Clear(); // Очистка ошибки, если введены целые числа
            }

            if (string.IsNullOrEmpty(textBoxMars.Text))
            {
                errorProviderNullMars.SetError(textBoxMars, "Поля не должны быть пустыми.");
            }
            else
            {
                errorProviderNullMars.Clear(); // Очистка ошибки, если поле не пустое
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}

// res - выполнить как свойство, нельзя оставлять с public! + выполнить работу через инкапсуляцию и не допустить отрицательные значения