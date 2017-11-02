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

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            err.Content = "";
            Int32.TryParse(dd.Text, out int d);
            if (d > 0 && d <= 31)
            {
                Int32.TryParse(mm.Text, out int m);
                if (m > 0 && m < 13)
                {
                    Int32.TryParse(yyyy.Text, out int y);
                    if (DayMonth(d, m, y) && y != 0)
                    {
                        ZodiacSign(d, m);
                    }
                    else
                    {
                        zodImg.Source = null;
                        err.Content += ("invalid year");
                    }
                }
                else
                {
                    zodImg.Source = null;
                    err.Content += ("invalid month");
                }
            }
            else
            {
                zodImg.Source = null;
                err.Content= ("invalid day   ");
            }
        }
        static bool DayMonth(int d, int m, int y)
        {
            bool legit = true;
            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                if (d > 31)
                {
                    legit = false;
                }
            }
            else
            {
                if (m == 2)
                {
                    if (LeapYear(y))
                    {
                        if (d > 29)
                        {
                            legit = false;
                        }
                    }
                    else if (d > 29)
                    {
                        legit = false;
                    }
                }
                else
                {
                    if (d > 30)
                    {
                        legit = false;
                    }
                }
            }
            return legit;
        }

        static bool LeapYear(int y)
        {
            bool leap = true;
            if (y > 0 && y % 4 == 0)
            {
                if (y % 100 == 0 && y % 400 != 0)
                {
                    leap = false;
                }
            }
            else
            {
                leap = false;
            }
            return leap;
        }

        void ZodiacSign(int d, int m)
        {
            switch (m)
            {
                case 1:
                    if (d <= 20)
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Capricorn.svg/246px-Capricorn.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    else
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/2/24/Aquarius.svg/350px-Aquarius.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    break;
                case 2:
                    if (d <= 19)
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/2/24/Aquarius.svg/350px-Aquarius.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    else
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Pisces.svg/189px-Pisces.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    break;
                case 3:
                    if (d <= 20)
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Pisces.svg/189px-Pisces.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    else
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/5/5e/Aries.svg/248px-Aries.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    break;
                case 4:
                    if (d <= 20)
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/5/5e/Aries.svg/248px-Aries.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    else
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3a/Taurus.svg/225px-Taurus.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    break;
                case 5:
                    if (d <= 21)
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3a/Taurus.svg/225px-Taurus.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    else
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/Gemini.svg/229px-Gemini.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    break;
                case 6:
                    if (d <= 21)
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/Gemini.svg/229px-Gemini.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    else
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Cancer.svg/300px-Cancer.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    break;
                case 7:
                    if (d <= 22)
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Cancer.svg/300px-Cancer.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    else
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Leo.svg/184px-Leo.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    break;
                case 8:
                    if (d <= 21)
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Leo.svg/184px-Leo.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    else
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Virgo.svg/194px-Virgo.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    break;
                case 9:
                    if (d <= 23)
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Virgo.svg/194px-Virgo.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    else
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/f/f7/Libra.svg/281px-Libra.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    break;
                case 10:
                    if (d <= 23)
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/f/f7/Libra.svg/281px-Libra.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    else
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Scorpio.svg/214px-Scorpio.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    break;
                case 11:
                    if (d <= 22)
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Scorpio.svg/214px-Scorpio.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    else
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Sagittarius.svg/235px-Sagittarius.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    break;
                case 12:
                    if (d <= 22)
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Sagittarius.svg/235px-Sagittarius.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    else
                    {
                        var bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Capricorn.svg/246px-Capricorn.svg.png"); ;
                        bitmapImage.EndInit();

                        zodImg.Source = bitmapImage;
                    }
                    break;
                default: break;

            }
        }
        }
}
