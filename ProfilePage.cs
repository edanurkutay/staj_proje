using staj_proje.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staj_proje
{
    public partial class ProfilePage : Form
    {
        private const string admin    = "Admin";
        private const string manager  = "Birim Yöneticisi";
        private const string employee = "Kullanıcı";


        public ProfilePage()
        {
            InitializeComponent();
            if (LoginPage.rol == manager)
            {
                roleLabel.Text                = "Birim Yöneticisi";
                viewEmployeeButton.Visible    = true;
                viewCustomerButton.Visible    = true;
                customerConsentButton.Visible = true;

            }
            else if (LoginPage.rol == admin)
            {
                addEmployeeButton.Visible     = true;
                viewEmployeeButton.Visible    = true;
                viewCustomerButton.Visible    = true;
                customerConsentButton.Visible = true;
                addCustomerButton.Visible     = false;
                excelBut.Visible              = true;
                
            }
            else
            {
                roleLabel.Text = "Personel";
                viewCustomerButton.Visible = true;
            }

            NameLabel.Text = LoginPage.isim + " " + LoginPage.soyisim; 
        }
        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeePage addemp = new AddEmployeePage();
            addemp.Show();
            this.Close();

        }

        private void viewEmployeeButton_Click(object sender, EventArgs e)
        {
            ViewEmployeePage viewemp = new ViewEmployeePage();
            viewemp.Show();
            this.Close();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            LoginPage lgnp = new LoginPage();
            lgnp.Show();
            this.Close();

        }

        private void viewCustomerButton_Click(object sender, EventArgs e)
        {
            ViewCustumorPage cstmrpage = new ViewCustumorPage();
            cstmrpage.Show();
            this.Close();

        }

        private void customerConsentButton_Click(object sender, EventArgs e)
        {
            UnconfirmedCustomerPage uc = new UnconfirmedCustomerPage(); 
            uc.Show();
            this.Close();

        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerPage addCustomer = new AddCustomerPage();
            addCustomer.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SettingsPage sPage = new SettingsPage();
            sPage.Show();
            this.Close();

        }

        private void excelBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası |*.xls";
            openFile.Title = "Aktarılacak dosyayı seçiniz";

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Test");
            }





        }
    }
}
