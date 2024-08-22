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
    public partial class SettingsPage : Form
    {

        public SettingsPage()
        {
            InitializeComponent();
        }


        ProfilePage pPage= new ProfilePage();
        private void backButton_Click(object sender, EventArgs e)
        {
            pPage.Show();
            this.Close();
        }


        public void refresh()
        {
            SqlCommand viewcmd = new SqlCommand("SELECT EmployeeID,Name, Surname, Address,ETel, UserName FROM employee WHERE EmployeeID = '" + LoginPage.Id + "'", SqlOperations.con);
            SqlOperations.CheckConnection(SqlOperations.con);

            SqlDataAdapter dAdptr = new SqlDataAdapter(viewcmd);
            DataTable dTable = new DataTable();
            dAdptr.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["EmployeeID"].Value);

            SqlCommand cmdedit = new SqlCommand("UPDATE employee SET ETel = @tel, Address =@adres, Username =@uname WHERE EmployeeID=@selectedID", SqlOperations.con);
            SqlOperations.CheckConnection(SqlOperations.con);

            cmdedit.Parameters.AddWithValue("@tel", editTelTextBox.Text);
            cmdedit.Parameters.AddWithValue("@adres", editAddressTextBox.Text);
            cmdedit.Parameters.AddWithValue("@uname", editUsernameTextBox.Text);
            cmdedit.Parameters.AddWithValue("@selectedID", selectedID);
            cmdedit.ExecuteNonQuery();
            refresh();
        }

       

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            refresh();
        }

       
    }
}
