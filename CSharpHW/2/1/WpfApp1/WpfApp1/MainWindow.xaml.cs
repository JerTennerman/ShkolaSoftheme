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

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            sbyte sbyteVar = default(sbyte);
            maxValue.Content = sbyte.MaxValue;
            minValue.Content = sbyte.MinValue;
            defValue.Content = sbyteVar;
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            long longVar = default(long);
            maxValue.Content = long.MaxValue;
            minValue.Content = long.MinValue;
            defValue.Content = longVar;
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            short shortVar = default(short);
            maxValue.Content = short.MaxValue;
            minValue.Content = short.MinValue;
            defValue.Content = shortVar;
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            int intVar = default(int);
            maxValue.Content = int.MaxValue;
            minValue.Content = int.MinValue;
            defValue.Content = intVar;
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            byte byteVar = default(byte);
            maxValue.Content = byte.MaxValue;
            minValue.Content = byte.MinValue;
            defValue.Content = byteVar;
        }

        private void ListBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            ushort ushortVar = default(ushort);
            maxValue.Content = ushort.MaxValue;
            minValue.Content = ushort.MinValue;
            defValue.Content = ushortVar;
        }

        private void ListBoxItem_Selected_6(object sender, RoutedEventArgs e)
        {
            uint uintVar = default(uint);
            maxValue.Content = uint.MaxValue;
            minValue.Content = uint.MinValue;
            defValue.Content = uintVar;
        }

        private void ListBoxItem_Selected_7(object sender, RoutedEventArgs e)
        {
            ulong ulongVar = default(ulong);
            maxValue.Content = ulong.MaxValue;
            minValue.Content = ulong.MinValue;
            defValue.Content = ulongVar;
        }

        private void ListBoxItem_Selected_8(object sender, RoutedEventArgs e)
        {
            float floatVar = default(float);
            maxValue.Content = float.MaxValue;
            minValue.Content = float.MinValue;
            defValue.Content = floatVar;
        }

        private void ListBoxItem_Selected_9(object sender, RoutedEventArgs e)
        {
            double doubleVar = default(double);
            maxValue.Content = double.MaxValue;
            minValue.Content = double.MinValue;
            defValue.Content = doubleVar;
        }

        private void ListBoxItem_Selected_10(object sender, RoutedEventArgs e)
        {
            decimal decimalVar = default(decimal);
            maxValue.Content = decimal.MaxValue;
            minValue.Content = decimal.MinValue;
            defValue.Content = decimalVar;
        }
    }
}
