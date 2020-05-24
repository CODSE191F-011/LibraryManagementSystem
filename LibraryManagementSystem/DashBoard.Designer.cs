namespace LibraryManagementSystem
{
    partial class DashBoard
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
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnMembership = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.context = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnOff = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSmenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.FormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.TransitionMenu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.TransitionMenuHide = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.supplier1 = new LibraryManagementSystem.Views.Supplier();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.context.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSmenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.panel3);
            this.TransitionMenuHide.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenu.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(234, 601);
            this.panelMenu.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.SidePanel);
            this.panel3.Controls.Add(this.btnHelp);
            this.panel3.Controls.Add(this.btnReport);
            this.panel3.Controls.Add(this.btnAccounts);
            this.panel3.Controls.Add(this.btnSupplier);
            this.panel3.Controls.Add(this.btnMembership);
            this.panel3.Controls.Add(this.btnhome);
            this.panel3.Controls.Add(this.btnBooks);
            this.TransitionMenuHide.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenu.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(0, 115);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 486);
            this.panel3.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Lime;
            this.TransitionMenuHide.SetDecoration(this.SidePanel, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenu.SetDecoration(this.SidePanel, BunifuAnimatorNS.DecorationType.None);
            this.SidePanel.Location = new System.Drawing.Point(3, 3);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(5, 50);
            this.SidePanel.TabIndex = 11;
            // 
            // btnHelp
            // 
            this.TransitionMenu.SetDecoration(this.btnHelp, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenuHide.SetDecoration(this.btnHelp, BunifuAnimatorNS.DecorationType.None);
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(12, 339);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(221, 50);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "    Help";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.TransitionMenu.SetDecoration(this.btnReport, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenuHide.SetDecoration(this.btnReport, BunifuAnimatorNS.DecorationType.None);
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(13, 283);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(221, 50);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "    Reports";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnAccounts
            // 
            this.TransitionMenu.SetDecoration(this.btnAccounts, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenuHide.SetDecoration(this.btnAccounts, BunifuAnimatorNS.DecorationType.None);
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAccounts.Image = ((System.Drawing.Image)(resources.GetObject("btnAccounts.Image")));
            this.btnAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.Location = new System.Drawing.Point(12, 227);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(221, 50);
            this.btnAccounts.TabIndex = 8;
            this.btnAccounts.Text = "    Accounts";
            this.btnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccounts.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            this.TransitionMenu.SetDecoration(this.btnSupplier, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenuHide.SetDecoration(this.btnSupplier, BunifuAnimatorNS.DecorationType.None);
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.Location = new System.Drawing.Point(12, 171);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(218, 50);
            this.btnSupplier.TabIndex = 7;
            this.btnSupplier.Text = "    Suppliers";
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnMembership
            // 
            this.TransitionMenu.SetDecoration(this.btnMembership, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenuHide.SetDecoration(this.btnMembership, BunifuAnimatorNS.DecorationType.None);
            this.btnMembership.FlatAppearance.BorderSize = 0;
            this.btnMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembership.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembership.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMembership.Image = ((System.Drawing.Image)(resources.GetObject("btnMembership.Image")));
            this.btnMembership.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembership.Location = new System.Drawing.Point(12, 59);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(221, 50);
            this.btnMembership.TabIndex = 6;
            this.btnMembership.Text = "    Memberships";
            this.btnMembership.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembership.UseVisualStyleBackColor = true;
            // 
            // btnhome
            // 
            this.TransitionMenu.SetDecoration(this.btnhome, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenuHide.SetDecoration(this.btnhome, BunifuAnimatorNS.DecorationType.None);
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(9, 3);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(221, 50);
            this.btnhome.TabIndex = 5;
            this.btnhome.Text = "    Home";
            this.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhome.UseVisualStyleBackColor = true;
            // 
            // btnBooks
            // 
            this.TransitionMenu.SetDecoration(this.btnBooks, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenuHide.SetDecoration(this.btnBooks, BunifuAnimatorNS.DecorationType.None);
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnBooks.Image")));
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(12, 115);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(221, 50);
            this.btnBooks.TabIndex = 4;
            this.btnBooks.Text = "    Books";
            this.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBooks.UseVisualStyleBackColor = true;
            // 
            // context
            // 
            this.context.BackColor = System.Drawing.Color.DimGray;
            this.context.Controls.Add(this.supplier1);
            this.context.Controls.Add(this.panel4);
            this.TransitionMenuHide.SetDecoration(this.context, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenu.SetDecoration(this.context, BunifuAnimatorNS.DecorationType.None);
            this.context.Dock = System.Windows.Forms.DockStyle.Left;
            this.context.Location = new System.Drawing.Point(234, 0);
            this.context.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(738, 601);
            this.context.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.btnOff);
            this.panel4.Controls.Add(this.btnSmenu);
            this.panel4.Controls.Add(this.label2);
            this.TransitionMenuHide.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenu.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.Navy;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(738, 52);
            this.panel4.TabIndex = 2;
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.Transparent;
            this.TransitionMenuHide.SetDecoration(this.btnOff, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenu.SetDecoration(this.btnOff, BunifuAnimatorNS.DecorationType.None);
            this.btnOff.Image = ((System.Drawing.Image)(resources.GetObject("btnOff.Image")));
            this.btnOff.ImageActive = null;
            this.btnOff.Location = new System.Drawing.Point(695, 12);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(30, 30);
            this.btnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOff.TabIndex = 3;
            this.btnOff.TabStop = false;
            this.btnOff.Zoom = 10;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnSmenu
            // 
            this.btnSmenu.BackColor = System.Drawing.Color.Transparent;
            this.TransitionMenuHide.SetDecoration(this.btnSmenu, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenu.SetDecoration(this.btnSmenu, BunifuAnimatorNS.DecorationType.None);
            this.btnSmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnSmenu.Image")));
            this.btnSmenu.ImageActive = null;
            this.btnSmenu.Location = new System.Drawing.Point(9, 9);
            this.btnSmenu.Name = "btnSmenu";
            this.btnSmenu.Size = new System.Drawing.Size(31, 33);
            this.btnSmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSmenu.TabIndex = 2;
            this.btnSmenu.TabStop = false;
            this.btnSmenu.Zoom = 10;
            this.btnSmenu.Click += new System.EventHandler(this.btnSmenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.TransitionMenu.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenuHide.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.label2.Location = new System.Drawing.Point(151, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Library Management System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormFadeTransition1
            // 
            this.FormFadeTransition1.Delay = 2;
            this.FormFadeTransition1.TransitionEnd += new System.EventHandler(this.formfade);
            // 
            // TransitionMenu
            // 
            this.TransitionMenu.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.TransitionMenu.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.TransitionMenu.DefaultAnimation = animation5;
            this.TransitionMenu.AllAnimationsCompleted += new System.EventHandler(this.Mshow);
            // 
            // TransitionMenuHide
            // 
            this.TransitionMenuHide.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.TransitionMenuHide.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.TransitionMenuHide.DefaultAnimation = animation6;
            // 
            // supplier1
            // 
            this.supplier1.BackColor = System.Drawing.Color.Transparent;
            this.TransitionMenu.SetDecoration(this.supplier1, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenuHide.SetDecoration(this.supplier1, BunifuAnimatorNS.DecorationType.None);
            this.supplier1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.supplier1.Location = new System.Drawing.Point(0, 48);
            this.supplier1.Name = "supplier1";
            this.supplier1.Size = new System.Drawing.Size(738, 553);
            this.supplier1.TabIndex = 3;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 601);
            this.Controls.Add(this.context);
            this.Controls.Add(this.panelMenu);
            this.TransitionMenuHide.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.TransitionMenu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.context.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSmenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnMembership;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Panel context;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnOff;
        private Bunifu.Framework.UI.BunifuImageButton btnSmenu;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormFadeTransition1;
        private BunifuAnimatorNS.BunifuTransition TransitionMenu;
        private BunifuAnimatorNS.BunifuTransition TransitionMenuHide;
        private Views.Supplier supplier1;
    }
}