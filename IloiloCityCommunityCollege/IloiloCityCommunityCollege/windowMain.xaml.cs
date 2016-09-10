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
    /// Interaction logic for windowMain.xaml
    /// </summary>
    public partial class windowMain : Window
    {
        public windowMain()
        {
            InitializeComponent();
            pageMain x = new pageMain();
            pageframe.NavigationService.Navigate(x);
            
        }


        private void stubtn_Click(object sender, RoutedEventArgs e)
        {
            pageStudent x = new pageStudent();
            pageframe.NavigationService.Navigate(x);
        }

        private void btnexit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnhome_Click(object sender, RoutedEventArgs e)
        {
            pageMain x = new pageMain();
            pageframe.NavigationService.Navigate(x);
        }

        private void btnsetSy_Click(object sender, RoutedEventArgs e)
        {
            windowSetSchoolYear x = new windowSetSchoolYear();
            x.ShowDialog();
        }
    }
}
