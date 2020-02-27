namespace WinFormsUIMultiColor
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonReporting = new FontAwesome.Sharp.IconButton();
            this.iconButtonCustomers = new FontAwesome.Sharp.IconButton();
            this.iconButtonOrders = new FontAwesome.Sharp.IconButton();
            this.iconButtonProducts = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.iconButtonLogo = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconButtonWinMin = new FontAwesome.Sharp.IconButton();
            this.iconButtonWinMax = new FontAwesome.Sharp.IconButton();
            this.iconButtonWinClose = new FontAwesome.Sharp.IconButton();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconButtonLogoHome = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.iconButtonReporting);
            this.panelMenu.Controls.Add(this.iconButtonCustomers);
            this.panelMenu.Controls.Add(this.iconButtonOrders);
            this.panelMenu.Controls.Add(this.iconButtonProducts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 461);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonReporting
            // 
            this.iconButtonReporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonReporting.FlatAppearance.BorderSize = 0;
            this.iconButtonReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonReporting.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonReporting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonReporting.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonReporting.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconButtonReporting.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonReporting.IconSize = 32;
            this.iconButtonReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReporting.Location = new System.Drawing.Point(0, 320);
            this.iconButtonReporting.Name = "iconButtonReporting";
            this.iconButtonReporting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.iconButtonReporting.Rotation = 0D;
            this.iconButtonReporting.Size = new System.Drawing.Size(220, 80);
            this.iconButtonReporting.TabIndex = 4;
            this.iconButtonReporting.Text = "Reporting";
            this.iconButtonReporting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonReporting.UseVisualStyleBackColor = true;
            this.iconButtonReporting.Click += new System.EventHandler(this.iconButtonReporting_Click);
            // 
            // iconButtonCustomers
            // 
            this.iconButtonCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonCustomers.FlatAppearance.BorderSize = 0;
            this.iconButtonCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCustomers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCustomers.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonCustomers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButtonCustomers.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonCustomers.IconSize = 32;
            this.iconButtonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCustomers.Location = new System.Drawing.Point(0, 240);
            this.iconButtonCustomers.Name = "iconButtonCustomers";
            this.iconButtonCustomers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.iconButtonCustomers.Rotation = 0D;
            this.iconButtonCustomers.Size = new System.Drawing.Size(220, 80);
            this.iconButtonCustomers.TabIndex = 3;
            this.iconButtonCustomers.Text = "Customers";
            this.iconButtonCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCustomers.UseVisualStyleBackColor = true;
            this.iconButtonCustomers.Click += new System.EventHandler(this.iconButtonCustomers_Click);
            // 
            // iconButtonOrders
            // 
            this.iconButtonOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonOrders.FlatAppearance.BorderSize = 0;
            this.iconButtonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOrders.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonOrders.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonOrders.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.iconButtonOrders.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonOrders.IconSize = 32;
            this.iconButtonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOrders.Location = new System.Drawing.Point(0, 160);
            this.iconButtonOrders.Name = "iconButtonOrders";
            this.iconButtonOrders.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.iconButtonOrders.Rotation = 0D;
            this.iconButtonOrders.Size = new System.Drawing.Size(220, 80);
            this.iconButtonOrders.TabIndex = 2;
            this.iconButtonOrders.Text = "Orders";
            this.iconButtonOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOrders.UseVisualStyleBackColor = true;
            this.iconButtonOrders.Click += new System.EventHandler(this.iconButtonOrders_Click);
            // 
            // iconButtonProducts
            // 
            this.iconButtonProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonProducts.FlatAppearance.BorderSize = 0;
            this.iconButtonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonProducts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonProducts.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButtonProducts.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonProducts.IconSize = 32;
            this.iconButtonProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProducts.Location = new System.Drawing.Point(0, 80);
            this.iconButtonProducts.Name = "iconButtonProducts";
            this.iconButtonProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.iconButtonProducts.Rotation = 0D;
            this.iconButtonProducts.Size = new System.Drawing.Size(220, 80);
            this.iconButtonProducts.TabIndex = 1;
            this.iconButtonProducts.Text = "Products";
            this.iconButtonProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonProducts.UseVisualStyleBackColor = true;
            this.iconButtonProducts.Click += new System.EventHandler(this.iconButtonProducts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.iconButtonLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // iconButtonLogo
            // 
            this.iconButtonLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonLogo.FlatAppearance.BorderSize = 0;
            this.iconButtonLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonLogo.ForeColor = System.Drawing.Color.White;
            this.iconButtonLogo.IconChar = FontAwesome.Sharp.IconChar.Cat;
            this.iconButtonLogo.IconColor = System.Drawing.Color.White;
            this.iconButtonLogo.IconSize = 52;
            this.iconButtonLogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonLogo.Location = new System.Drawing.Point(12, 6);
            this.iconButtonLogo.Name = "iconButtonLogo";
            this.iconButtonLogo.Rotation = 0D;
            this.iconButtonLogo.Size = new System.Drawing.Size(193, 71);
            this.iconButtonLogo.TabIndex = 0;
            this.iconButtonLogo.Text = "My Logo";
            this.iconButtonLogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonLogo.UseVisualStyleBackColor = true;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.iconButtonWinMin);
            this.panelTitleBar.Controls.Add(this.iconButtonWinMax);
            this.panelTitleBar.Controls.Add(this.iconButtonWinClose);
            this.panelTitleBar.Controls.Add(this.iconButtonClose);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(584, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconButtonWinMin
            // 
            this.iconButtonWinMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonWinMin.FlatAppearance.BorderSize = 0;
            this.iconButtonWinMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonWinMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonWinMin.ForeColor = System.Drawing.Color.White;
            this.iconButtonWinMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonWinMin.IconColor = System.Drawing.Color.White;
            this.iconButtonWinMin.IconSize = 28;
            this.iconButtonWinMin.Location = new System.Drawing.Point(485, 6);
            this.iconButtonWinMin.Name = "iconButtonWinMin";
            this.iconButtonWinMin.Rotation = 0D;
            this.iconButtonWinMin.Size = new System.Drawing.Size(28, 28);
            this.iconButtonWinMin.TabIndex = 4;
            this.iconButtonWinMin.UseVisualStyleBackColor = true;
            this.iconButtonWinMin.Click += new System.EventHandler(this.iconButtonWinMin_Click);
            // 
            // iconButtonWinMax
            // 
            this.iconButtonWinMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonWinMax.FlatAppearance.BorderSize = 0;
            this.iconButtonWinMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonWinMax.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonWinMax.ForeColor = System.Drawing.Color.White;
            this.iconButtonWinMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButtonWinMax.IconColor = System.Drawing.Color.White;
            this.iconButtonWinMax.IconSize = 28;
            this.iconButtonWinMax.Location = new System.Drawing.Point(519, 6);
            this.iconButtonWinMax.Name = "iconButtonWinMax";
            this.iconButtonWinMax.Rotation = 0D;
            this.iconButtonWinMax.Size = new System.Drawing.Size(28, 28);
            this.iconButtonWinMax.TabIndex = 3;
            this.iconButtonWinMax.UseVisualStyleBackColor = true;
            this.iconButtonWinMax.Click += new System.EventHandler(this.iconButtonWinMax_Click);
            // 
            // iconButtonWinClose
            // 
            this.iconButtonWinClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonWinClose.FlatAppearance.BorderSize = 0;
            this.iconButtonWinClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonWinClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonWinClose.ForeColor = System.Drawing.Color.White;
            this.iconButtonWinClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButtonWinClose.IconColor = System.Drawing.Color.White;
            this.iconButtonWinClose.IconSize = 28;
            this.iconButtonWinClose.Location = new System.Drawing.Point(553, 6);
            this.iconButtonWinClose.Name = "iconButtonWinClose";
            this.iconButtonWinClose.Rotation = 0D;
            this.iconButtonWinClose.Size = new System.Drawing.Size(28, 28);
            this.iconButtonWinClose.TabIndex = 2;
            this.iconButtonWinClose.UseVisualStyleBackColor = true;
            this.iconButtonWinClose.Click += new System.EventHandler(this.iconButtonWinClose_Click);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonClose.ForeColor = System.Drawing.Color.White;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconSize = 32;
            this.iconButtonClose.Location = new System.Drawing.Point(6, 31);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Rotation = 0D;
            this.iconButtonClose.Size = new System.Drawing.Size(32, 32);
            this.iconButtonClose.TabIndex = 1;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(248, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(73, 27);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.iconButtonLogoHome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(584, 381);
            this.panelDesktop.TabIndex = 2;
            // 
            // iconButtonLogoHome
            // 
            this.iconButtonLogoHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonLogoHome.FlatAppearance.BorderSize = 0;
            this.iconButtonLogoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogoHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonLogoHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonLogoHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonLogoHome.IconChar = FontAwesome.Sharp.IconChar.Cat;
            this.iconButtonLogoHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonLogoHome.IconSize = 180;
            this.iconButtonLogoHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonLogoHome.Location = new System.Drawing.Point(202, 55);
            this.iconButtonLogoHome.MinimumSize = new System.Drawing.Size(120, 120);
            this.iconButtonLogoHome.Name = "iconButtonLogoHome";
            this.iconButtonLogoHome.Rotation = 0D;
            this.iconButtonLogoHome.Size = new System.Drawing.Size(180, 180);
            this.iconButtonLogoHome.TabIndex = 1;
            this.iconButtonLogoHome.Text = "My Logo";
            this.iconButtonLogoHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonLogoHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonLogoHome.UseVisualStyleBackColor = true;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonReporting;
        private FontAwesome.Sharp.IconButton iconButtonCustomers;
        private FontAwesome.Sharp.IconButton iconButtonOrders;
        private FontAwesome.Sharp.IconButton iconButtonProducts;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton iconButtonLogo;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private FontAwesome.Sharp.IconButton iconButtonLogoHome;
        private FontAwesome.Sharp.IconButton iconButtonWinClose;
        private FontAwesome.Sharp.IconButton iconButtonWinMin;
        private FontAwesome.Sharp.IconButton iconButtonWinMax;
    }
}

