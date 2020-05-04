namespace Kivinjari
{
    partial class CcTabWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CcTabWindow));
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
            this.toolbarBackground.BackgroundImage = global::Kivinjari.Resources.ToolbarBackground;
            this.toolbarBackground.Controls.Add(this.BtnHome);
            this.toolbarBackground.Controls.Add(this.BtnRefresh);
            this.toolbarBackground.Controls.Add(this.BtnForward);
            this.toolbarBackground.Controls.Add(this.BtnBack);
            this.toolbarBackground.Controls.Add(this.TxtAddress);
            this.toolbarBackground.Controls.Add(this.urlBorder);
            this.toolbarBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarBackground.Location = new System.Drawing.Point(0, 0);
            this.toolbarBackground.Name = "toolbarBackground";
            this.toolbarBackground.Size = new System.Drawing.Size(665, 36);
            this.toolbarBackground.TabIndex = 2;
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Transparent;
            this.BtnHome.Image = global::Kivinjari.Resources.Startpage;
            this.BtnHome.Location = new System.Drawing.Point(99, 5);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(27, 27);
            this.BtnHome.TabIndex = 4;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.BtnHome.MouseEnter += new System.EventHandler(this.BtnHome_MouseEnter);
            this.BtnHome.MouseLeave += new System.EventHandler(this.BtnHome_MouseLeave);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefresh.Image = global::Kivinjari.Resources.refresh;
            this.BtnRefresh.Location = new System.Drawing.Point(68, 5);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(27, 27);
            this.BtnRefresh.TabIndex = 4;
            this.BtnRefresh.TabStop = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            this.BtnRefresh.MouseEnter += new System.EventHandler(this.BtnRefresh_MouseEnter);
            this.BtnRefresh.MouseLeave += new System.EventHandler(this.BtnRefresh_MouseLeave);
            // 
            // BtnForward
            // 
            this.BtnForward.BackColor = System.Drawing.Color.Transparent;
            this.BtnForward.Image = global::Kivinjari.Resources.ForwardActive;
            this.BtnForward.Location = new System.Drawing.Point(37, 5);
            this.BtnForward.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(27, 27);
            this.BtnForward.TabIndex = 3;
            this.BtnForward.TabStop = false;
            this.BtnForward.Click += new System.EventHandler(this.BtnForward_Click);
            this.BtnForward.MouseEnter += new System.EventHandler(this.BtnForward_MouseEnter);
            this.BtnForward.MouseLeave += new System.EventHandler(this.BtnForward_MouseLeave);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.Image = global::Kivinjari.Resources.BackActive;
            this.BtnBack.Location = new System.Drawing.Point(6, 5);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(27, 27);
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
            this.TxtAddress.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(141, 8);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(9);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(515, 19);
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
            this.urlBorder.Location = new System.Drawing.Point(131, 5);
            this.urlBorder.Name = "urlBorder";
            this.urlBorder.Size = new System.Drawing.Size(530, 26);
            this.urlBorder.TabIndex = 1;
            // 
            // urlBackground
            // 
            this.urlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBackground.BackColor = System.Drawing.Color.White;
            this.urlBackground.ForeColor = System.Drawing.Color.Silver;
            this.urlBackground.Location = new System.Drawing.Point(1, 1);
            this.urlBackground.Name = "urlBackground";
            this.urlBackground.Size = new System.Drawing.Size(529, 24);
            this.urlBackground.TabIndex = 2;
            // 
            // webPanel
            // 
            this.webPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPanel.Location = new System.Drawing.Point(0, 36);
            this.webPanel.Name = "webPanel";
            this.webPanel.Size = new System.Drawing.Size(665, 318);
            this.webPanel.TabIndex = 3;
            // 
            // CcTabWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 354);
            this.Controls.Add(this.webPanel);
            this.Controls.Add(this.toolbarBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CcTabWindow";
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