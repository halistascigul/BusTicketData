using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicketData.UI.WinForm
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminName.Text.ToLower()=="admin" && txtAdminPassword.Text=="123")
            {
                this.Close();
                frmAdminMainPage frm = new frmAdminMainPage();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya şifre girdiniz!");
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            txtAdminPassword.AutoSize = false;
            txtAdminPassword.Size = new Size(txtAdminName.Size.Width, txtAdminName.Size.Height);
        }
    }
}
