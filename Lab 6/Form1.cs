using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            // Отримуємо значення коефіцієнтів a, b та c з TextBoxes
            double a, b, c;
            if (!double.TryParse(coeffATextBox.Text, out a) || !double.TryParse(coeffBTextBox.Text, out b) || !double.TryParse(coeffCTextBox.Text, out c))
            {
                MessageBox.Show("Будь ласка, введіть числове значення для всіх коефіцієнтів.");
                return;
            }

            // Обчислення дискримінанта
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                // Рівняння не має коренів у множині дійсних чисел
                rootsTextBox.Text = "Рівняння не має коренів у множині дійсних чисел.";
            }
            else if (discriminant == 0)
            {
                // Рівняння має один корінь
                double root = -b / (2 * a);
                rootsTextBox.Text = $"Рівняння має один корінь: {root}";
            }
            else
            {
                // Рівняння має два корені
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                rootsTextBox.Text = $"Рівняння має два корені: {root1} та {root2}";
            }
        }

        private void coeffATextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-' || textBox.SelectionStart != 0 || textBox.Text.Contains("-")))
            {
                e.Handled = true;
            }
        }

        private void coeffBTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-' || textBox.SelectionStart != 0 || textBox.Text.Contains("-")))
            {
                e.Handled = true;
            }
        }

        private void coeffCTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-' || textBox.SelectionStart != 0 || textBox.Text.Contains("-")))
            {
                e.Handled = true;
            }
        }
    }
}