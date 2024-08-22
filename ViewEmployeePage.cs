using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using staj_proje.Classes;

namespace staj_proje
{
    public partial class ViewEmployeePage : Form
    {
        string adminRol    = "Admin";
        string managerRol  = "Birim Yöneticisi";
        string personelRol = "Kullanıcı";

        public ViewEmployeePage()
        {
            InitializeComponent();

            if (LoginPage.rol == managerRol)
            {


            }
            else if (LoginPage.rol == adminRol)
            {
                editUnitTextBox.Visible = true;
                label1.Visible = true;
                editRoleTextBox.Visible = true;
                label3.Visible = true;
                deleteEmployeeButton.Visible = true;
            }
            else
            {
               
            }

        }
        public void RefreshPage()
        {
            if (LoginPage.rol == adminRol)
            {
                string sorgu1 = "SELECT EmployeeID AS 'Personel Numarası',Name AS 'Ad',Surname AS 'Soyad',UnitName AS 'Çalıştığı Birim',Role AS 'Rol',ETel,JobName AS 'Görev',Address AS 'Adres'  FROM unit u inner join employee e ON u.UnitID = e.Unit  inner join job j ON  e.Job =j.JobID;";
                SqlCommand viewcmd = new SqlCommand(sorgu1, SqlOperations.con);
                SqlOperations.CheckConnection(SqlOperations.con);

                SqlDataAdapter dAdptr = new SqlDataAdapter(viewcmd);
                DataTable dTable = new DataTable();
                dAdptr.Fill(dTable);
                employeeGridView.DataSource = dTable;
            }
            else
            {
                string birim = LoginPage.unit;
                string sorgu2 = "SELECT EmployeeID AS 'Personel Numarası',Name AS 'Ad',Surname AS 'Soyad',UnitName AS 'Çalıştığı Birim',Role AS 'Rol',ETel,JobName AS 'Görev',Address AS 'Adres'  FROM unit u inner join employee e ON u.UnitID = e.Unit  inner join job j ON  e.Job =j.JobID WHERE e.Unit = '" + birim+"'";
                SqlCommand viewcmd = new SqlCommand(sorgu2, SqlOperations.con);
                SqlOperations.CheckConnection(SqlOperations.con);
                SqlDataAdapter dAdptr = new SqlDataAdapter(viewcmd);
                DataTable dTable = new DataTable();
                dAdptr.Fill(dTable);
                employeeGridView.DataSource = dTable;
            }
        }
  
        
        private void ViewEmployeePage_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ProfilePage pPage = new ProfilePage();
            pPage.Show();
            this.Close();
        }

        string selectedID;

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {   
            DialogResult result = DialogResult.Cancel;
            result = MessageBox.Show("Personel silme işlemi yapıyorsunuz. Emin misiniz?", "Personel silinsin mi?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM employee WHERE EmployeeID = @selectedID", SqlOperations.con);
                SqlOperations.CheckConnection(SqlOperations.con);

                cmdDelete.Parameters.AddWithValue("@selectedID", selectedID);

                cmdDelete.ExecuteNonQuery();
                RefreshPage();
            }
            else
            {

            }
        }

        private void employeeGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedID = (employeeGridView.CurrentRow.Cells["Personel Numarası"].Value).ToString();
            selectedLabel.Text = Convert.ToString(employeeGridView.CurrentRow.Cells["Ad"].Value);

            editUnitTextBox.Text = (employeeGridView.CurrentRow.Cells["Çalıştığı Birim"].Value).ToString();
            editJobTextBox.Text = (employeeGridView.CurrentRow.Cells["Görev"].Value).ToString();
            editRoleTextBox.Text= (employeeGridView.CurrentRow.Cells["Rol"].Value).ToString();

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmdedit = new SqlCommand("UPDATE employee SET Unit =@Unit, Job=@Job, Role=@Role WHERE EmployeeID=@selectedID", SqlOperations.con);
            SqlOperations.CheckConnection(SqlOperations.con);

            cmdedit.Parameters.AddWithValue("@Unit",editUnitTextBox.Text);
            cmdedit.Parameters.AddWithValue("@Job", editJobTextBox.Text);
            cmdedit.Parameters.AddWithValue("@Role", editRoleTextBox.Text);
            cmdedit.Parameters.AddWithValue("@selectedID", Convert.ToInt32(selectedID));
            cmdedit.ExecuteNonQuery();
            RefreshPage();
        }

    }
}
