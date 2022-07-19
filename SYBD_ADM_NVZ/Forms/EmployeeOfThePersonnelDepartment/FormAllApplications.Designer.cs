
namespace SYBD_ADM_NVZ.Forms.EmployeeOfThePersonnelDepartment
{
    partial class FormAllApplications
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
            this.FPNLAllAppli = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxTimeCreate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxTypeAppli = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxStatusAppli = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FPNLAllAppli
            // 
            this.FPNLAllAppli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FPNLAllAppli.Location = new System.Drawing.Point(0, 0);
            this.FPNLAllAppli.Name = "FPNLAllAppli";
            this.FPNLAllAppli.Size = new System.Drawing.Size(646, 281);
            this.FPNLAllAppli.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CbxTimeCreate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CbxTypeAppli);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CbxStatusAppli);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 133);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(4, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Фильтр по времени создания:";
            // 
            // CbxTimeCreate
            // 
            this.CbxTimeCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTimeCreate.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.CbxTimeCreate.FormattingEnabled = true;
            this.CbxTimeCreate.Items.AddRange(new object[] {
            "Новые",
            "Старые"});
            this.CbxTimeCreate.Location = new System.Drawing.Point(283, 87);
            this.CbxTimeCreate.Name = "CbxTimeCreate";
            this.CbxTimeCreate.Size = new System.Drawing.Size(304, 33);
            this.CbxTimeCreate.TabIndex = 20;
            this.CbxTimeCreate.SelectedIndexChanged += new System.EventHandler(this.CbxTimeCreate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Фильтр по типу:";
            // 
            // CbxTypeAppli
            // 
            this.CbxTypeAppli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTypeAppli.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.CbxTypeAppli.FormattingEnabled = true;
            this.CbxTypeAppli.Items.AddRange(new object[] {
            "Все",
            "Принятие на работу",
            "Изменение личных данных",
            "Увольнительная",
            "Отпускная или больничная"});
            this.CbxTypeAppli.Location = new System.Drawing.Point(186, 9);
            this.CbxTypeAppli.Name = "CbxTypeAppli";
            this.CbxTypeAppli.Size = new System.Drawing.Size(304, 33);
            this.CbxTypeAppli.TabIndex = 18;
            this.CbxTypeAppli.SelectedIndexChanged += new System.EventHandler(this.CbxTypeAppli_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Фильтр по статусу:";
            // 
            // CbxStatusAppli
            // 
            this.CbxStatusAppli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxStatusAppli.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.CbxStatusAppli.FormattingEnabled = true;
            this.CbxStatusAppli.Items.AddRange(new object[] {
            "Все",
            "Принято",
            "Ожидание",
            "Отклонено"});
            this.CbxStatusAppli.Location = new System.Drawing.Point(186, 48);
            this.CbxStatusAppli.Name = "CbxStatusAppli";
            this.CbxStatusAppli.Size = new System.Drawing.Size(304, 33);
            this.CbxStatusAppli.TabIndex = 2;
            this.CbxStatusAppli.SelectedIndexChanged += new System.EventHandler(this.CbxStatus_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.FPNLAllAppli);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 283);
            this.panel2.TabIndex = 2;
            // 
            // FormAllApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(648, 416);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormAllApplications";
            this.Text = "ВСЕ ВАШИ ЗАЯВКИ";
            this.Load += new System.EventHandler(this.FormAllApplications_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FPNLAllAppli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CbxStatusAppli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxTypeAppli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxTimeCreate;
    }
}