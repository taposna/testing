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

namespace IloiloCityCommunityCollege
{
    /// <summary>
    /// Interaction logic for pageMain.xaml
    /// </summary>
    public partial class pageMain : Page
    {
        clsDbconnection conn = new clsDbconnection();
        public pageMain()
        {
            InitializeComponent();
        }
        public void _count()
        {
            //total students
            conn = new clsDbconnection();
            string query = "SELECT COUNT(*) FROM student";
            totalcount.Content = conn.count(query).ToString();
            //total student in BSOA
            query = "SELECT COUNT(*) FROM student WHERE course = 'Bachelor of Science in Office Administration'";
            totalbsoa.Content = conn.count(query).ToString();
            //total student in BSTRm
            query = "SELECT COUNT(*) FROM student WHERE course = 'Bachelor of Science in Travel Management'";
            totalbstrm.Content = conn.count(query).ToString();

        }

        private void totalcount_Loaded(object sender, RoutedEventArgs e)
        {
            _count();
        }
    }
}
