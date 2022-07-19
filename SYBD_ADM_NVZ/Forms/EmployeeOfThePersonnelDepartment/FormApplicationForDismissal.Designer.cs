
namespace SYBD_ADM_NVZ.Forms.EmployeeOfThePersonnelDepartment
{
    partial class FormApplicationForDismissal
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnCreateApplication = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TbxReason = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TbxPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.TbxRole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.TbxSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxOtch = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxFam = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FPNLWorkers = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 676);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 676);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.BtnCreateApplication);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.TbxReason);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.TbxPhone);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.TbxRole);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.TbxSalary);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.TbxOtch);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.TbxName);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.TbxFam);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(408, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(671, 676);
            this.panel4.TabIndex = 1;
            // 
            // BtnCreateApplication
            // 
            this.BtnCreateApplication.BackColor = System.Drawing.Color.Silver;
            this.BtnCreateApplication.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCreateApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateApplication.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnCreateApplication.ForeColor = System.Drawing.Color.White;
            this.BtnCreateApplication.Location = new System.Drawing.Point(0, 615);
            this.BtnCreateApplication.Name = "BtnCreateApplication";
            this.BtnCreateApplication.Size = new System.Drawing.Size(671, 61);
            this.BtnCreateApplication.TabIndex = 161;
            this.BtnCreateApplication.Text = "Сформировать увольнительное заявление ";
            this.BtnCreateApplication.UseVisualStyleBackColor = false;
            this.BtnCreateApplication.Click += new System.EventHandler(this.BtnCreateApplication_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(15, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 25);
            this.label7.TabIndex = 152;
            this.label7.Text = "Причина увольнения:";
            // 
            // TbxReason
            // 
            this.TbxReason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxReason.Location = new System.Drawing.Point(20, 289);
            this.TbxReason.Multiline = true;
            this.TbxReason.Name = "TbxReason";
            this.TbxReason.Size = new System.Drawing.Size(628, 180);
            this.TbxReason.TabIndex = 151;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(167, 156);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(314, 1);
            this.panel6.TabIndex = 145;
            // 
            // TbxPhone
            // 
            this.TbxPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TbxPhone.ForeColor = System.Drawing.Color.Black;
            this.TbxPhone.Location = new System.Drawing.Point(167, 129);
            this.TbxPhone.Name = "TbxPhone";
            this.TbxPhone.ReadOnly = true;
            this.TbxPhone.Size = new System.Drawing.Size(304, 26);
            this.TbxPhone.TabIndex = 142;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(8, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 150;
            this.label4.Text = "Номер телефона:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(167, 190);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(314, 1);
            this.panel9.TabIndex = 146;
            // 
            // TbxRole
            // 
            this.TbxRole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxRole.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TbxRole.ForeColor = System.Drawing.Color.Black;
            this.TbxRole.Location = new System.Drawing.Point(167, 163);
            this.TbxRole.Name = "TbxRole";
            this.TbxRole.ReadOnly = true;
            this.TbxRole.Size = new System.Drawing.Size(304, 26);
            this.TbxRole.TabIndex = 143;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(48, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 149;
            this.label5.Text = "Должность:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(167, 224);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(314, 1);
            this.panel10.TabIndex = 147;
            // 
            // TbxSalary
            // 
            this.TbxSalary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxSalary.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TbxSalary.ForeColor = System.Drawing.Color.Black;
            this.TbxSalary.Location = new System.Drawing.Point(167, 197);
            this.TbxSalary.Name = "TbxSalary";
            this.TbxSalary.ReadOnly = true;
            this.TbxSalary.Size = new System.Drawing.Size(304, 26);
            this.TbxSalary.TabIndex = 144;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(92, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 148;
            this.label6.Text = "Оклад:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 139;
            this.label3.Text = "Отчество:";
            // 
            // TbxOtch
            // 
            this.TbxOtch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxOtch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxOtch.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TbxOtch.ForeColor = System.Drawing.Color.Black;
            this.TbxOtch.Location = new System.Drawing.Point(120, 80);
            this.TbxOtch.Name = "TbxOtch";
            this.TbxOtch.ReadOnly = true;
            this.TbxOtch.Size = new System.Drawing.Size(304, 26);
            this.TbxOtch.TabIndex = 135;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(120, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(314, 1);
            this.panel5.TabIndex = 138;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(57, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 141;
            this.label2.Text = "Имя:";
            // 
            // TbxName
            // 
            this.TbxName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TbxName.ForeColor = System.Drawing.Color.Black;
            this.TbxName.Location = new System.Drawing.Point(120, 46);
            this.TbxName.Name = "TbxName";
            this.TbxName.ReadOnly = true;
            this.TbxName.Size = new System.Drawing.Size(304, 26);
            this.TbxName.TabIndex = 134;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(120, 73);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(314, 1);
            this.panel7.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 140;
            this.label1.Text = "Фамилия:";
            // 
            // TbxFam
            // 
            this.TbxFam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxFam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxFam.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TbxFam.ForeColor = System.Drawing.Color.Black;
            this.TbxFam.Location = new System.Drawing.Point(120, 12);
            this.TbxFam.Name = "TbxFam";
            this.TbxFam.ReadOnly = true;
            this.TbxFam.Size = new System.Drawing.Size(304, 26);
            this.TbxFam.TabIndex = 133;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(120, 39);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(314, 1);
            this.panel8.TabIndex = 136;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FPNLWorkers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 676);
            this.panel3.TabIndex = 0;
            // 
            // FPNLWorkers
            // 
            this.FPNLWorkers.AutoScroll = true;
            this.FPNLWorkers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FPNLWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FPNLWorkers.Location = new System.Drawing.Point(0, 0);
            this.FPNLWorkers.Name = "FPNLWorkers";
            this.FPNLWorkers.Size = new System.Drawing.Size(408, 676);
            this.FPNLWorkers.TabIndex = 1;
            // 
            // FormApplicationForDismissal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 676);
            this.Controls.Add(this.panel1);
            this.Name = "FormApplicationForDismissal";
            this.Text = "ЗАЯВЛЕНИЕ ДЛЯ УВОЛЬНЕНИЯ СОТРУДНИКА";
            this.Load += new System.EventHandler(this.FormApplicationForDismissal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel FPNLWorkers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxOtch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxFam;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox TbxPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox TbxRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox TbxSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxReason;
        private System.Windows.Forms.Button BtnCreateApplication;
    }
}