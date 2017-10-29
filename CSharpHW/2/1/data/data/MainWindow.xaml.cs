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

namespace data
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
            minValue.Content = sbyte.MinValue;
            maxValue.Content = sbyte.MaxValue;
            defValue.Content = sbyteVar;
        }


        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            long longVar = default(long);
            minValue.Content = long.MinValue;
            maxValue.Content = long.MaxValue;
            defValue.Content = longVar;
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            short shortVar = default(short);
            minValue.Content = short.MinValue;
            maxValue.Content = short.MaxValue;
            defValue.Content = shortVar;
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            int intVar = default(int);
            minValue.Content = int.MinValue;
            maxValue.Content = int.MaxValue;
            defValue.Content = intVar;
        }

        private void ListBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            byte byteVar = default(byte);
            minValue.Content = byte.MinValue;
            maxValue.Content = byte.MaxValue;
            defValue.Content = byteVar;
        }

        private void ListBoxItem_Selected_6(object sender, RoutedEventArgs e)
        {
            ushort ushortVar = default(ushort);
            minValue.Content = ushort.MinValue;
            maxValue.Content = ushort.MaxValue;
            defValue.Content = ushortVar;
        }

        private void ListBoxItem_Selected_7(object sender, RoutedEventArgs e)
        {
            uint uintVar = default(uint);
            minValue.Content = uint.MinValue;
            maxValue.Content = uint.MaxValue;
            defValue.Content = uintVar;
        }

        private void ListBoxItem_Selected_8(object sender, RoutedEventArgs e)
        {
             ulong ulongVar = default(ulong);
            minValue.Content = ulong.MinValue;
            maxValue.Content = ulong.MaxValue;
            defValue.Content = ulongVar;
        }

        private void ListBoxItem_Selected_9(object sender, RoutedEventArgs e)
        {
            float floatVar = default(float);
            minValue.Content = float.MinValue;
            maxValue.Content = float.MaxValue;
            defValue.Content = floatVar;
        }

        private void ListBoxItem_Selected_10(object sender, RoutedEventArgs e)
        {
            double doubleVar = default(double);
            minValue.Content = double.MinValue;
            maxValue.Content = double.MaxValue;
            defValue.Content = doubleVar;
        }

        private void ListBoxItem_Selected_11(object sender, RoutedEventArgs e)
        {
            decimal decimalVar = default(decimal);
            minValue.Content = decimal.MinValue;
            maxValue.Content = decimal.MaxValue;
            defValue.Content = decimalVar;
        }
    }
}
