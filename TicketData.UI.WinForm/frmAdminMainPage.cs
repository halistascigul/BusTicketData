using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TicketData.Business.TicketDataBOs;
using TicketData.Domain.Entities;

namespace TicketData.UI.WinForm
{
    public partial class frmAdminMainPage : Form
    {
        public frmAdminMainPage()
        {
            InitializeComponent();
        }
        BusBO bbo = new BusBO();

        PassengerBO pbo = new PassengerBO();
        public Bus SelectedBus { get; set; }
        public int SelectedBusId { get; set; }
        public Passenger SelectedPassenger { get; set; }
        public int SelectedPassengerId { get; set; }

        private void busAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddBus frm = new frmAddBus();
            frm.Show();
        }

        private void otobüsBilgileriniGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUpdateBus frm = new frmUpdateBus();
            frm.Show();
        }
        
        public void dgvBusesRefresh(DataGridView dgv)
        {
            dgvBuses.DataSource = null;
            dgvBuses.DataSource = bbo.GetList().OrderBy(x => x.TravelDate).ToList();
            dgv.Columns["Created"].Visible = false;
            dgv.Columns["Updated"].Visible = false;
            dgv.Columns["IsActive"].Visible = false;
            dgv.Columns["IsDeleted"].Visible = false;
            dgv.Columns["BusModel"].Visible = false;
            dgv.Columns["BusType"].Visible = false;
            dgv.Columns["SeatingCapacity"].Visible = false;
            dgv.Columns["TravelDate"].HeaderText = "Seyahat Tarihi";
            dgv.Columns["TravelTime"].HeaderText = "Saat";
            dgv.Columns["WhereFrom"].HeaderText = "Kalkış Noktası";
            dgv.Columns["WhereTo"].HeaderText = "Varış Noktası";
            dgv.EnableHeadersVisualStyles = false;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void dgvPassengersRefresh(DataGridView dgv)
        {
            dgvPassengers.DataSource = null;
            dgvPassengers.DataSource = pbo.GetPassengersInBus(SelectedBusId).OrderBy(x => x.SeatNumber).ToList();
            dgv.Columns["Created"].Visible = false;
            dgv.Columns["Updated"].Visible = false;
            dgv.Columns["IsActive"].Visible = false;
            dgv.Columns["IsDeleted"].Visible = false;
            dgv.Columns["BusId"].Visible = false;
            dgv.Columns["Bus"].Visible = false;
            dgv.Columns["FullName"].HeaderText = "Ad Soyad";
            dgv.Columns["Phone"].HeaderText = "Telefon No";
            dgv.Columns["Gender"].HeaderText = "Cinsiyet";
            dgv.Columns["SeatNumber"].HeaderText = "Koltuk No";
            dgv.Columns["FeeToPay"].HeaderText = "Ödediği Ücret";
            dgv.EnableHeadersVisualStyles = false;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmAdminMainPage_Load(object sender, EventArgs e)
        {
            dgvBusesRefresh(dgvBuses);
        }

        private void dgvBuses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedBus = dgvBuses.Rows[e.RowIndex].DataBoundItem as Bus;
                SelectedBusId = SelectedBus.Id;
                lblPassengers.Visible = true;
                dgvPassengersRefresh(dgvPassengers);
            }
        }

        private void dgvPassengers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedPassenger = dgvPassengers.Rows[e.RowIndex].DataBoundItem as Passenger;
                SelectedPassengerId = SelectedPassenger.Id;
                txtId.Text = SelectedPassenger.Id.ToString();
                txtFullName.Text = SelectedPassenger.FullName;
                txtIdentityNumber.Text = SelectedPassenger.IdentityNumber.ToString();
                txtSeatNumber.Text = SelectedPassenger.SeatNumber.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtId.Text))
            {
                Passenger passenger = new Passenger
                {
                    Id = Convert.ToInt32(txtId.Text),
                    FullName = txtFullName.Text,
                    IdentityNumber = SelectedPassenger.IdentityNumber,
                    SeatNumber = Convert.ToByte(txtSeatNumber.Text),
                    Phone = SelectedPassenger.Phone,
                    Email = SelectedPassenger.Email,
                    Gender = SelectedPassenger.Gender,
                    FeeToPay = SelectedPassenger.FeeToPay,
                    BusId = SelectedPassenger.BusId
                };
                if (pbo.Update(passenger))
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    dgvPassengersRefresh(dgvPassengers);
                }
                else
                    MessageBox.Show("Güncellemede hata var");
            }
            else
                MessageBox.Show("1-Önce yan menüden otobüsü seçiniz.\n2-Sonra alt menüden yolcuyu seçiniz");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtId.Text))
            {
                DialogResult dr = MessageBox.Show("Yolcuyu silmek istediğinizden emin misiniz?", "SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (pbo.Delete(SelectedPassengerId))
                    {
                        MessageBox.Show("Yolcu silindi");
                        dgvPassengersRefresh(dgvPassengers);
                    }
                    else
                        MessageBox.Show("Hata oluştu. Program yöneticisiyle görüşün");
                }
            }
            else
                MessageBox.Show("1-Önce yan menüden otobüsü seçiniz.\n2-Sonra alt menüden yolcuyu seçiniz");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ana menüye dönmek istediğinize emin misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
