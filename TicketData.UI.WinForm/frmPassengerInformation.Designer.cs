namespace TicketData.UI.WinForm
{
    partial class frmPassengerInformation
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
            this.btnPay = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblSeatNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblWhereFrom = new System.Windows.Forms.Label();
            this.lblWhereTo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIdentityNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCheckIdentityNumber = new System.Windows.Forms.TextBox();
            this.txtCheckSeatNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTermsOfUse = new System.Windows.Forms.CheckBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cep Telefonu";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(536, 191);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(162, 41);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "Ödeme Yap";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(50, 212);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(162, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(448, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------------------------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Seyahat Bilgileri";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Red;
            this.lblDateTime.Location = new System.Drawing.Point(12, 42);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(112, 15);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "Seyahat Bilgileri";
            // 
            // lblSeatNumber
            // 
            this.lblSeatNumber.AutoSize = true;
            this.lblSeatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeatNumber.Location = new System.Drawing.Point(130, 66);
            this.lblSeatNumber.Name = "lblSeatNumber";
            this.lblSeatNumber.Size = new System.Drawing.Size(23, 15);
            this.lblSeatNumber.TabIndex = 1;
            this.lblSeatNumber.Text = "No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(219, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kalkış";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(310, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Varış";
            // 
            // lblWhereFrom
            // 
            this.lblWhereFrom.AutoSize = true;
            this.lblWhereFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWhereFrom.Location = new System.Drawing.Point(219, 65);
            this.lblWhereFrom.Name = "lblWhereFrom";
            this.lblWhereFrom.Size = new System.Drawing.Size(40, 15);
            this.lblWhereFrom.TabIndex = 1;
            this.lblWhereFrom.Text = "Kalkış";
            // 
            // lblWhereTo
            // 
            this.lblWhereTo.AutoSize = true;
            this.lblWhereTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWhereTo.Location = new System.Drawing.Point(310, 65);
            this.lblWhereTo.Name = "lblWhereTo";
            this.lblWhereTo.Size = new System.Drawing.Size(34, 15);
            this.lblWhereTo.TabIndex = 1;
            this.lblWhereTo.Text = "Varış";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Yolcu Bilgileri";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(247, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtIdentityNumber
            // 
            this.txtIdentityNumber.Location = new System.Drawing.Point(247, 212);
            this.txtIdentityNumber.MaxLength = 11;
            this.txtIdentityNumber.Name = "txtIdentityNumber";
            this.txtIdentityNumber.Size = new System.Drawing.Size(162, 20);
            this.txtIdentityNumber.TabIndex = 4;
            this.txtIdentityNumber.Validated += new System.EventHandler(this.txtIdentityNumber_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "TC No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(539, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Güvenli Ödeme Bilgileri";
            // 
            // txtCheckIdentityNumber
            // 
            this.txtCheckIdentityNumber.Location = new System.Drawing.Point(535, 82);
            this.txtCheckIdentityNumber.Name = "txtCheckIdentityNumber";
            this.txtCheckIdentityNumber.Size = new System.Drawing.Size(162, 20);
            this.txtCheckIdentityNumber.TabIndex = 6;
            // 
            // txtCheckSeatNumber
            // 
            this.txtCheckSeatNumber.Location = new System.Drawing.Point(535, 135);
            this.txtCheckSeatNumber.Name = "txtCheckSeatNumber";
            this.txtCheckSeatNumber.Size = new System.Drawing.Size(162, 20);
            this.txtCheckSeatNumber.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(534, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Yolcu TC No (Kartın Üzerindeki İsim)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(533, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Koltuk No (Kart Numarası)";
            // 
            // cbTermsOfUse
            // 
            this.cbTermsOfUse.AutoSize = true;
            this.cbTermsOfUse.Location = new System.Drawing.Point(536, 250);
            this.cbTermsOfUse.Name = "cbTermsOfUse";
            this.cbTermsOfUse.Size = new System.Drawing.Size(238, 17);
            this.cbTermsOfUse.TabIndex = 8;
            this.cbTermsOfUse.Text = "Kullanım Koşulları’nı, okudum ve onaylıyorum.";
            this.cbTermsOfUse.UseVisualStyleBackColor = true;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbGender.Location = new System.Drawing.Point(50, 265);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(162, 21);
            this.cmbGender.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Cinsiyet";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(16, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Seçtiğiniz Koltuklar: ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(50, 162);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(162, 20);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // frmPassengerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 341);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.cbTermsOfUse);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblWhereTo);
            this.Controls.Add(this.lblWhereFrom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblSeatNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentityNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtCheckSeatNumber);
            this.Controls.Add(this.txtCheckIdentityNumber);
            this.Controls.Add(this.txtEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPassengerInformation";
            this.Text = "Yolcu/Ödeme Bilgileri";
            this.Load += new System.EventHandler(this.frmPassengerInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblSeatNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblWhereFrom;
        private System.Windows.Forms.Label lblWhereTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIdentityNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCheckIdentityNumber;
        private System.Windows.Forms.TextBox txtCheckSeatNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbTermsOfUse;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtPhone;
    }
}