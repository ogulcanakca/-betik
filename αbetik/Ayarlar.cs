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

namespace αbetik
{
    public partial class Ayarlar : Form
    {
        
        public IManagerPanelInformationService _iManagerPanelInformationService;
        public IPublishingInformationService _iPublishingInformationService;

        public Ayarlar()
        {

            _iManagerPanelInformationService = InstanceFactory.GetInstance<IManagerPanelInformationService>();
            _iPublishingInformationService = InstanceFactory.GetInstance<IPublishingInformationService>();
            InitializeComponent();
        }

       
        private void dgwRules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            tbxId.Text = dgwRules.CurrentRow.Cells[0].Value.ToString();
            tbxTC.Text = dgwRules.CurrentRow.Cells[1].Value.ToString();
            tbxRules.Text = dgwRules.CurrentRow.Cells[2].Value.ToString();
            

        }
        public void Ayarlar_Load(object sender, EventArgs e)
        {
            idGetir();
            
            //lblRules.Text = dgwRules.CurrentRow.Cells[2].Value.ToString();
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            //Sqlbaglan.NesneVer().thisConn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;initial catalog = ManagerPanel;integrated security = true");
            //Sqlbaglan.NesneVer().thisConn.Open();
            //Sqlbaglan.NesneVer().thisQuery = new SqlCommand("INSERT INTO [Rules] (Kurallar, TC) VALUES (@Kurallar, @TC) ", Sqlbaglan.NesneVer().thisConn);
            //Sqlbaglan.NesneVer().thisQuery.Parameters.AddWithValue("Kurallar", tbxRules.Text);
            //Sqlbaglan.NesneVer().thisQuery.Parameters.AddWithValue("TC", tbxTC.Text);
            //Sqlbaglan.NesneVer().thisQuery.ExecuteNonQuery();
            //Sqlbaglan.NesneVer().thisConn.Close();
            try
            {
                _iManagerPanelInformationService.Add(new ManagerPanelInformation
                {
                    Id = Convert.ToInt32(tbxId.Text),
                    TC = Convert.ToInt64(tbxTC.Text),
                    Kurallar = tbxRules.Text
                });
                MessageBox.Show("Ürün eklendi!");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }



            idGetir();

        }
        public void idGetir()
        {


            dgwRules.DataSource = _iManagerPanelInformationService.GetAll();

        }


       

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //Sqlbaglan.NesneVer().thisConn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;initial catalog = ManagerPanel;integrated security = true");
            //Sqlbaglan.NesneVer().thisConn.Open();
            //Sqlbaglan.NesneVer().thisQuery = new SqlCommand("DELETE FROM [Rules] WHERE Kurallar=@Kurallar", Sqlbaglan.NesneVer().thisConn);
            //Sqlbaglan.NesneVer().thisQuery.Parameters.AddWithValue("@Kurallar", tbxRules.Text);
            //Sqlbaglan.NesneVer().thisQuery.ExecuteNonQuery();
            //Sqlbaglan.NesneVer().thisConn.Close();
            if (dgwRules.CurrentRow != null)
            {
                try
                {
                    _iManagerPanelInformationService.Delete(new ManagerPanelInformation
                    {
                        Id = Convert.ToInt32(dgwRules.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün silindi!");

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }


            idGetir();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //Sqlbaglan.NesneVer().thisConn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;initial catalog = ManagerPanel;integrated security = true");
            //Sqlbaglan.NesneVer().thisConn.Open();
            //Sqlbaglan.NesneVer().thisQuery = new SqlCommand("UPDATE Rules SET Kurallar=@Kurallar WHERE TC=@TC", Sqlbaglan.NesneVer().thisConn);
            //Sqlbaglan.NesneVer().thisQuery.Parameters.AddWithValue("@TC", tbxTC.Text );
            //Sqlbaglan.NesneVer().thisQuery.Parameters.AddWithValue("@Kurallar", tbxRules.Text);
            //Sqlbaglan.NesneVer().thisQuery.ExecuteNonQuery();
            //Sqlbaglan.NesneVer().thisConn.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("Kural güncellenemedi.");
            //}
            _iManagerPanelInformationService.Update(new ManagerPanelInformation
            {
                Id = Convert.ToInt32(tbxId.Text),
                TC = Convert.ToInt64(tbxTC.Text),
                Kurallar = tbxRules.Text
            });


            idGetir();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        static int Id;
        static long TC;
        static string Kurallar;
        public void btnPublish_Click(object sender, EventArgs e)
        {

            //Sqlbaglan.NesneVer().thisConn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;initial catalog = ManagerPanel;integrated security = true");
            //Sqlbaglan.NesneVer().thisConn.Open();
            //Sqlbaglan.NesneVer().thisQuery = new SqlCommand("SELECT Kurallar FROM [Rules] WHERE TC=@TC", Sqlbaglan.NesneVer().thisConn);
            //Sqlbaglan.NesneVer().thisQuery.Parameters.AddWithValue("@TC", tbxTC.Text);

            //label1.Text = Sqlbaglan.NesneVer().thisQuery.ExecuteScalar().ToString();
            //Sqlbaglan.NesneVer().thisConn.Close();

            
            TC = Convert.ToInt64(dgwRules.CurrentRow.Cells[1].Value);
            Kurallar =dgwRules.CurrentRow.Cells[2].Value.ToString();


            _iPublishingInformationService.Add(new PublishingInformation
            {
                Id = Id,
                TC = TC,
                Kurallar = Kurallar

            }) ;
            Kurallar kurallar = new Kurallar();
            kurallar.KuralGetir();
        }

        private void tbxSearchId_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearchId.Text))
            {
                dgwRules.DataSource = _iManagerPanelInformationService.GetManagerPanelInformationById(Convert.ToInt32(tbxSearchId.Text));
            }
            else
            {
                idGetir();
            }
        }

        private void Ayarlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            //lblRules.Text = dgwRules.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void Ayarlar_FormClosing(object sender, FormClosingEventArgs e)
        {
           // lblRules.Text = dgwRules.CurrentRow.Cells[2].Value.ToString();
            
        }
    }
}
