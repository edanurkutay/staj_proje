using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using staj_proje.Classes;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
namespace staj_proje
{
   
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
        }


        public object MessaageBoxIcon { get; private set; }
        public static string isim;
        public static string soyisim;
        public static string rol;
        public static string unit;
        public static string Id;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmdControl = new SqlCommand("SELECT * FROM employee WHERE Username = @Username AND Password = @Password", SqlOperations.con);
            SqlOperations.CheckConnection(SqlOperations.con);

            cmdControl.Parameters.AddWithValue("@Username", txtUser.Text);
            cmdControl.Parameters.AddWithValue("@Password", txtPassword.Text);

            int count = 0;
            cmdControl.ExecuteNonQuery();

            

            using (SqlDataReader rdr = cmdControl.ExecuteReader())
            {
                while (rdr.Read())
                {
                    isim = rdr["Name"].ToString();
                    soyisim = rdr["Surname"].ToString();
                    rol = rdr["Role"].ToString();
                    unit = rdr["Unit"].ToString() ;
                    Id = rdr["EmployeeID"].ToString();
                    count++;

            


                }
            }
            

            if (count > 0)
            {
                SqlOperations.CheckConnection(SqlOperations.con);
                ProfilePage Profile = new ProfilePage();
                Profile.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("error in login");
            }
        }

        private void passwordShow_CheckedChanged(object sender, EventArgs e)
        {

            if (passwordShow.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
