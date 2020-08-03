using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TicketData.Business.TicketDataBOs;
using TicketData.Domain.Entities;

namespace TicketData.UI.WinForm
{
    public partial class frmUpdateBus : Form
    {
        public frmUpdateBus()
        {
            InitializeComponent();
        }

        BusBO bbo = new BusBO();

        ProvinceBO pbo = new ProvinceBO();

        public Bus SelectedBus { get; set; }

        public void dgvRefresh(DataGridView dgv)
        {
            dgvBuses.DataSource = null;
            dgvBuses.DataSource = bbo.GetList().OrderBy(x => x.TravelDate).ToList();
            dgv.Columns["Created"].Visible = false;
            dgv.Columns["IsDeleted"].Visible = false;
            dgv.Columns["IsActive"].Visible = false;
            dgv.Columns["Updated"].Visible = false;
            dgv.Columns["SeatingCapacity"].Visible = false;
            dgv.Columns["BusType"].Visible = false;
            dgv.Columns["BusModel"].HeaderText = "Model";
            dgv.Columns["TravelDate"].HeaderText = "Seyahat Tarihi";
            dgv.Columns["TravelTime"].HeaderText = "Saat";
            dgv.Columns["WhereFrom"].HeaderText = "Kalkış Noktası";
            dgv.Columns["WhereTo"].HeaderText = "Varış Noktası";
            dgv.EnableHeadersVisualStyles = false;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmAdminPage_Load(object sender, EventArgs e)
        {
            dgvRefresh(dgvBuses);
            var buses = bbo.GetList();
            foreach (var item in buses)
            {
                if (item.TravelDate == DateTime.Today.AddDays(1))
                    MessageBox.Show("Kalkış noktası: " + item.WhereFrom + ", " + "varış noktası: " + item.WhereTo + " olan otobüsün seyahat bilgilerini güncelle");
            }
            var states = pbo.GetList();
            cmbWhereFrom.Items.Clear();
            cmbWhereTo.Items.Clear();
            foreach (var item in states)
            {
                cmbWhereFrom.Items.Add(item.Province);
                cmbWhereTo.Items.Add(item.Province);
            }

        }

        private void dgvBuses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedBus = dgvBuses.Rows[e.RowIndex].DataBoundItem as Bus;
                txtId.Text = SelectedBus.Id.ToString();
                cmbWhereFrom.Text = SelectedBus.WhereFrom;
                cmbWhereTo.Text = SelectedBus.WhereTo;
                dtpTravelDate.Text = SelectedBus.TravelDate.ToString();
                cmbTravelTime.Text = SelectedBus.TravelTime;
            }
        }

        private void busAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddBus frm = new frmAddBus();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yönetici Anasayfasına dönmek istediğinize emin misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                frmAdminMainPage frm = new frmAdminMainPage();
                frm.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtId.Text) && !String.IsNullOrEmpty(cmbWhereFrom.Text) && !String.IsNullOrEmpty(cmbWhereTo.Text) && !String.IsNullOrEmpty(cmbTravelTime.Text))
            {
                Bus bus = new Bus
                {
                    Id = SelectedBus.Id,
                    WhereFrom = cmbWhereFrom.Text,
                    WhereTo = cmbWhereTo.Text,
                    TravelDate = dtpTravelDate.Value,
                    TravelTime = cmbTravelTime.Text,
                };
                if (bbo.Update(bus))
                {
                    MessageBox.Show("Başarıyla güncellendi.");
                    dgvRefresh(dgvBuses);
                }
                else
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu");
            }
            else
                MessageBox.Show("1-Öncelikle yan menüden otobüs seçiniz.\n2-Yukarıdaki alanları boş geçmeyiniz");

        }
    }
}
