namespace Working_with_form
{
    partial class MenuManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuManagement));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonProductCatalog = new System.Windows.Forms.Button();
            this.buttonPersonalAccount = new System.Windows.Forms.Button();
            this.buttonMenuManagement = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.Controls.Add(this.buttonProductCatalog, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPersonalAccount, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonMenuManagement, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonExit, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(511, 316);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 212);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // buttonProductCatalog
            // 
            this.buttonProductCatalog.BackColor = System.Drawing.Color.White;
            this.buttonProductCatalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonProductCatalog.FlatAppearance.BorderSize = 0;
            this.buttonProductCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProductCatalog.Location = new System.Drawing.Point(5, 5);
            this.buttonProductCatalog.Margin = new System.Windows.Forms.Padding(5);
            this.buttonProductCatalog.Name = "buttonProductCatalog";
            this.buttonProductCatalog.Size = new System.Drawing.Size(368, 36);
            this.buttonProductCatalog.TabIndex = 6;
            this.buttonProductCatalog.Text = "Каталог товаров";
            this.buttonProductCatalog.UseVisualStyleBackColor = false;
            this.buttonProductCatalog.Click += new System.EventHandler(this.buttonPriceList_Click);
            // 
            // buttonPersonalAccount
            // 
            this.buttonPersonalAccount.BackColor = System.Drawing.Color.White;
            this.buttonPersonalAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPersonalAccount.FlatAppearance.BorderSize = 0;
            this.buttonPersonalAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonalAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPersonalAccount.Location = new System.Drawing.Point(5, 51);
            this.buttonPersonalAccount.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPersonalAccount.Name = "buttonPersonalAccount";
            this.buttonPersonalAccount.Size = new System.Drawing.Size(365, 42);
            this.buttonPersonalAccount.TabIndex = 9;
            this.buttonPersonalAccount.Text = "Личный кабинет";
            this.buttonPersonalAccount.UseVisualStyleBackColor = false;
            this.buttonPersonalAccount.Click += new System.EventHandler(this.buttonPersonalAccount_Click);
            // 
            // buttonMenuManagement
            // 
            this.buttonMenuManagement.BackColor = System.Drawing.Color.White;
            this.buttonMenuManagement.FlatAppearance.BorderSize = 0;
            this.buttonMenuManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuManagement.Location = new System.Drawing.Point(5, 107);
            this.buttonMenuManagement.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMenuManagement.Name = "buttonMenuManagement";
            this.buttonMenuManagement.Size = new System.Drawing.Size(365, 42);
            this.buttonMenuManagement.TabIndex = 7;
            this.buttonMenuManagement.Text = "Управлять товарами";
            this.buttonMenuManagement.UseVisualStyleBackColor = false;
            this.buttonMenuManagement.Click += new System.EventHandler(this.buttonProductCatalog_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(5, 161);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(365, 42);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Working_with_form.Properties.Resources.log;
            this.pictureBox1.Location = new System.Drawing.Point(779, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MenuManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuManagement_FormClosed);
            this.Load += new System.EventHandler(this.MenuManagement_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonPersonalAccount;
        private System.Windows.Forms.Button buttonMenuManagement;
        private System.Windows.Forms.Button buttonProductCatalog;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}