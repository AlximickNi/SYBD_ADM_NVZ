
namespace SYBD_ADM_NVZ
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PbxHelpPicture = new System.Windows.Forms.PictureBox();
            this.PnlTitleBar = new System.Windows.Forms.Panel();
            this.BtnCloseChildForm = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlDesktopForm = new System.Windows.Forms.Panel();
            this.TmMain = new System.Windows.Forms.Timer(this.components);
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxHelpPicture)).BeginInit();
            this.PnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.PnlMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.PnlMenu.Location = new System.Drawing.Point(0, 74);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(214, 531);
            this.PnlMenu.TabIndex = 0;
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.PnlLogo.Controls.Add(this.PbxHelpPicture);
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(214, 74);
            this.PnlLogo.TabIndex = 0;
            // 
            // PbxHelpPicture
            // 
            this.PbxHelpPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxHelpPicture.Image = global::SYBD_ADM_NVZ.Properties.Resources.icons8_бронирование_1001;
            this.PbxHelpPicture.Location = new System.Drawing.Point(0, 0);
            this.PbxHelpPicture.Name = "PbxHelpPicture";
            this.PbxHelpPicture.Size = new System.Drawing.Size(214, 74);
            this.PbxHelpPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxHelpPicture.TabIndex = 7;
            this.PbxHelpPicture.TabStop = false;
            this.PbxHelpPicture.DoubleClick += new System.EventHandler(this.PbxHelpPicture_DoubleClick);
            // 
            // PnlTitleBar
            // 
            this.PnlTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.PnlTitleBar.Controls.Add(this.BtnCloseChildForm);
            this.PnlTitleBar.Controls.Add(this.LblTitle);
            this.PnlTitleBar.Location = new System.Drawing.Point(214, 0);
            this.PnlTitleBar.Name = "PnlTitleBar";
            this.PnlTitleBar.Size = new System.Drawing.Size(1092, 74);
            this.PnlTitleBar.TabIndex = 1;
            // 
            // BtnCloseChildForm
            // 
            this.BtnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.BtnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseChildForm.Font = new System.Drawing.Font("Microsoft Yi Baiti", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloseChildForm.ForeColor = System.Drawing.Color.White;
            this.BtnCloseChildForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.BtnCloseChildForm.Name = "BtnCloseChildForm";
            this.BtnCloseChildForm.Size = new System.Drawing.Size(65, 74);
            this.BtnCloseChildForm.TabIndex = 0;
            this.BtnCloseChildForm.Text = "×";
            this.BtnCloseChildForm.UseVisualStyleBackColor = true;
            this.BtnCloseChildForm.Click += new System.EventHandler(this.BtnCloseChildForm_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(71, 25);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(258, 29);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "ГЛАВНАЯ СТРАНИЦА";
            // 
            // PnlDesktopForm
            // 
            this.PnlDesktopForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlDesktopForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlDesktopForm.Location = new System.Drawing.Point(214, 74);
            this.PnlDesktopForm.Name = "PnlDesktopForm";
            this.PnlDesktopForm.Size = new System.Drawing.Size(1092, 531);
            this.PnlDesktopForm.TabIndex = 2;
            // 
            // TmMain
            // 
            this.TmMain.Tick += new System.EventHandler(this.TmMain_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1306, 605);
            this.Controls.Add(this.PnlLogo);
            this.Controls.Add(this.PnlDesktopForm);
            this.Controls.Add(this.PnlTitleBar);
            this.Controls.Add(this.PnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1322, 644);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД \"Новозыбковская городская администрация\"";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxHelpPicture)).EndInit();
            this.PnlTitleBar.ResumeLayout(false);
            this.PnlTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.Panel PnlTitleBar;
        private System.Windows.Forms.Panel PnlDesktopForm;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox PbxHelpPicture;
        private System.Windows.Forms.Button BtnCloseChildForm;
        public System.Windows.Forms.Timer TmMain;
    }
}

