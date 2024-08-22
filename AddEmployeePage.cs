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
using System.Runtime.CompilerServices;
using staj_proje.Classes;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using staj_proje.Dal;


namespace staj_proje
{
    public partial class AddEmployeePage : Form
    {
        public AddEmployeePage()
        {
            InitializeComponent();
        }
        ProfilePage pPage = new ProfilePage();

        List<clsUnit> lstBirimler = new List<clsUnit>();

        void Birim_Doldur()
        {
            try
            {
                SqlOperations.CheckConnection(SqlOperations.con);

                string sorgu = "SELECT * FROM unit";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.con);

                DataTable dt = new DataTable("Birimler");

                da.Fill(dt);

                if (dt != null && dt.Rows  != null && dt.Rows.Count > 0)
                {
                    lstBirimler = new List<clsUnit>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        clsUnit u = new clsUnit();

                        if (dt.Rows[i]["UnitID"] != null && dt.Rows[i]["UnitID"] != DBNull.Value)
                        {
                            u.BirimID = Convert.ToInt32(dt.Rows[i]["UnitID"]);
                        }

                        if (dt.Rows[i]["UnitName"] != null && dt.Rows[i]["UnitName"] != DBNull.Value)
                        {
                            u.BirimAd = dt.Rows[i]["UnitName"].ToString();
                        }

                        lstBirimler.Add(u);
                    }
                }

                birimsec.DisplayMember = "BirimAd";
                birimsec.ValueMember = "BirimID";
                birimsec.DataSource = lstBirimler;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddEmployeePage_Load(object sender, EventArgs e)
        {
            //string unitname = "SELECT UnitName FROM unit";
            //SqlOperations.CheckConnection(SqlOperations.con);
            //SqlCommand cmddata = new SqlCommand(unitname, SqlOperations.con);

            //SqlDataReader reader = cmddata.ExecuteReader();

            //while (reader.Read())
            //{
            //    birimsec.Items.Add(reader[0]);

            //}
            //reader.Close();

            rolsec.Items.Add("Birim Yöneticisi");
            rolsec.Items.Add("Kullanıcı");

            //birimsec.DisplayMember = "";
            //birimsec.ValueMember = "";
            //birimsec.DataSource

            Birim_Doldur();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
                string query = "INSERT INTO employee (Name,Surname,Unit,Job,Role,ETel,TC,Address,UserName,Password) values (@Name,@Surname,@unit ,@Job,@Role,@Tel,@TC,@Address,@Username,@Password)";
                SqlCommand cmdadd = new SqlCommand(query, SqlOperations.con);
                SqlOperations.CheckConnection(SqlOperations.con);

                cmdadd.Parameters.AddWithValue("@Name", txtAd.Text);
                cmdadd.Parameters.AddWithValue("@Surname", txtSoyad.Text);
                cmdadd.Parameters.AddWithValue("@Unit", birimsec.SelectedValue);
                cmdadd.Parameters.AddWithValue("@Job", gorevsec.Text);
                cmdadd.Parameters.AddWithValue("@Role", rolsec.Text);
                cmdadd.Parameters.AddWithValue("@Tel", txtTel.Text);
                cmdadd.Parameters.AddWithValue("@TC", txtTC.Text);
                cmdadd.Parameters.AddWithValue("@Address", txtAdres.Text);
                cmdadd.Parameters.AddWithValue("@UserName", txtKullanıcı.Text);
                cmdadd.Parameters.AddWithValue("@Password", txtSifre.Text);

                cmdadd.ExecuteNonQuery();

                MessageBox.Show("Personel Kaydı Başarılı");
                pPage.Show();
                this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            pPage.Show();
            this.Close();
        }

        private void birimsec_SelectedValueChanged(object sender, EventArgs e)
        {
            gorevsec.Items.Clear();
            string jobname = "select JobName from unit as u Left join job as j ON u.UnitID = j.JobUnit where u.UnitName = '"+birimsec.Text+"'";
            SqlOperations.CheckConnection(SqlOperations.con);
            SqlCommand datacmd = new SqlCommand(jobname, SqlOperations.con);

            SqlDataReader reader1 = datacmd.ExecuteReader();

            while (reader1.Read())
            {
                gorevsec.Items.Add(reader1[0]);
            }
            reader1.Close();
        }
    }
}
