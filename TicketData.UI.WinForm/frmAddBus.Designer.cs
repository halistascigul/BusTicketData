namespace TicketData.UI.WinForm
{
    partial class frmAddBus
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
            this.cmbBusModel = new System.Windows.Forms.ComboBox();
            this.cmbBusType = new System.Windows.Forms.ComboBox();
            this.cmbSeatingCapacity = new System.Windows.Forms.ComboBox();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvStates = new System.Windows.Forms.DataGridView();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnUpdateState = new System.Windows.Forms.Button();
            this.btnAddState = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.busAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStates)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbBusModel);
            this.panel1.Controls.Add(this.cmbBusType);
            this.panel1.Controls.Add(this.cmbSeatingCapacity);
            this.panel1.Controls.Add(this.btnAddBus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 257);
            this.panel1.TabIndex = 5;
            // 
            // cmbBusModel
            // 
            this.cmbBusModel.FormattingEnabled = true;
            this.cmbBusModel.Items.AddRange(new object[] {
            "MAN",
            "MERCEDES",
            "SAFARİ",
            "SETRA"});
            this.cmbBusModel.Location = new System.Drawing.Point(133, 46);
            this.cmbBusModel.Name = "cmbBusModel";
            this.cmbBusModel.Size = new System.Drawing.Size(135, 21);
            this.cmbBusModel.TabIndex = 9;
            // 
            // cmbBusType
            // 
            this.cmbBusType.FormattingEnabled = true;
            this.cmbBusType.Items.AddRange(new object[] {
            "2+1",
            "2+2"});
            this.cmbBusType.Location = new System.Drawing.Point(133, 102);
            this.cmbBusType.Name = "cmbBusType";
            this.cmbBusType.Size = new System.Drawing.Size(135, 21);
            this.cmbBusType.TabIndex = 11;
            // 
            // cmbSeatingCapacity
            // 
            this.cmbSeatingCapacity.FormattingEnabled = true;
            this.cmbSeatingCapacity.Items.AddRange(new object[] {
            "25",
            "27",
            "29"});
            this.cmbSeatingCapacity.Location = new System.Drawing.Point(133, 74);
            this.cmbSeatingCapacity.Name = "cmbSeatingCapacity";
            this.cmbSeatingCapacity.Size = new System.Drawing.Size(135, 21);
            this.cmbSeatingCapacity.TabIndex = 10;
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(133, 136);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(135, 49);
            this.btnAddBus.TabIndex = 12;
            this.btnAddBus.Text = "Kaydet";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Koltuk Kapasitesi: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yeni Otobüsün; ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modeli: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvStates);
            this.panel2.Controls.Add(this.txtState);
            this.panel2.Controls.Add(this.btnUpdateState);
            this.panel2.Controls.Add(this.btnAddState);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(341, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 257);
            this.panel2.TabIndex = 13;
            // 
            // dgvStates
            // 
            this.dgvStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStates.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvStates.Location = new System.Drawing.Point(184, 0);
            this.dgvStates.Name = "dgvStates";
            this.dgvStates.Size = new System.Drawing.Size(140, 257);
            this.dgvStates.TabIndex = 9;
            this.dgvStates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStates_CellClick);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(39, 33);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(135, 20);
            this.txtState.TabIndex = 5;
            // 
            // btnUpdateState
            // 
            this.btnUpdateState.Location = new System.Drawing.Point(39, 136);
            this.btnUpdateState.Name = "btnUpdateState";
            this.btnUpdateState.Size = new System.Drawing.Size(135, 49);
            this.btnUpdateState.TabIndex = 7;
            this.btnUpdateState.Text = "Güncelle";
            this.btnUpdateState.UseVisualStyleBackColor = true;
            this.btnUpdateState.Click += new System.EventHandler(this.btnUpdateState_Click);
            // 
            // btnAddState
            // 
            this.btnAddState.Location = new System.Drawing.Point(39, 74);
            this.btnAddState.Name = "btnAddState";
            this.btnAddState.Size = new System.Drawing.Size(135, 49);
            this.btnAddState.TabIndex = 6;
            this.btnAddState.Text = "Kaydet";
            this.btnAddState.UseVisualStyleBackColor = true;
            this.btnAddState.Click += new System.EventHandler(this.btnAddState_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(4, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Yeni Güzergah; ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "İl/İlçe";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busAddToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // busAddToolStripMenuItem
            // 
            this.busAddToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.busAddToolStripMenuItem.Name = "busAddToolStripMenuItem";
            this.busAddToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.busAddToolStripMenuItem.Text = "Ana Menüye Dön";
            this.busAddToolStripMenuItem.Click += new System.EventHandler(this.busAddToolStripMenuItem_Click);
            // 
            // frmAddBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 287);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddBus";
            this.Text = "Yeni Otobüs Ekle/Güzergah Ekle";
            this.Load += new System.EventHandler(this.frmAddBus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStates)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbBusModel;
        private System.Windows.Forms.ComboBox cmbBusType;
        private System.Windows.Forms.ComboBox cmbSeatingCapacity;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.DataGridView dgvStates;
        private System.Windows.Forms.Button btnUpdateState;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem busAddToolStripMenuItem;
    }
}