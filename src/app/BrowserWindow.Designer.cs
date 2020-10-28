namespace Kivinjari
{
    partial class BrowserWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserWindow));
            this.toolbarBackground = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.BtnRefresh = new System.Windows.Forms.PictureBox();
            this.BtnForward = new System.Windows.Forms.PictureBox();
            this.BtnBack = new System.Windows.Forms.PictureBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.urlBorder = new System.Windows.Forms.Panel();
            this.urlBackground = new System.Windows.Forms.Panel();
            this.webPanel = new System.Windows.Forms.Panel();
            this.toolbarBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).BeginInit();
            this.urlBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarBackground
            // 
            this.toolbarBackground.Controls.Add(this.BtnHome);
            this.toolbarBackground.Controls.Add(this.BtnRefresh);
            this.toolbarBackground.Controls.Add(this.BtnForward);
            this.toolbarBackground.Controls.Add(this.BtnBack);
            this.toolbarBackground.Controls.Add(this.TxtAddress);
            this.toolbarBackground.Controls.Add(this.urlBorder);
            this.toolbarBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarBackground.Location = new System.Drawing.Point(0, 0);
            this.toolbarBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toolbarBackground.Name = "toolbarBackground";
            this.toolbarBackground.Size = new System.Drawing.Size(776, 42);
            this.toolbarBackground.TabIndex = 2;
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Transparent;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(115, 6);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(5, 5, 4, 3);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(31, 31);
            this.BtnHome.TabIndex = 4;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.BtnHome.MouseEnter += new System.EventHandler(this.BtnHome_MouseEnter);
            this.BtnHome.MouseLeave += new System.EventHandler(this.BtnHome_MouseLeave);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.Location = new System.Drawing.Point(79, 6);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(5, 5, 4, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(31, 31);
            this.BtnRefresh.TabIndex = 4;
            this.BtnRefresh.TabStop = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            this.BtnRefresh.MouseEnter += new System.EventHandler(this.BtnRefresh_MouseEnter);
            this.BtnRefresh.MouseLeave += new System.EventHandler(this.BtnRefresh_MouseLeave);
            // 
            // BtnForward
            // 
            this.BtnForward.BackColor = System.Drawing.Color.Transparent;
            this.BtnForward.Image = ((System.Drawing.Image)(resources.GetObject("BtnForward.Image")));
            this.BtnForward.Location = new System.Drawing.Point(43, 6);
            this.BtnForward.Margin = new System.Windows.Forms.Padding(5, 5, 4, 3);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(31, 31);
            this.BtnForward.TabIndex = 3;
            this.BtnForward.TabStop = false;
            this.BtnForward.Click += new System.EventHandler(this.BtnForward_Click);
            this.BtnForward.MouseEnter += new System.EventHandler(this.BtnForward_MouseEnter);
            this.BtnForward.MouseLeave += new System.EventHandler(this.BtnForward_MouseLeave);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(7, 6);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(5, 5, 4, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(31, 31);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.TabStop = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            this.BtnBack.MouseEnter += new System.EventHandler(this.BtnBack_MouseEnter);
            this.BtnBack.MouseLeave += new System.EventHandler(this.BtnBack_MouseLeave);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAddress.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAddress.Location = new System.Drawing.Point(164, 9);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(10);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(601, 19);
            this.TxtAddress.TabIndex = 0;
            this.TxtAddress.Text = "about:blank";
            this.TxtAddress.WordWrap = false;
            this.TxtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAddress_KeyDown);
            // 
            // urlBorder
            // 
            this.urlBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBorder.BackColor = System.Drawing.Color.Silver;
            this.urlBorder.Controls.Add(this.urlBackground);
            this.urlBorder.ForeColor = System.Drawing.Color.Silver;
            this.urlBorder.Location = new System.Drawing.Point(153, 6);
            this.urlBorder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.urlBorder.Name = "urlBorder";
            this.urlBorder.Size = new System.Drawing.Size(618, 30);
            this.urlBorder.TabIndex = 1;
            // 
            // urlBackground
            // 
            this.urlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBackground.BackColor = System.Drawing.Color.White;
            this.urlBackground.ForeColor = System.Drawing.Color.Silver;
            this.urlBackground.Location = new System.Drawing.Point(1, 1);
            this.urlBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.urlBackground.Name = "urlBackground";
            this.urlBackground.Size = new System.Drawing.Size(617, 28);
            this.urlBackground.TabIndex = 2;
            // 
            // webPanel
            // 
            this.webPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPanel.Location = new System.Drawing.Point(0, 42);
            this.webPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.webPanel.Name = "webPanel";
            this.webPanel.Size = new System.Drawing.Size(776, 366);
            this.webPanel.TabIndex = 3;
            // 
            // BrowserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 408);
            this.Controls.Add(this.webPanel);
            this.Controls.Add(this.toolbarBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BrowserWindow";
            this.Text = "Kivinjari";
            this.toolbarBackground.ResumeLayout(false);
            this.toolbarBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).EndInit();
            this.urlBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolbarBackground;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Panel urlBorder;
        private System.Windows.Forms.Panel urlBackground;
        private System.Windows.Forms.PictureBox BtnBack;
        private System.Windows.Forms.PictureBox BtnForward;
        private System.Windows.Forms.Panel webPanel;
        private System.Windows.Forms.PictureBox BtnHome;
        private System.Windows.Forms.PictureBox BtnRefresh;
    }
}