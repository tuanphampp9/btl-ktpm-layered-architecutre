
namespace BTL_QLNhaTro
{
    partial class frmThemKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemKH));
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lbDOB = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.pictureBoxSignUp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignUp)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(503, 212);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(39, 17);
            this.rdoFemale.TabIndex = 28;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(403, 246);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(138, 20);
            this.dtpDOB.TabIndex = 41;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(401, 214);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(47, 17);
            this.rdoMale.TabIndex = 27;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Location = new System.Drawing.Point(259, 246);
            this.lbDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(54, 13);
            this.lbDOB.TabIndex = 40;
            this.lbDOB.Text = "Ngày sinh";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(260, 214);
            this.lbGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(47, 13);
            this.lbGender.TabIndex = 39;
            this.lbGender.Text = "Giới tính";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(259, 180);
            this.lbFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(54, 13);
            this.lbFullName.TabIndex = 38;
            this.lbFullName.Text = "Họ và tên";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(401, 180);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(138, 20);
            this.txtFullName.TabIndex = 29;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(364, 321);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 23);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(401, 274);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(138, 20);
            this.txtUsername.TabIndex = 32;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(260, 273);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(139, 13);
            this.lbUsername.TabIndex = 31;
            this.lbUsername.Text = "Tên đăng nhập(Email/SĐT)";
            // 
            // pictureBoxSignUp
            // 
            this.pictureBoxSignUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSignUp.Image")));
            this.pictureBoxSignUp.Location = new System.Drawing.Point(302, 46);
            this.pictureBoxSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSignUp.Name = "pictureBoxSignUp";
            this.pictureBoxSignUp.Size = new System.Drawing.Size(197, 109);
            this.pictureBoxSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSignUp.TabIndex = 30;
            this.pictureBoxSignUp.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.lbDOB);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.pictureBoxSignUp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.PictureBox pictureBoxSignUp;
    }
}