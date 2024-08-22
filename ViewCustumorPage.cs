using staj_proje.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace staj_proje
{
    public partial class ViewCustumorPage : Form
    {
        private const string admin    = "Admin";
        private const string manager  = "Birim Yöneticisi";
        private const string employee = "Kullanıcı";
        public ViewCustumorPage()
        {
            InitializeComponent();

            if (LoginPage.rol == manager)
            {
                deleteCustomerButton.Visible = false;
            }
            else if (LoginPage.rol == admin)
            {
            
            }
        
        }

        public void RefreshPage()
        {
            if (LoginPage.rol == manager)
            {
                label1.Text = "Birimde Kaydedilen Müşteriler";
                string sorgu = "SELECT CustomerID AS 'Müşteri Numarası',CustomerName AS 'Ad', CustomerSurname AS 'Soyad',CTel AS 'Tel',Email,CustomerState AS 'Kayıt Durum',UnitName AS 'Kaydeden Birim', Name AS 'Kaydeden Ad',Surname AS 'Kaydeden Soyad' FROM unit u inner join customer c ON u.UnitID = c.Unit inner join employee e ON c.Affixer = e.EmployeeID  WHERE UnitID = '" + LoginPage.unit + "'";
                SqlCommand viewcmd = new SqlCommand(sorgu, SqlOperations.con);
                SqlOperations.CheckConnection(SqlOperations.con);

                SqlDataAdapter dAdptr = new SqlDataAdapter(viewcmd);
                DataTable dTable = new DataTable();
                dAdptr.Fill(dTable);
                customerGridView.DataSource = dTable;
            }
            else if(LoginPage.rol== employee)
            {
                label1.Text = "Kaydedilen Müşteriler";
                string sorgu = "SELECT CustomerID AS 'Müşteri Numarası',CustomerName AS 'Ad', CustomerSurname AS 'Soyad',CTel AS 'Tel',Email,CustomerState AS 'Kayıt Durum',UnitName AS 'Kaydeden Birim', Name AS 'Kaydeden Ad',Surname AS 'Kaydeden Soyad' FROM unit u inner join customer c ON u.UnitID = c.Unit inner join employee e ON c.Affixer = e.EmployeeID  WHERE  Affixer = '" + LoginPage.Id + "'";
                SqlCommand viewcmd = new SqlCommand(sorgu, SqlOperations.con);
                SqlOperations.CheckConnection(SqlOperations.con);

                SqlDataAdapter dAdptr = new SqlDataAdapter(viewcmd);
                DataTable dTable = new DataTable();
                dAdptr.Fill(dTable);
                customerGridView.DataSource = dTable;
            }

            else
            {
                string sorgu = "SELECT CustomerID AS 'Müşteri Numarası',CustomerName AS 'Ad', CustomerSurname AS 'Soyad',CTel AS 'Tel',Email,CustomerState AS 'Kayıt Durum',UnitName AS 'Kaydeden Birim', Name AS 'Kaydeden Ad',Surname AS 'Kaydeden Soyad' FROM unit u inner join customer c ON u.UnitID = c.Unit inner join employee e ON c.Affixer = e.EmployeeID  WHERE CustomerState = 'A'";
                SqlCommand viewcmd = new SqlCommand(sorgu, SqlOperations.con);
                SqlOperations.CheckConnection(SqlOperations.con);

                SqlDataAdapter dAdptr = new SqlDataAdapter(viewcmd);
                DataTable dTable = new DataTable();
                dAdptr.Fill(dTable);
                customerGridView.DataSource = dTable;
            }
        }
      
        private void ViewCustumorPage_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ProfilePage pPage = new ProfilePage();
            pPage.Show();
            this.Close();

        }


        int selectedID;
        private void deleteCustomerButton_Click(object sender, EventArgs e)
        { 
                
            DialogResult result = new DialogResult();

            result = MessageBox.Show("Müşteri Silinsin mi?","Müşteri Sil",MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            selectedID = Convert.ToInt32(customerGridView.CurrentRow.Cells["Müşteri Numarası"].Value);
          
            if (result == DialogResult.Yes)
            {
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM customer WHERE CustomerID = @selectedID", SqlOperations.con);
                SqlOperations.CheckConnection(SqlOperations.con);
                cmdDelete.Parameters.AddWithValue("@selectedID", selectedID);

                cmdDelete.ExecuteNonQuery();
                RefreshPage();
            }
       

        }

    }
}
