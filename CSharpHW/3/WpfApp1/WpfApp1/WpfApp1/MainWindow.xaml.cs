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

        private void addUser_Click(object sender, RoutedEventArgs e)
        {
            FirstName();
            LastName();
            DOB();
            Gender();
            Email();
            Phone();
            AddInfo();
            if(result1.Content==null && result2.Content == null && result3.Content == null && result4.Content == null && result5.Content == null && result6.Content == null && result7.Content == null )
            {
                result1.Content = "new member registered";
            }
        }
        private void FirstName()
        {
            bool r1=true;
            if((fnInput.Text).Length>=255)
            {
                r1 = false;
            }else 
            if ((fnInput.Text).Any(char.IsDigit))
            {
                r1 = false;
            }
            if (!r1 || fnInput.Text=="")
            {
                result1.Content = "incorrect first name";
            }
            else
            {
                result1.Content = null;
            }
        }
        private void LastName()
        {
            bool r2 = true;
            if ((lnInput.Text).Length >= 255)
            {
                r2 = false;
            }
            else
            if ((lnInput.Text).Any(char.IsDigit))
            {
                r2 = false;
            }
            if (!r2 || lnInput.Text=="")
            {
                result2.Content = "incorrect last name";
            }
            else
            {
                result2.Content = null;
            }

        }
        private void DOB()
        {
            int d, m, y;
            bool r3 = Int32.TryParse(dd.Text, out d);
            if (r3 == true && d > 0 && d < 32)
            {
                r3 = Int32.TryParse(mm.Text, out m);
                if (r3 == true && m > 0 && m < 13)
                {
                    r3 = Int32.TryParse(yyyy.Text, out y);
                    if (r3 == true && y > 1900 && y < 2018)
                    {
                    }
                    else r3 = false;
                }
                else r3 = false;
            }
            else r3 = false;
            if(!r3)
            {
                result3.Content = "incorrect DOB";
            }
            else
            {
                result3.Content = null;
            }
        }
        private void Gender()
        {
            bool r4;
            if (genderInput.Text == "male" || genderInput.Text == "female")
            {
                 r4 = true;
            }
            else  r4 = false;
            if(!r4)
            {
                result4.Content = "incorrect gender";
            }
            else
            {
                result4.Content = null;
            }
        }
        private void Email()
        {
            bool r5=true;
            if(!(emailInput.Text).Contains('@') || emailInput.Text.Length>=255)
            {
                r5 = false;
            }
            if(!r5)
            {
                result5.Content = "incorrect Email";
            }
            else
            {
                result5.Content = null;
            }
        }
        private void Phone()
        {
            int number;
            bool r6 = Int32.TryParse(phoneInput.Text, out number);
            if(!r6==true && !(phoneInput.Text.Length==12))
            {
                r6 = false;
            }
            if(!r6)
            {
                result6.Content = "incorrect phone number";
            }
            else
            {
                result6.Content = null;
            }
        }
        private void AddInfo()
        {
            bool r7 = false;
            if(addInfo.Text.Length<2000)
            {
                r7 = true;
            }
            if (!r7)
            {
                result7.Content = "too much additional info";
            }
            else
            {
                result7.Content = null;
            }
        }
    }
}
