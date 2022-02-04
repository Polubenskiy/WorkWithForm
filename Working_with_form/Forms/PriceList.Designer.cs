namespace Working_with_form
{
    partial class PriceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceList));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonPersonalAccount = new System.Windows.Forms.Button();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.labelSum);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.buttonPersonalAccount);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1149, 63);
            this.panelMenu.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Orange;
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReturn.Location = new System.Drawing.Point(73, 20);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(187, 51);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Каталог товаров";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMain.Controls.Add(this.labelCategoria);
            this.panelMain.Controls.Add(this.buttonReturn);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 63);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1149, 720);
            this.panelMain.TabIndex = 7;
            // 
            // buttonPersonalAccount
            // 
            this.buttonPersonalAccount.BackColor = System.Drawing.Color.Orange;
            this.buttonPersonalAccount.FlatAppearance.BorderSize = 0;
            this.buttonPersonalAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonalAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPersonalAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPersonalAccount.Location = new System.Drawing.Point(956, 5);
            this.buttonPersonalAccount.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPersonalAccount.Name = "buttonPersonalAccount";
            this.buttonPersonalAccount.Size = new System.Drawing.Size(188, 51);
            this.buttonPersonalAccount.TabIndex = 3;
            this.buttonPersonalAccount.Text = "Личный кабинет";
            this.buttonPersonalAccount.UseVisualStyleBackColor = false;
            this.buttonPersonalAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategoria.Location = new System.Drawing.Point(70, 100);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(249, 25);
            this.labelCategoria.TabIndex = 0;
            this.labelCategoria.Text = "Выбранная категория";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(785, 18);
            this.labelSum.Name = "labelSum";
            this.labelSum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSum.Size = new System.Drawing.Size(25, 25);
            this.labelSum.TabIndex = 4;
            this.labelSum.Text = "0";
            this.labelSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1149, 783);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PriceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PriceList";
            this.Load += new System.EventHandler(this.PriceList_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Button buttonPersonalAccount;
        private System.Windows.Forms.Label labelSum;
    }
}