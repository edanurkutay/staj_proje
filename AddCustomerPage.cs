using staj_proje.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staj_proje
{
    public partial class AddCustomerPage : Form
    {
        public AddCustomerPage()
        {
            InitializeComponent();
        }
        ProfilePage pPage = new ProfilePage();

        private void backButton_Click(object sender, EventArgs e)
        {
            pPage.Show();
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO customer (CustomerName,CustomerSurname,Email,CTel,Unit,CustomerState,Affixer) values (@name,@surname,@mail,@tel,@unit,@cs,@a)";

            SqlCommand cmdadd = new SqlCommand(query, SqlOperations.con);
            SqlOperations.CheckConnection(SqlOperations.con);

            cmdadd.Parameters.AddWithValue("@name", txtName.Text);
            cmdadd.Parameters.AddWithValue("@surname", txtSurname.Text);
            cmdadd.Parameters.AddWithValue("@mail", txtMail.Text);
            cmdadd.Parameters.AddWithValue("@tel", txtTell.Text);
            cmdadd.Parameters.AddWithValue("@unit", LoginPage.unit);
            cmdadd.Parameters.AddWithValue("@cs",'P');
            cmdadd.Parameters.AddWithValue("@a", LoginPage.Id);


            cmdadd.ExecuteNonQuery();
            MessageBox.Show("Kayıt İşlemi Başarılı");
            pPage.Show();
            this.Close();
        }

      
    }
}
