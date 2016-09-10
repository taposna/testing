using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Security.Cryptography;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace IloiloCityCommunityCollege
{
    /// <summary>
    /// Interaction logic for pageStudent.xaml
    /// </summary>
    public partial class pageStudent : Page
    {
        private clsDbconnection conn;
        private string ID;
        private string Firstname;
        private string Middlename;
        private string Lastname;
        private string Address;
        private string Course;
        private string SchoolYear;
        private string status;
        private string Date;
        private string Gender;
        private string Contact;

        public pageStudent()
        {
            InitializeComponent();
        }
        private void GenID()
        {
            // conn = new clsDbconnection();
            // string query = "SELECT COUNT(ID) FROM student";
            // txt_usn.Text = "StudentID: " +  conn.GenerateID(query).ToString();
            var bytes = new byte[10];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            uint random = BitConverter.ToUInt32(bytes, 0) % 1000000000;
            txtID.Text = String.Format("{0:D9}", random);
        }
        private void schoolYear()
        {
            conn = new clsDbconnection();
            string query = "SELECT SchoolYear From schoolyear DSC";
            txtSY.Text = conn.GetSchoolYear(query);
        }
        public void search()
        {
            try
            {
                string query = null;
                if (cmbxfilter.SelectedIndex == 0)
                {
                    query = "SELECT * FROM student WHERE ID LIKE '%" + txtsearch.Text + "%'";
                }
                else if (cmbxfilter.SelectedIndex == 1)
                {
                    query = "SELECT * FROM student WHERE Firstname LIKE '%" + txtsearch.Text + "%'";
                }
                else if (cmbxfilter.SelectedIndex == 2)
                {
                    query = "SELECT * FROM student WHERE Lastname LIKE '%" + txtsearch.Text + "%'";
                }
                else
                {
                    query = "SELECT * FROM student WHERE firstname LIKE '%" + txtsearch.Text + "%'";
                }
                conn = new clsDbconnection();
                //Firstname = txtsearch.Text;
               // string query = "SELECT * FROM student WHERE firstname = '" + Firstname + "'";
                conn.GetStudent(query);
                txtID2.Text = conn.ID;
                txtfname2.Text = conn.firstname;
                txtmname2.Text = conn.middlename;
                txtlname2.Text = conn.lastname;
                txtaddress2.Text = conn.address;
                cmbxcourse2.Text = conn.sex;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtID_Loaded(object sender, RoutedEventArgs e)
        {
            GenID();
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            conn = new clsDbconnection();
            ID = txtID.Text;
            Firstname = txtfname.Text;
            Middlename = txtmname.Text;
            Lastname = txtfname.Text;
            Address = txtaddress.Text;
            Course = cmbxcourse.Text;
            SchoolYear = txtSY.Text;
            Gender = cmbxgender.Text;
            status = txtlvl.Text;
            Contact = txtcontact.Text;
            //Date = DatePicker.

            string query = "INSERT INTO student(ID , firstname , middlename , lastname , address , course , year , status ,Gender , contact) VALUES"+
                "('"+ ID +"', '"+Firstname+"','"+Middlename+"','"+Lastname+"','"+Address+"','"+Course+"','"+SchoolYear+"','"+status+"','"+Gender+"','"+Contact+"')";
            conn.saveData(query);
            if (conn.ErrorMsg != null)
            {
                MessageBox.Show(conn.ErrorMsg);
            }
            var ans = MessageBox.Show("New student have been added to your database", "Successfully Saved", MessageBoxButton.OK, MessageBoxImage.Information);
            if (ans == MessageBoxResult.OK)
            {
                pageMain x = new pageMain();
                this.NavigationService.Navigate(x);

            }
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            conn = new clsDbconnection();
            string query = "SELECT * FROM student";
            DataSet ds = new DataSet();
            conn.FillData(ds, query);
            Data.DataContext = ds.Tables[0];
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            search();
        }

        private void TabItem_Loaded(object sender, RoutedEventArgs e)
        {
            conn = new clsDbconnection();
            string query = "SELECT * FROM student";
            DataSet ds = new DataSet();
            conn.FillData(ds, query);
            Data.DataContext = ds.Tables[0];
        }

        private void txtSY_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtSY_Loaded(object sender, RoutedEventArgs e)
        {
            schoolYear();
        }

        private void Data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
