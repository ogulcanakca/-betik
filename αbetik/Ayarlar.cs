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
            //idGetir();
            //dgwRules.DataSource = _iManagerPanelInformationService.GetManagerPanelInformationByTC(Convert.ToInt64(form1.tbxTC.Text));
            αbetik αbetik = new αbetik();
            var f1 = new αbetik();
            f1.ayarlar = this;
            
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
                    
                    TC = Convert.ToInt64(tbxTC.Text),
                    Kurallar = tbxRules.Text
                });
                MessageBox.Show("Kişi bilgisi eklendi!");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            if (!String.IsNullOrEmpty(tbxTCCC.Text))
            {
                dgwRules.DataSource = _iManagerPanelInformationService.GetManagerPanelInformationByTC(Convert.ToInt64(tbxTCCC.Text));

            }
            
            //this.Controls.Clear();
            //this.InitializeComponent();

            //dgwRules.DataSource = _iManagerPanelInformationService.GetManagerPanelInformationByTC(Convert.ToInt64(tbxTCCC.Text));
            //αbetik αbetik = new αbetik();
            //btnClose_Click(new object(), EventArgs.Empty);
            //this.Hide();
            //this.Controls.Clear();
            //this.InitializeComponent();
            //αbetik.btnAyarlar_Click(new object(), EventArgs.Empty);
            //tbxTCCC.Text = αbetik.tbxTCC.Text;
            //this.Show();

            //idGetir();

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
            if (radioButton1.Checked == true)
            {
                _iManagerPanelInformationService.Delete(new ManagerPanelInformation
                {   
                    TC = Convert.ToInt64(dgwRules.CurrentRow.Cells[1].Value)
                }) ;
                MessageBox.Show("Tüm kişilerin bilgileri silindi!");
            }
            else
            {
                if (dgwRules.CurrentRow != null)
                {
                    try
                    {
                        _iManagerPanelInformationService.Delete(new ManagerPanelInformation
                        {
                            Id = Convert.ToInt32(dgwRules.CurrentRow.Cells[0].Value)
                        });
                        MessageBox.Show("Kişi bilgisi silindi!");

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }

                }


                if (!String.IsNullOrEmpty(tbxTCCC.Text))
                {
                    dgwRules.DataSource = _iManagerPanelInformationService.GetManagerPanelInformationByTC(Convert.ToInt64(tbxTCCC.Text));

                }
            }

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

            MessageBox.Show("Kişi bilgisi güncellendi.");
            if (!String.IsNullOrEmpty(tbxTCCC.Text))
            {
                dgwRules.DataSource = _iManagerPanelInformationService.GetManagerPanelInformationByTC(Convert.ToInt64(tbxTCCC.Text));

            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        public int Id;
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
            MessageBox.Show("Kural yayınlandı.");
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
            e.Cancel = true;
            // lblRules.Text = dgwRules.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void tbxTCCC_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxTCCC.Text))
            {
                dgwRules.DataSource = _iManagerPanelInformationService.GetManagerPanelInformationByTC(Convert.ToInt64(tbxTCCC.Text));

            }
            else
            {
                idGetir();
            }



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
