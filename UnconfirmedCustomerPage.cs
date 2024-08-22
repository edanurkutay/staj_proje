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

namespace staj_proje
{
    public partial class UnconfirmedCustomerPage : Form
    {

        string adminrol   = "Admin";
        string managerrol = "Birim Yöneticisi";
        string emprol     = "Kullanıcı";
        public UnconfirmedCustomerPage()
        {
            InitializeComponent();
        }

        public void Refreshpage()
        {
            if (LoginPage.rol == managerrol)
            {
                SqlCommand viewcmd = new SqlCommand("SELECT CustomerID AS 'Müşteri Numarası',CustomerName AS 'Ad', CustomerSurname AS 'Soyad',CTel AS 'Tel',Email,CustomerState AS 'Kayıt Durum',UnitName AS 'Kaydeden Birim', Name AS 'Kaydeden Ad',Surname AS 'Kaydeden Soyad' FROM unit u inner join customer c ON u.UnitID = c.Unit inner join employee e ON c.Affixer = e.EmployeeID  WHERE CustomerState= 'P' AND UnitID = '" + LoginPage.unit+"' ", SqlOperations.con);
                SqlOperations.CheckConnection(SqlOperations.con);

                SqlDataAdapter dAdptr = new SqlDataAdapter(viewcmd);
                DataTable dTable = new DataTable();
                dAdptr.Fill(dTable);
                customerGridView.DataSource = dTable;
            }

            else 
            {
                SqlCommand viewcmd = new SqlCommand("SELECT CustomerID AS 'Müşteri Numarası',CustomerName AS 'Ad', CustomerSurname AS 'Soyad',CTel AS 'Tel',Email,CustomerState AS 'Kayıt Durum',UnitName AS 'Kaydeden Birim', Name AS 'Kaydeden Ad',Surname AS 'Kaydeden Soyad' FROM unit u inner join customer c ON u.UnitID = c.Unit inner join employee e ON c.Affixer = e.EmployeeID  WHERE CustomerState= 'G'", SqlOperations.con);
                SqlOperations.CheckConnection(SqlOperations.con);

                SqlDataAdapter dAdptr = new SqlDataAdapter(viewcmd);
                DataTable dTable = new DataTable();
                dAdptr.Fill(dTable);
                customerGridView.DataSource = dTable;
            }
        }
        private void UnconfirmedCustomerPage_Load(object sender, EventArgs e)
        {

            Refreshpage();

        }
        string selectedID;
        private void customerGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedID = (customerGridView.CurrentRow.Cells["Müşteri Numarası"].Value).ToString();

        }

   

        private void customerAccept_Click(object sender, EventArgs e)
        {
            if (LoginPage.rol == adminrol)
            {
                SqlCommand cmdedit = new SqlCommand("UPDATE customer SET CustomerState='A' WHERE CustomerID = @selectedID", SqlOperations.con);
                SqlOperations.CheckConnection(SqlOperations.con);

                cmdedit.Parameters.AddWithValue("CustomerState", 'A');
                cmdedit.Parameters.AddWithValue("selectedID", Convert.ToInt32(selectedID));
                cmdedit.ExecuteNonQuery();
                Refreshpage();
            }
            else
            {
                SqlCommand cmdedit = new SqlCommand("UPDATE customer SET CustomerState='G' WHERE CustomerID = @selectedID", SqlOperations.con);
                SqlOperations.CheckConnection(SqlOperations.con);

                cmdedit.Parameters.AddWithValue("CustomerState", "G");
                cmdedit.Parameters.AddWithValue("selectedID", Convert.ToInt32(selectedID));
                cmdedit.ExecuteNonQuery();
                Refreshpage();
            }

        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmdDelete = new SqlCommand("DELETE FROM customer WHERE CustomerID = @selectedID", SqlOperations.con);
            SqlOperations.CheckConnection(SqlOperations.con);

            cmdDelete.Parameters.AddWithValue("@selectedID", Convert.ToInt32(selectedID));

            cmdDelete.ExecuteNonQuery();
            Refreshpage();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ProfilePage pPage = new ProfilePage();
            pPage.Show();
            this.Close();
        }
    }
}
