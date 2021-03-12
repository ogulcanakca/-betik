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
   

    public partial class αbetik : Form
    {
        
       
        
        private IInformationService _informationService;

        public αbetik()
        {
            
            InitializeComponent();

            _informationService = InstanceFactory.GetInstance<IInformationService>();
        }
        public void LoadInformations()
        {
            dgwInformations.DataSource = _informationService.GetAll();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void αbetik_Load(object sender, EventArgs e)
        {
            LoadInformations();
           
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _informationService.Add(new ELibraryInformation
                {
                    Id = Convert.ToInt32(tbxId.Text),
                    Ad = tbxAd.Text,
                    Soyad = tbxSoyAd.Text,
                    Telno = Convert.ToInt32(tbxTelno.Text),
                    Kitapadi = tbxKitapAdi.Text,
                    Kitapturu = tbxKitapTuru.Text,
                    Kitapyazari = tbxKitapYazari.Text,
                    Kitapsayfasayisi = Convert.ToInt32(tbxKitapSayfaSayisi.Text)
                });
                MessageBox.Show("Ürün eklendi!");
                LoadInformations();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (dgwInformations.CurrentRow != null)
            {
                try
                {
                    _informationService.Delete(new ELibraryInformation
                    {
                        Id = Convert.ToInt32(dgwInformations.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün silindi!");
                    LoadInformations();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }
        private void tbxAd_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxAd.Text))
            {
                dgwInformations.DataSource = _informationService.GetELibraryInformationByELibraryInformationsName(tbxAd.Text);
            }
            else
            {
                LoadInformations();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _informationService.Update(new ELibraryInformation
            {
                Id = Convert.ToInt32(tbxId.Text),
                Ad = tbxAd.Text,
                Soyad = tbxSoyAd.Text,
                Telno = Convert.ToInt32(tbxTelno.Text),
                Kitapadi = tbxKitapAdi.Text,
                Kitapturu = tbxKitapTuru.Text,
                Kitapyazari = tbxKitapYazari.Text,
                Kitapsayfasayisi = Convert.ToInt32(tbxKitapSayfaSayisi.Text)
            });
            MessageBox.Show("Ürün güncellendi!");
            LoadInformations();
        }

        private void dgwInformations_Click(object sender, EventArgs e)
        {

        }

        private void dgwInformations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dgwInformations.CurrentRow.Cells[0].Value.ToString();
            tbxAd.Text = dgwInformations.CurrentRow.Cells[1].Value.ToString();
            tbxSoyAd.Text = dgwInformations.CurrentRow.Cells[2].Value.ToString();
            tbxTelno.Text = dgwInformations.CurrentRow.Cells[3].Value.ToString();
            tbxKitapAdi.Text = dgwInformations.CurrentRow.Cells[4].Value.ToString();
            tbxKitapTuru.Text = dgwInformations.CurrentRow.Cells[5].Value.ToString();
            tbxKitapYazari.Text = dgwInformations.CurrentRow.Cells[6].Value.ToString();
            tbxKitapSayfaSayisi.Text = dgwInformations.CurrentRow.Cells[7].Value.ToString();
        }

        

        private void btnHowManyPeople_Click(object sender, EventArgs e)
        {

            //Sqlbaglan.NesneVer().thisConn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;initial catalog = ManagerPanel;integrated security = true");
            //Sqlbaglan.NesneVer().thisConn.Open();
            //Sqlbaglan.NesneVer().thisQuery = new SqlCommand("SELECT COUNT(Id) FROM ELibraryInformations", Sqlbaglan.NesneVer().thisConn);
            //Sqlbaglan.NesneVer().thisQuery.Parameters.AddWithValue("@Id", lblHowManyPeople.Text);
            //lblHowManyPeople.Text = Sqlbaglan.NesneVer().thisQuery.ExecuteScalar().ToString();
            //Sqlbaglan.NesneVer().thisConn.Close();
            lblHowManyPeople.Text = _informationService.GetAll().Count.ToString(); // ben yabdım.
            

        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Ayarlar"] == null)
            {
                Ayarlar ayarlar = new Ayarlar();
                ayarlar.Show();
            }
        }

        private void btnKurallar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Kurallar"] == null)
            {
                Kurallar kurallar = new Kurallar();
                kurallar.Show();
            }
        }
    }
}
