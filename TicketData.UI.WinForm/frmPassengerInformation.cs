using System;
using System.Windows.Forms;
using TicketData.Business.TicketDataBOs;
using TicketData.Domain.Entities;

namespace TicketData.UI.WinForm
{
    public partial class frmPassengerInformation : Form
    {
        public frmPassengerInformation()
        {
            InitializeComponent();
        }

        BusBO bbo = new BusBO();

        PassengerBO pbo = new PassengerBO();

        public int selectedBusId { get; set; }

        public byte selectedSeatNumber { get; set; }

        public decimal selectedPay { get; set; }

        public frmPassengerInformation(int id, byte seatNumber, decimal pay)
        {
            InitializeComponent();
            selectedBusId = id;
            selectedSeatNumber = seatNumber;
            selectedPay = pay;
        }

        private void frmPassengerInformation_Load(object sender, EventArgs e)
        {
            var bus = bbo.Get(selectedBusId);
            lblDateTime.Text = bus.TravelDate.ToLongDateString();
            lblSeatNumber.Text = selectedSeatNumber.ToString();
            lblWhereFrom.Text = bus.WhereFrom;
            lblWhereTo.Text = bus.WhereTo;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var seatNumber = lblSeatNumber.Text;
            if (txtCheckIdentityNumber.Text == txtIdentityNumber.Text && txtCheckSeatNumber.Text == seatNumber && cbTermsOfUse.Checked && !String.IsNullOrEmpty(txtFullName.Text) && !String.IsNullOrEmpty(txtIdentityNumber.Text) && !String.IsNullOrEmpty(txtPhone.Text) && !String.IsNullOrEmpty(txtEmail.Text) &&
                !String.IsNullOrEmpty(cmbGender.Text))
            {
                Passenger passenger = new Passenger();
                passenger.FullName = txtFullName.Text;
                passenger.IdentityNumber = Convert.ToInt64(txtIdentityNumber.Text);
                passenger.Phone = txtPhone.Text;
                passenger.Email = txtEmail.Text;
                passenger.Gender = cmbGender.SelectedItem.ToString();
                passenger.FeeToPay = selectedPay;
                passenger.SeatNumber = selectedSeatNumber;
                passenger.BusId = selectedBusId;
                if (pbo.Insert(passenger))
                {
                    MessageBox.Show("Başarılı bir şekilde bilet aldınız");
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Üzgünüz!!! Tekrar deneyin");

            }
            else
                MessageBox.Show("Girmiş olduğunuz bilgilerde hata veya eksiklik var,lütfen eksiksiz bir şekilde doldurup yeniden almayı deneyin.");
        }

        private void txtIdentityNumber_Validated(object sender, EventArgs e)
        {
            if (txtIdentityNumber.Text.Length < 11)
                MessageBox.Show("TC numarası 11 haneli olmalıdır");
        }
    }
}
