
namespace SYBD_ADM_NVZ.Forms
{
    partial class FormProfile
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
            this.LblFIO = new System.Windows.Forms.Label();
            this.LblRole = new System.Windows.Forms.Label();
            this.LblSalary = new System.Windows.Forms.Label();
            this.LblAdress = new System.Windows.Forms.Label();
            this.LblDateOfEmployment = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnEditPhoto = new System.Windows.Forms.Button();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.PbxPhoto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LblPinCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblFIO
            // 
            this.LblFIO.AutoSize = true;
            this.LblFIO.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblFIO.Location = new System.Drawing.Point(218, 12);
            this.LblFIO.Name = "LblFIO";
            this.LblFIO.Size = new System.Drawing.Size(65, 30);
            this.LblFIO.TabIndex = 1;
            this.LblFIO.Text = "ФИО:";
            // 
            // LblRole
            // 
            this.LblRole.AutoSize = true;
            this.LblRole.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRole.Location = new System.Drawing.Point(218, 106);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(126, 30);
            this.LblRole.TabIndex = 2;
            this.LblRole.Text = "Должность:";
            // 
            // LblSalary
            // 
            this.LblSalary.AutoSize = true;
            this.LblSalary.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSalary.Location = new System.Drawing.Point(218, 156);
            this.LblSalary.Name = "LblSalary";
            this.LblSalary.Size = new System.Drawing.Size(77, 30);
            this.LblSalary.TabIndex = 3;
            this.LblSalary.Text = "Оклад:";
            // 
            // LblAdress
            // 
            this.LblAdress.AutoSize = true;
            this.LblAdress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblAdress.Location = new System.Drawing.Point(12, 271);
            this.LblAdress.Name = "LblAdress";
            this.LblAdress.Size = new System.Drawing.Size(206, 30);
            this.LblAdress.TabIndex = 4;
            this.LblAdress.Text = "Место проживания:";
            // 
            // LblDateOfEmployment
            // 
            this.LblDateOfEmployment.AutoSize = true;
            this.LblDateOfEmployment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDateOfEmployment.Location = new System.Drawing.Point(218, 62);
            this.LblDateOfEmployment.Name = "LblDateOfEmployment";
            this.LblDateOfEmployment.Size = new System.Drawing.Size(244, 30);
            this.LblDateOfEmployment.TabIndex = 5;
            this.LblDateOfEmployment.Text = "Дата приёма на работу:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(276, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(455, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 1);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(289, 185);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 1);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(341, 135);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 1);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(211, 300);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(550, 1);
            this.panel6.TabIndex = 12;
            // 
            // BtnEditPhoto
            // 
            this.BtnEditPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.BtnEditPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditPhoto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnEditPhoto.ForeColor = System.Drawing.Color.White;
            this.BtnEditPhoto.Location = new System.Drawing.Point(223, 222);
            this.BtnEditPhoto.Name = "BtnEditPhoto";
            this.BtnEditPhoto.Size = new System.Drawing.Size(207, 35);
            this.BtnEditPhoto.TabIndex = 13;
            this.BtnEditPhoto.Text = "Сменить фотографию";
            this.BtnEditPhoto.UseVisualStyleBackColor = false;
            this.BtnEditPhoto.Click += new System.EventHandler(this.BtnEditPhoto_Click);
            // 
            // OFD1
            // 
            this.OFD1.Filter = "Файл PNG|*.png| Файл JPEG|*.jpg";
            // 
            // PbxPhoto
            // 
            this.PbxPhoto.Location = new System.Drawing.Point(4, 3);
            this.PbxPhoto.Name = "PbxPhoto";
            this.PbxPhoto.Size = new System.Drawing.Size(191, 237);
            this.PbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxPhoto.TabIndex = 0;
            this.PbxPhoto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PbxPhoto);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 245);
            this.panel1.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(570, 256);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(130, 1);
            this.panel7.TabIndex = 16;
            // 
            // LblPinCode
            // 
            this.LblPinCode.AutoSize = true;
            this.LblPinCode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPinCode.Location = new System.Drawing.Point(436, 227);
            this.LblPinCode.Name = "LblPinCode";
            this.LblPinCode.Size = new System.Drawing.Size(138, 30);
            this.LblPinCode.TabIndex = 15;
            this.LblPinCode.Text = "Ваш Pin-Cod:";
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.LblPinCode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnEditPhoto);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LblDateOfEmployment);
            this.Controls.Add(this.LblAdress);
            this.Controls.Add(this.LblSalary);
            this.Controls.Add(this.LblRole);
            this.Controls.Add(this.LblFIO);
            this.Name = "FormProfile";
            this.Text = "ЛИЧНЫЙ КАБИНЕТ";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxPhoto;
        private System.Windows.Forms.Label LblFIO;
        private System.Windows.Forms.Label LblRole;
        private System.Windows.Forms.Label LblSalary;
        private System.Windows.Forms.Label LblAdress;
        private System.Windows.Forms.Label LblDateOfEmployment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnEditPhoto;
        private System.Windows.Forms.OpenFileDialog OFD1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Label LblPinCode;
    }
}