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
using System.Windows.Shapes;

namespace IloiloCityCommunityCollege
{
    /// <summary>
    /// Interaction logic for windowLogin.xaml
    /// </summary>
    public partial class windowLogin : Window
    {
        public windowLogin()
        {
            InitializeComponent();
            pageReg we = new pageReg();
            Mainlog.NavigationService.Navigate(we);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mainlog.Content = new pageReg();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Mainlog.Content = new pageAdmin();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mainlog.Content = new pageAccounting();
        }
       

    }
}
