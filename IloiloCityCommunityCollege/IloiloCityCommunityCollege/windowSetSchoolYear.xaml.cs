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
    /// Interaction logic for windowSetSchoolYear.xaml
    /// </summary>
    /// 
    public partial class windowSetSchoolYear : Window
    {
        public windowSetSchoolYear()
        {
            InitializeComponent();
        }

        private void btnset_Click(object sender, RoutedEventArgs e)
        {
            string year;
            year = txtschoolyear.Text;
            clsDbconnection conn = new clsDbconnection();
            string query = "INSERT  INTO schoolyear(SchoolYear) Values" + "('" + year + "')";
            conn.saveData(query);
            if (conn.ErrorMsg != null)
            {
                MessageBox.Show(conn.ErrorMsg);
            }
            else
            {
                MessageBox.Show("School year has been updated", "SAVED", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }

        }
    }
}
