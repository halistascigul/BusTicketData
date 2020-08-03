using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TicketData.Business.TicketDataBOs;

namespace TicketData.UI.WinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(int selectedBusId, byte seatNumber, decimal pay)
        {
            InitializeComponent();
            frmPassengerInformation frm = new frmPassengerInformation(SelectedBusId, seatNumber, pay);
        }

        BusBO bbo = new BusBO();

        ProvinceBO pbo = new ProvinceBO();

        PassengerBO pasBO = new PassengerBO();

        public int SelectedBusId { get; set; }

        public byte SeatNumber { get; set; }

        public decimal Pay { get; set; }


        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbWhereFrom.Text) && String.IsNullOrEmpty(cmbWhereTo.Text))
            {
                MessageBox.Show("Kalkış noktası ile varış noktası boş bırakılamaz");
            }
            else
            {
                pnlTimeSeat.Visible = true;
            }

            lblWhereFrom.Text = cmbWhereFrom.Text;
            lblWhereTo.Text = cmbWhereTo.Text;
            string travelDate = dtpTravelDate.Value.ToString();
            lblTravelDate.Text = travelDate.Substring(0, 10);
            cmbTravelTime.Items.Clear();
            var times = bbo.GetListByDate(lblWhereFrom.Text, lblWhereTo.Text, Convert.ToDateTime(lblTravelDate.Text));
            foreach (var item in times)
            {
                SelectedBusId = item.Id;
                string time = item.TravelTime.ToString();
                time = time.Substring(0, 5);
                cmbTravelTime.Items.Add(time);
            }
        }

        private void adminGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminLogin frm = new frmAdminLogin();
            frm.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            pasBO.EndOfTravel(SelectedBusId); //Yolculuk tarihi bitiminde yolcuların silinmesi için

            pnlBus.Visible = true;
            List<Button> seats = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20, btn21, btn22, btn23, btn24, btn25 };
            var passengers = pasBO.GetListInBus(SelectedBusId);
            foreach (var passenger in passengers)
            {
                foreach (var seat in seats)
                {
                    if (seat.Text == passenger.SeatNumber.ToString())
                    {
                        if (passenger.Gender == "Erkek")
                        {
                            seat.BackColor = Color.Red;
                        }
                        else
                        {
                            seat.BackColor = Color.PaleTurquoise;
                        }
                        seat.Enabled = false;
                    }
                }
            }
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutUs about = new frmAboutUs();
            about.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbWhereFrom.Items.Clear();
            cmbWhereTo.Items.Clear();
            var list = pbo.GetList().OrderBy(x => x.Province).ToList();
            foreach (var item in list)
            {
                cmbWhereFrom.Items.Add(item.Province);
                cmbWhereTo.Items.Add(item.Province);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtSeatNumber.Text = ((Button)sender).Text;
            SeatNumber = Convert.ToByte(txtSeatNumber.Text);
            lblPay.Text = 100.ToString() + " TL";
            Pay = Convert.ToDecimal(lblPay.Text.Substring(0, 3));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSeatNumber.Text))
            {
                frmPassengerInformation frm = new frmPassengerInformation(SelectedBusId, SeatNumber, Pay);
                frm.Show();
            }
            else
                MessageBox.Show("Koltuk seçmediniz!!");
        }

        private void dtpTravelDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTravelDate.Value < DateTime.Today)
            {
                btnQuery.Enabled = false;
                MessageBox.Show("Geçmiş tarih seçemezsiniz");
            }
            else
            {
                btnQuery.Enabled = true;
            }

        }
    }
}
