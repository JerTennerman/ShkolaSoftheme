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
        int answer;
        int attempt;
        void Initialise()
        {
            Random rand = new Random();
            answer = rand.Next(10)+1;
            attempt = 1;
        }

        private void Guess_Click(object sender, RoutedEventArgs e)
        {
            if((Label.Content=="") || (Label.Content == "You've guessed"))
            {
                Initialise();
            }
            try
            {
                var effort = Int32.Parse(TextBox.Text);
                if (effort < 1 || effort > 10)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    if (effort != answer)
                    {
                        switch (attempt)
                        {
                            case 1:
                                {
                                    Label.Content = "You've got 2 more tries";
                                    attempt++;
                                    break;
                                }
                            case 2:
                                {
                                    Label.Content = "You've got 1 more tries";
                                    attempt++;
                                    break;
                                }
                            case 3:
                                {
                                    Label.Content = "You've lost, answer was " + answer;
                                    Initialise();
                                    break;
                                }
                            default: break;
                        }
                    }
                    else
                    {
                        Label.Content = "You've guessed";
                    }
                }
            }
            catch (FormatException formatException)
            {
                MessageBox.Show(formatException.Message);
            }
            catch(IndexOutOfRangeException indexException)
            {
                MessageBox.Show(indexException.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unexpected error has occured");
            }
        }
    }
}
