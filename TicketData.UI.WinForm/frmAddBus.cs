using System;
using System.Drawing;
using System.Windows.Forms;
using TicketData.Business.TicketDataBOs;
using TicketData.Domain.Entities;

namespace TicketData.UI.WinForm
{
    public partial class frmAddBus : Form
    {
        public frmAddBus()
        {
            InitializeComponent();
        }
        public State SelectedState { get; set; }

        public int SelectedStateId { get; set; }

        BusBO bbo = new BusBO();

        ProvinceBO pbo = new ProvinceBO();

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbBusModel.Text) && !String.IsNullOrEmpty(cmbBusType.Text) && !String.IsNullOrEmpty(cmbSeatingCapacity.Text))
            {
                Bus bus = new Bus();
                bus.BusModel = cmbBusModel.Text;
                bus.SeatingCapacity = Convert.ToByte(cmbSeatingCapacity.Text);
                bus.BusType = cmbBusType.Text;
                //ilk otobüs eklenirken standart
                bus.TravelDate = new DateTime(2000, 01, 01);
                bus.TravelTime = "00:00";
                bus.WhereFrom = "Dünya";
                bus.WhereTo = "Mars";
                if (bbo.Insert(bus))
                {
                    MessageBox.Show("Ekleme başarılı");
                    this.Close();
                    frmUpdateBus frm = new frmUpdateBus();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Ekleme başarısız");
                }
            }
            else
                MessageBox.Show("Bütün alanları doldurmak zorundasınız");
        }

        private void btnAddState_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtState.Text))
            {
                State state = new State
                {
                    Province = txtState.Text
                };
                if (pbo.Insert(state))
                {
                    MessageBox.Show("İl/ilçe ekleme başarılı");
                    dgvRefresh(dgvStates);
                }
                else
                    MessageBox.Show("Ekleme sırasında hata oluştu");
            }
            else
                MessageBox.Show("İl/ilçe alanını boş geçemezsiniz!!!");
        }

        public void dgvRefresh(DataGridView dgv)
        {
            dgvStates.DataSource = null;
            dgvStates.DataSource = pbo.GetList();
            dgv.Columns["Created"].Visible = false;
            dgv.Columns["Updated"].Visible = false;
            dgv.Columns["IsActive"].Visible = false;
            dgv.Columns["IsDeleted"].Visible = false;
            dgv.Columns["Province"].HeaderText = "İl/İlçe";
            dgv.EnableHeadersVisualStyles = false;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmAddBus_Load(object sender, EventArgs e)
        {
            dgvRefresh(dgvStates);
        }

        private void dgvStates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedState = dgvStates.Rows[e.RowIndex].DataBoundItem as State;
                SelectedStateId = SelectedState.Id;
                txtState.Text = SelectedState.Province;
            }
        }

        private void btnUpdateState_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtState.Text))
            {
                State state = new State
                {
                    Province = txtState.Text,
                    Id = SelectedStateId
                };
                if (pbo.Update(state))
                {
                    MessageBox.Show("Güncelleme başarılı");
                    dgvRefresh(dgvStates);
                }
                else
                    MessageBox.Show("Güncelleme sırasında hata oluştu");
            }
            else
                MessageBox.Show("Yan taraftan seçim yapınız");

        }

        private void busAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yönetici Anasayfasına dönmek istediğinize emin misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                frmAdminMainPage frm = new frmAdminMainPage();
                frm.Show();
            }
        }
    }
}
