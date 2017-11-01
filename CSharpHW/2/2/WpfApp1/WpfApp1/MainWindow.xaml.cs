using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool op1=false;
            double z;
            op1 = double.TryParse(textBox1.Text, out z);
            if (op1)
            {
                sin.IsEnabled = true;
                cos.IsEnabled = true;
                tan.IsEnabled = true;
                ln.IsEnabled = true;
                sqrt.IsEnabled = true;
            }
            else
            {
                sin.IsEnabled = false;
                cos.IsEnabled = false;
                tan.IsEnabled = false;
                ln.IsEnabled = false;
                sqrt.IsEnabled = false;
                add.IsEnabled = false;
                sub.IsEnabled = false;
                div.IsEnabled = false;
                mul.IsEnabled = false;
                intDiv.IsEnabled = false;
                gra.IsEnabled = false;
                mod.IsEnabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool op2,op1 = false;
            double z;
            op2 = double.TryParse(textBox1.Text, out z);
            if (op2)
            {
                op1 = double.TryParse(textBox1.Text, out z);
                if (op1)
                {
                    add.IsEnabled = true;
                    sub.IsEnabled = true;
                    div.IsEnabled = true;
                    mul.IsEnabled = true;
                    intDiv.IsEnabled = true;
                    gra.IsEnabled = true;
                    mod.IsEnabled = true;
                    if (double.Parse(textBox2.Text) == 0)
                    {
                        div.IsEnabled = false;
                        mod.IsEnabled = false;
                        intDiv.IsEnabled = false;
                    }
                }
                else
                {
                    add.IsEnabled = false;
                    sub.IsEnabled = false;
                    div.IsEnabled = false;
                    mul.IsEnabled = false;
                    intDiv.IsEnabled = false;
                    gra.IsEnabled = false;
                    mod.IsEnabled = false;
                }

            }
            

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            /*double x = Int32.Parse(textBox1.Text);
              double y = Int32.Parse(textBox2.Text);*/
            result.Content = Math.Round(double.Parse(textBox1.Text) + double.Parse(textBox2.Text),2);
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            result.Content = Math.Round(double.Parse(textBox1.Text) - double.Parse(textBox2.Text), 2);
        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            result.Content = Math.Round(double.Parse(textBox1.Text) * double.Parse(textBox2.Text), 2);
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            result.Content = Math.Round(double.Parse(textBox1.Text) / double.Parse(textBox2.Text), 2);
        }

        private void mod_Click(object sender, RoutedEventArgs e)
        {
            result.Content = Math.Round(double.Parse(textBox1.Text) % double.Parse(textBox2.Text), 2);
        }

        private void intDiv_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            result.Content = Convert.ToInt32(x/y);
        }

        private void sqrt_Click(object sender, RoutedEventArgs e)
        {
            result.Content = Math.Round(Math.Sqrt(double.Parse(textBox1.Text)),2);
        }

        private void sin_Click(object sender, RoutedEventArgs e)
        {
            result.Content = Math.Round(Math.Sin(double.Parse(textBox1.Text)), 2);
        }

        private void cos_Click(object sender, RoutedEventArgs e)
        {
            result.Content = Math.Round(Math.Cos(double.Parse(textBox1.Text)), 2);
        }

        private void tan_Click(object sender, RoutedEventArgs e)
        {
            result.Content = Math.Round(Math.Tan(double.Parse(textBox1.Text)), 2);
        }

        private void ln_Click(object sender, RoutedEventArgs e)
        {
            result.Content = Math.Round(Math.Log(double.Parse(textBox1.Text)), 2);
        }

        private void gra_Click(object sender, RoutedEventArgs e)
        {
            result.Content = Math.Round(Math.Pow(double.Parse(textBox1.Text),double.Parse(textBox2.Text)), 2);
        }
    }
}
