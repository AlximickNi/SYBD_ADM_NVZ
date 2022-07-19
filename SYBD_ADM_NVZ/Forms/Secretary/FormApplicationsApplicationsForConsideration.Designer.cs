
namespace SYBD_ADM_NVZ.Forms.Secretary
{
    partial class FormApplicationsApplicationsForConsideration
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.FPNLAllAppli = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnDismiss = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 504);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 504);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.FPNLAllAppli);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1108, 424);
            this.panel5.TabIndex = 1;
            // 
            // FPNLAllAppli
            // 
            this.FPNLAllAppli.AutoScroll = true;
            this.FPNLAllAppli.BackColor = System.Drawing.Color.White;
            this.FPNLAllAppli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FPNLAllAppli.Location = new System.Drawing.Point(0, 0);
            this.FPNLAllAppli.Name = "FPNLAllAppli";
            this.FPNLAllAppli.Size = new System.Drawing.Size(1108, 424);
            this.FPNLAllAppli.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.BtnDismiss);
            this.panel4.Controls.Add(this.BtnAccept);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1108, 80);
            this.panel4.TabIndex = 0;
            // 
            // BtnDismiss
            // 
            this.BtnDismiss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDismiss.BackColor = System.Drawing.Color.Silver;
            this.BtnDismiss.FlatAppearance.BorderSize = 0;
            this.BtnDismiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDismiss.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDismiss.ForeColor = System.Drawing.Color.White;
            this.BtnDismiss.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDismiss.Location = new System.Drawing.Point(949, 12);
            this.BtnDismiss.Name = "BtnDismiss";
            this.BtnDismiss.Size = new System.Drawing.Size(152, 57);
            this.BtnDismiss.TabIndex = 7;
            this.BtnDismiss.Text = "Отклонить";
            this.BtnDismiss.UseVisualStyleBackColor = false;
            this.BtnDismiss.Click += new System.EventHandler(this.BtnDismiss_Click);
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.Silver;
            this.BtnAccept.FlatAppearance.BorderSize = 0;
            this.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccept.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAccept.ForeColor = System.Drawing.Color.White;
            this.BtnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAccept.Location = new System.Drawing.Point(8, 12);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(152, 57);
            this.BtnAccept.TabIndex = 6;
            this.BtnAccept.Text = "Принять";
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // FormApplicationsApplicationsForConsideration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 504);
            this.Controls.Add(this.panel1);
            this.Name = "FormApplicationsApplicationsForConsideration";
            this.Text = "ЗАЯВЛЕНИЯ НА РАССМОТРЕНИЯ";
            this.Load += new System.EventHandler(this.FormApplicationsApplicationsForConsideration_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnDismiss;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel FPNLAllAppli;
    }
}