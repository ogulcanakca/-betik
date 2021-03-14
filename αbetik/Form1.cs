using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace αbetik
{
    public partial class Form1 : Form
    {
        public αbetik αbetik = new αbetik();

        public IManagerPanelInformationService _iManagerPanelInformationService;
        public Form1()
        {
            _iManagerPanelInformationService = InstanceFactory.GetInstance<IManagerPanelInformationService>();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  
        public void btnTC_Click(object sender, EventArgs e)
        {
            //string tc = tbxTC.Text;
            //Sqlbaglan.NesneVer().thisOleConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=giris.accdb");
            //Sqlbaglan.NesneVer().thisOleQuery = new OleDbCommand();
            //Sqlbaglan.NesneVer().thisOleConn.Open();
            //Sqlbaglan.NesneVer().thisOleQuery.Connection = Sqlbaglan.NesneVer().thisOleConn;
            //Sqlbaglan.NesneVer().thisOleQuery.CommandText = "SELECT * FROM giris where TC='" + tbxTC.Text + "'";
            //Sqlbaglan.NesneVer().thisOleDr = Sqlbaglan.NesneVer().thisOleQuery.ExecuteReader();
            //if (Sqlbaglan.NesneVer().thisOleDr.Read())
            //{
           
            if (Application.OpenForms["αbetik"] == null)
            {
                αbetik.Show();
            }
            this.Hide();
            //ayarlar.Show();
            //αbetik.btnAyarlar_Click(new object(), EventArgs.Empty);
            //}
            //else
            //{
            //    MessageBox.Show("Girilen TC yanlış ya da kayıtlı değil.");
            //}
            //Sqlbaglan.NesneVer().thisOleConn.Close();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        
        public void tbxTC_TextChanged(object sender, EventArgs e)
        {
            αbetik.tbxTCC.Text = tbxTC.Text;



        }
        
    }
}
