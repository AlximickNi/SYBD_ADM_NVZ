
namespace SYBD_ADM_NVZ.Forms
{
    partial class FormAuthorization
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
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TbxLogin = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxRoles = new System.Windows.Forms.ComboBox();
            this.LblPin = new System.Windows.Forms.Label();
            this.TbxPinCode = new System.Windows.Forms.TextBox();
            this.PnlPinCode = new System.Windows.Forms.Panel();
            this.PbxPincode = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPincode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxPassword
            // 
            this.TbxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TbxPassword.ForeColor = System.Drawing.Color.Black;
            this.TbxPassword.Location = new System.Drawing.Point(294, 227);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(304, 26);
            this.TbxPassword.TabIndex = 3;
            this.TbxPassword.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(294, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 1);
            this.panel3.TabIndex = 9;
            // 
            // TbxLogin
            // 
            this.TbxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbxLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TbxLogin.ForeColor = System.Drawing.Color.Black;
            this.TbxLogin.Location = new System.Drawing.Point(294, 158);
            this.TbxLogin.Name = "TbxLogin";
            this.TbxLogin.Size = new System.Drawing.Size(304, 26);
            this.TbxLogin.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(294, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 1);
            this.panel2.TabIndex = 7;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEnter.BackColor = System.Drawing.Color.Silver;
            this.BtnEnter.FlatAppearance.BorderSize = 0;
            this.BtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEnter.ForeColor = System.Drawing.Color.White;
            this.BtnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEnter.Location = new System.Drawing.Point(456, 261);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(152, 57);
            this.BtnEnter.TabIndex = 5;
            this.BtnEnter.Text = "Войти";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(219, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(206, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(230, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Роль:";
            // 
            // CbxRoles
            // 
            this.CbxRoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxRoles.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.CbxRoles.FormattingEnabled = true;
            this.CbxRoles.Items.AddRange(new object[] {
            "Выберите должность:",
            "Секретарь",
            "Специалист по кадрам",
            "Системный администратор"});
            this.CbxRoles.Location = new System.Drawing.Point(294, 82);
            this.CbxRoles.Name = "CbxRoles";
            this.CbxRoles.Size = new System.Drawing.Size(304, 33);
            this.CbxRoles.TabIndex = 1;
            this.CbxRoles.SelectedIndexChanged += new System.EventHandler(this.CbxRoles_SelectedIndexChanged);
            // 
            // LblPin
            // 
            this.LblPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPin.AutoSize = true;
            this.LblPin.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.LblPin.ForeColor = System.Drawing.Color.Gray;
            this.LblPin.Location = new System.Drawing.Point(198, 288);
            this.LblPin.Name = "LblPin";
            this.LblPin.Size = new System.Drawing.Size(90, 25);
            this.LblPin.TabIndex = 19;
            this.LblPin.Text = "Пин-код:";
            this.LblPin.Visible = false;
            // 
            // TbxPinCode
            // 
            this.TbxPinCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbxPinCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxPinCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxPinCode.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TbxPinCode.ForeColor = System.Drawing.Color.Black;
            this.TbxPinCode.Location = new System.Drawing.Point(294, 287);
            this.TbxPinCode.Name = "TbxPinCode";
            this.TbxPinCode.Size = new System.Drawing.Size(144, 26);
            this.TbxPinCode.TabIndex = 4;
            this.TbxPinCode.UseSystemPasswordChar = true;
            this.TbxPinCode.Visible = false;
            // 
            // PnlPinCode
            // 
            this.PnlPinCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlPinCode.BackColor = System.Drawing.Color.Black;
            this.PnlPinCode.Location = new System.Drawing.Point(294, 315);
            this.PnlPinCode.Name = "PnlPinCode";
            this.PnlPinCode.Size = new System.Drawing.Size(144, 1);
            this.PnlPinCode.TabIndex = 20;
            this.PnlPinCode.Visible = false;
            // 
            // PbxPincode
            // 
            this.PbxPincode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PbxPincode.Image = global::SYBD_ADM_NVZ.Properties.Resources.password;
            this.PbxPincode.Location = new System.Drawing.Point(131, 277);
            this.PbxPincode.Name = "PbxPincode";
            this.PbxPincode.Size = new System.Drawing.Size(61, 39);
            this.PbxPincode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxPincode.TabIndex = 22;
            this.PbxPincode.TabStop = false;
            this.PbxPincode.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::SYBD_ADM_NVZ.Properties.Resources.premium_icon_office_worker_3502880;
            this.pictureBox3.Location = new System.Drawing.Point(131, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::SYBD_ADM_NVZ.Properties.Resources.icons8_восстановить_пароль_50;
            this.pictureBox2.Location = new System.Drawing.Point(131, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SYBD_ADM_NVZ.Properties.Resources.icons8_юзер_в_круге_64;
            this.pictureBox1.Location = new System.Drawing.Point(131, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // LblMessage
            // 
            this.LblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblMessage.ForeColor = System.Drawing.Color.Black;
            this.LblMessage.Location = new System.Drawing.Point(453, 330);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(225, 111);
            this.LblMessage.TabIndex = 23;
            this.LblMessage.Text = "Сообщение";
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.PbxPincode);
            this.Controls.Add(this.TbxPinCode);
            this.Controls.Add(this.PnlPinCode);
            this.Controls.Add(this.LblPin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.CbxRoles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TbxLogin);
            this.Controls.Add(this.panel2);
            this.Name = "FormAuthorization";
            this.Text = "ВХОД В ЛИЧНЫЙ КАБИНЕТ";
            this.Load += new System.EventHandler(this.FormAuthorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxPincode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TbxLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxRoles;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LblPin;
        private System.Windows.Forms.TextBox TbxPinCode;
        private System.Windows.Forms.Panel PnlPinCode;
        private System.Windows.Forms.PictureBox PbxPincode;
        private System.Windows.Forms.Label LblMessage;
    }
}