
namespace SYBD_ADM_NVZ.Forms.EmployeeOfThePersonnelDepartment
{
    partial class FormApplicationsVacationOrSickLeave
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.FPNLWorkers = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnCreateApplication = new System.Windows.Forms.Button();
            this.CbxThema = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxOtch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxFam = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DTPBStart = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.DTPBEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 676);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FPNLWorkers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 676);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.DTPBEnd);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.DTPBStart);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TbxOtch);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.TbxName);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TbxFam);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.CbxThema);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.BtnCreateApplication);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(408, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 676);
            this.panel3.TabIndex = 1;
            // 
            // FPNLWorkers
            // 
            this.FPNLWorkers.AutoScroll = true;
            this.FPNLWorkers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FPNLWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FPNLWorkers.Location = new System.Drawing.Point(0, 0);
            this.FPNLWorkers.Name = "FPNLWorkers";
            this.FPNLWorkers.Size = new System.Drawing.Size(408, 676);
            this.FPNLWorkers.TabIndex = 2;
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
            this.BtnCreateApplication.TabIndex = 162;
            this.BtnCreateApplication.Text = "Сформировать заявление для отпускного или больничного";
            this.BtnCreateApplication.UseVisualStyleBackColor = false;
            this.BtnCreateApplication.Click += new System.EventHandler(this.BtnCreateApplication_Click);
            // 
            // CbxThema
            // 
            this.CbxThema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxThema.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.CbxThema.FormattingEnabled = true;
            this.CbxThema.Items.AddRange(new object[] {
            "Отпуск",
            "Больничный"});
            this.CbxThema.Location = new System.Drawing.Point(121, 162);
            this.CbxThema.Name = "CbxThema";
            this.CbxThema.Size = new System.Drawing.Size(216, 33);
            this.CbxThema.TabIndex = 163;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(56, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 25);
            this.label13.TabIndex = 164;
            this.label13.Text = "Тема:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 171;
            this.label3.Text = "Отчество:";
            // 
            // TbxOtch
            // 
            this.TbxOtch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxOtch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxOtch.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TbxOtch.ForeColor = System.Drawing.Color.Black;
            this.TbxOtch.Location = new System.Drawing.Point(121, 80);
            this.TbxOtch.Name = "TbxOtch";
            this.TbxOtch.Size = new System.Drawing.Size(304, 26);
            this.TbxOtch.TabIndex = 167;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(121, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 1);
            this.panel4.TabIndex = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(58, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 172;
            this.label2.Text = "Имя:";
            // 
            // TbxName
            // 
            this.TbxName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TbxName.ForeColor = System.Drawing.Color.Black;
            this.TbxName.Location = new System.Drawing.Point(121, 46);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(304, 26);
            this.TbxName.TabIndex = 166;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(121, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(314, 1);
            this.panel5.TabIndex = 169;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 173;
            this.label1.Text = "Фамилия:";
            // 
            // TbxFam
            // 
            this.TbxFam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxFam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxFam.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TbxFam.ForeColor = System.Drawing.Color.Black;
            this.TbxFam.Location = new System.Drawing.Point(121, 12);
            this.TbxFam.Name = "TbxFam";
            this.TbxFam.Size = new System.Drawing.Size(304, 26);
            this.TbxFam.TabIndex = 165;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(121, 39);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(314, 1);
            this.panel6.TabIndex = 168;
            // 
            // DTPBStart
            // 
            this.DTPBStart.Location = new System.Drawing.Point(137, 214);
            this.DTPBStart.Name = "DTPBStart";
            this.DTPBStart.Size = new System.Drawing.Size(200, 20);
            this.DTPBStart.TabIndex = 174;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(50, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 175;
            this.label10.Text = "Начало:";
            // 
            // DTPBEnd
            // 
            this.DTPBEnd.Location = new System.Drawing.Point(137, 260);
            this.DTPBEnd.Name = "DTPBEnd";
            this.DTPBEnd.Size = new System.Drawing.Size(200, 20);
            this.DTPBEnd.TabIndex = 176;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(61, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 177;
            this.label4.Text = "Конец:";
            // 
            // FormApplicationsVacationOrSickLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 676);
            this.Controls.Add(this.panel1);
            this.Name = "FormApplicationsVacationOrSickLeave";
            this.Text = "ЗАЯВЛЕНИЕ ДЛЯ ОТПУСКА ИЛИ БОЛЬНИЧНОГО";
            this.Load += new System.EventHandler(this.FormApplicationsVacationOrSickLeave_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel FPNLWorkers;
        private System.Windows.Forms.Button BtnCreateApplication;
        private System.Windows.Forms.ComboBox CbxThema;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxOtch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxFam;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker DTPBEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPBStart;
        private System.Windows.Forms.Label label10;
    }
}