
namespace SYBD_ADM_NVZ.Forms.SystemAdministrator
{
    partial class FormCheckAndIssueLoginDetailsForSpecialWorkers
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
            this.FPNLSpWorkers = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FPNLSpWorkers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // FPNLSpWorkers
            // 
            this.FPNLSpWorkers.AutoScroll = true;
            this.FPNLSpWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FPNLSpWorkers.Location = new System.Drawing.Point(0, 0);
            this.FPNLSpWorkers.Name = "FPNLSpWorkers";
            this.FPNLSpWorkers.Size = new System.Drawing.Size(800, 450);
            this.FPNLSpWorkers.TabIndex = 0;
            // 
            // FormCheckAndIssueLoginDetailsForSpecialWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormCheckAndIssueLoginDetailsForSpecialWorkers";
            this.Text = "ПРОВЕРИТЬ И ВЫДАТЬ ДАННЫЕ ДЛЯ ВХОДА СПЕЦИАЛЬНЫХ РАБОТНИКОВ";
            this.Load += new System.EventHandler(this.FormCheckAndIssueLoginDetailsForSpecialWorkers_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel FPNLSpWorkers;
    }
}