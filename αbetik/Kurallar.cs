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
    public partial class Kurallar : Form
    {
        Ayarlar ayarlar = new Ayarlar();
        public IPublishingInformationService _iPublishingInformationService;
        public IManagerPanelInformationService _iManagerPanelInformationService;
        
        public Kurallar()
        {
            InitializeComponent();
            _iPublishingInformationService = InstanceFactory.GetInstance<IPublishingInformationService>();
        }
        
        private void Kurallar_Load(object sender, EventArgs e)
        {

            KuralGetir();

        }
        public void Araç()
        {
            dgwPublishingRules.DataSource = _iPublishingInformationService.GetAll();
            dgwPublishingRules.Columns["Id"].Visible = false;
            dgwPublishingRules.Columns["TC"].Visible = false;
        }
        public void KuralGetir()
        {
            Araç();
            if (dgwPublishingRules.RowCount == 0)
            {
                try
                {
                    _iPublishingInformationService.Add(new PublishingInformation
                    {
                        
                        TC = 123123,
                        Kurallar = "Veritabanında yayınlanan veri olmadığı için eklenmiştir, silebilirsiniz."
                    });
                    Araç();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
           
               

            //dgwPublishingRules.DataSource = _iManagerPanelInformationService.GetPublishingInformationRulesByTC(Convert.ToInt32(ayarlar.tbxTC.Text));
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPublishing_Click(object sender, EventArgs e)
        {
                       
        }
    }
}
