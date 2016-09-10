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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Page1 we = new Page1();
            Mainlog.NavigationService.Navigate(we);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mainlog.Content = new Page1();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mainlog.Content = new Page2();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Mainlog.Content = new Page4();
        }
    }
}
