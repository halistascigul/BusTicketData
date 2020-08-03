namespace TicketData.UI.WinForm
{
    partial class frmUpdateBus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpTravelDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTravelTime = new System.Windows.Forms.ComboBox();
            this.cmbWhereTo = new System.Windows.Forms.ComboBox();
            this.cmbWhereFrom = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.busAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBuses = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpTravelDate);
            this.panel1.Controls.Add(this.cmbTravelTime);
            this.panel1.Controls.Add(this.cmbWhereTo);
            this.panel1.Controls.Add(this.cmbWhereFrom);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 298);
            this.panel1.TabIndex = 0;
            // 
            // dtpTravelDate
            // 
            this.dtpTravelDate.Location = new System.Drawing.Point(89, 153);
            this.dtpTravelDate.Name = "dtpTravelDate";
            this.dtpTravelDate.Size = new System.Drawing.Size(154, 20);
            this.dtpTravelDate.TabIndex = 3;
            // 
            // cmbTravelTime
            // 
            this.cmbTravelTime.FormattingEnabled = true;
            this.cmbTravelTime.Items.AddRange(new object[] {
            "00:30",
            "05:30",
            "12:00",
            "14:30",
            "17:00",
            "19:30",
            "22:00"});
            this.cmbTravelTime.Location = new System.Drawing.Point(89, 178);
            this.cmbTravelTime.Name = "cmbTravelTime";
            this.cmbTravelTime.Size = new System.Drawing.Size(154, 21);
            this.cmbTravelTime.TabIndex = 4;
            // 
            // cmbWhereTo
            // 
            this.cmbWhereTo.FormattingEnabled = true;
            this.cmbWhereTo.Location = new System.Drawing.Point(89, 127);
            this.cmbWhereTo.Name = "cmbWhereTo";
            this.cmbWhereTo.Size = new System.Drawing.Size(154, 21);
            this.cmbWhereTo.TabIndex = 2;
            // 
            // cmbWhereFrom
            // 
            this.cmbWhereFrom.FormattingEnabled = true;
            this.cmbWhereFrom.Location = new System.Drawing.Point(89, 97);
            this.cmbWhereFrom.Name = "cmbWhereFrom";
            this.cmbWhereFrom.Size = new System.Drawing.Size(154, 21);
            this.cmbWhereFrom.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busAddToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 42;
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.exitToolStripMenuItem.Text = "Ana Menüye Dön";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(89, 215);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 37);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Saat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seyahat Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nereden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nereye";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(89, 69);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(154, 20);
            this.txtId.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(113, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Otobüs Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // dgvBuses
            // 
            this.dgvBuses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuses.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvBuses.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBuses.Location = new System.Drawing.Point(308, 0);
            this.dgvBuses.Name = "dgvBuses";
            this.dgvBuses.ReadOnly = true;
            this.dgvBuses.Size = new System.Drawing.Size(492, 298);
            this.dgvBuses.TabIndex = 1;
            this.dgvBuses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuses_CellClick);
            // 
            // frmUpdateBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.dgvBuses);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateBus";
            this.Text = "Seyahat Bilgilerini Güncelle";
            this.Load += new System.EventHandler(this.frmAdminPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvBuses;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem busAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpTravelDate;
        private System.Windows.Forms.ComboBox cmbTravelTime;
        private System.Windows.Forms.ComboBox cmbWhereTo;
        private System.Windows.Forms.ComboBox cmbWhereFrom;
    }
}