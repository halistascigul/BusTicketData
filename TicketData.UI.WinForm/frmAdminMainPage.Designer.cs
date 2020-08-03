namespace TicketData.UI.WinForm
{
    partial class frmAdminMainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.busAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otobüsBilgileriniGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentityNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvPassengers = new System.Windows.Forms.DataGridView();
            this.lblPassengers = new System.Windows.Forms.Label();
            this.dgvBuses = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(74, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 100;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 129);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 44);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Koltuk Numarasını Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busAddToolStripMenuItem,
            this.otobüsBilgileriniGüncelleToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // busAddToolStripMenuItem
            // 
            this.busAddToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.busAddToolStripMenuItem.Name = "busAddToolStripMenuItem";
            this.busAddToolStripMenuItem.Size = new System.Drawing.Size(193, 20);
            this.busAddToolStripMenuItem.Text = "Yeni Otobüs/Yeni Güzergah Ekle";
            this.busAddToolStripMenuItem.Click += new System.EventHandler(this.busAddToolStripMenuItem_Click);
            // 
            // otobüsBilgileriniGüncelleToolStripMenuItem
            // 
            this.otobüsBilgileriniGüncelleToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.otobüsBilgileriniGüncelleToolStripMenuItem.Name = "otobüsBilgileriniGüncelleToolStripMenuItem";
            this.otobüsBilgileriniGüncelleToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.otobüsBilgileriniGüncelleToolStripMenuItem.Text = "Otobüs Bilgilerini Güncelle";
            this.otobüsBilgileriniGüncelleToolStripMenuItem.Click += new System.EventHandler(this.otobüsBilgileriniGüncelleToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.exitToolStripMenuItem.Text = "Ana Menüye Dön";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Ad Soyad";
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.Location = new System.Drawing.Point(74, 39);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 100;
            this.label3.Text = "TC No";
            // 
            // txtIdentityNumber
            // 
            this.txtIdentityNumber.Enabled = false;
            this.txtIdentityNumber.Location = new System.Drawing.Point(74, 65);
            this.txtIdentityNumber.Name = "txtIdentityNumber";
            this.txtIdentityNumber.Size = new System.Drawing.Size(100, 20);
            this.txtIdentityNumber.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Koltuk No";
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.Location = new System.Drawing.Point(74, 91);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSeatNumber.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIdentityNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtSeatNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 190);
            this.panel1.TabIndex = 101;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(152, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 43);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Yolcuyu Çıkar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvPassengers
            // 
            this.dgvPassengers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengers.Location = new System.Drawing.Point(0, 302);
            this.dgvPassengers.Name = "dgvPassengers";
            this.dgvPassengers.Size = new System.Drawing.Size(702, 206);
            this.dgvPassengers.TabIndex = 102;
            this.dgvPassengers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPassengers_CellClick);
            // 
            // lblPassengers
            // 
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassengers.Location = new System.Drawing.Point(258, 278);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.Size = new System.Drawing.Size(204, 16);
            this.lblPassengers.TabIndex = 100;
            this.lblPassengers.Text = "Otobüsteki Yolcuların Listesi";
            this.lblPassengers.Visible = false;
            // 
            // dgvBuses
            // 
            this.dgvBuses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuses.Location = new System.Drawing.Point(284, 48);
            this.dgvBuses.Name = "dgvBuses";
            this.dgvBuses.Size = new System.Drawing.Size(418, 190);
            this.dgvBuses.TabIndex = 0;
            this.dgvBuses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuses_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(451, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 100;
            this.label5.Text = "Otobüs Listesi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(144, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 103;
            this.label6.Text = "Yolcu Bilgisi";
            // 
            // frmAdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 509);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPassengers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvBuses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPassengers);
            this.Name = "frmAdminMainPage";
            this.Text = "Yönetici Ana Sayfa/Yolcu Görüntüleme";
            this.Load += new System.EventHandler(this.frmAdminMainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem busAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otobüsBilgileriniGüncelleToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentityNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvPassengers;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.DataGridView dgvBuses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}