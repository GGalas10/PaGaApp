
namespace PaGaApp
{
    partial class PaGaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaGaMenu));
            this.LeftMenuPanel = new System.Windows.Forms.Panel();
            this.RozsuwaneMenuBtn = new System.Windows.Forms.Button();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.WylogujBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.PagePanel = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UstawieniaBtn = new System.Windows.Forms.Label();
            this.StatystykaBtn = new System.Windows.Forms.Label();
            this.AddAccBtn = new System.Windows.Forms.Label();
            this.KlienciBtn = new System.Windows.Forms.Label();
            this.ZleceniaZamknieteBtn = new System.Windows.Forms.Label();
            this.ZleceniaOtwarteBtn = new System.Windows.Forms.Label();
            this.LeftMenuPanel.SuspendLayout();
            this.UpPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftMenuPanel
            // 
            this.LeftMenuPanel.Controls.Add(this.UstawieniaBtn);
            this.LeftMenuPanel.Controls.Add(this.StatystykaBtn);
            this.LeftMenuPanel.Controls.Add(this.AddAccBtn);
            this.LeftMenuPanel.Controls.Add(this.KlienciBtn);
            this.LeftMenuPanel.Controls.Add(this.ZleceniaZamknieteBtn);
            this.LeftMenuPanel.Controls.Add(this.ZleceniaOtwarteBtn);
            this.LeftMenuPanel.Controls.Add(this.RozsuwaneMenuBtn);
            this.LeftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftMenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftMenuPanel.Name = "LeftMenuPanel";
            this.LeftMenuPanel.Size = new System.Drawing.Size(90, 720);
            this.LeftMenuPanel.TabIndex = 0;
            // 
            // RozsuwaneMenuBtn
            // 
            this.RozsuwaneMenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.RozsuwaneMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RozsuwaneMenuBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.RozsuwaneMenuBtn.FlatAppearance.BorderSize = 0;
            this.RozsuwaneMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RozsuwaneMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.RozsuwaneMenuBtn.Location = new System.Drawing.Point(69, 0);
            this.RozsuwaneMenuBtn.Name = "RozsuwaneMenuBtn";
            this.RozsuwaneMenuBtn.Size = new System.Drawing.Size(21, 720);
            this.RozsuwaneMenuBtn.TabIndex = 0;
            this.RozsuwaneMenuBtn.Text = ">";
            this.RozsuwaneMenuBtn.UseVisualStyleBackColor = false;
            this.RozsuwaneMenuBtn.Click += new System.EventHandler(this.RozsuwaneMenuBtn_Click);
            // 
            // UpPanel
            // 
            this.UpPanel.Controls.Add(this.WylogujBtn);
            this.UpPanel.Controls.Add(this.MinBtn);
            this.UpPanel.Controls.Add(this.MaxBtn);
            this.UpPanel.Controls.Add(this.ExitBtn);
            this.UpPanel.Controls.Add(this.TitleLabel);
            this.UpPanel.Controls.Add(this.LogoPanel);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(90, 0);
            this.UpPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(1190, 108);
            this.UpPanel.TabIndex = 0;
            this.UpPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpPanel_MouseDown);
            // 
            // WylogujBtn
            // 
            this.WylogujBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WylogujBtn.AutoSize = true;
            this.WylogujBtn.FlatAppearance.BorderSize = 0;
            this.WylogujBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WylogujBtn.ForeColor = System.Drawing.Color.White;
            this.WylogujBtn.Location = new System.Drawing.Point(1119, 32);
            this.WylogujBtn.Name = "WylogujBtn";
            this.WylogujBtn.Size = new System.Drawing.Size(55, 23);
            this.WylogujBtn.TabIndex = 5;
            this.WylogujBtn.Text = "Wyloguj";
            this.WylogujBtn.UseVisualStyleBackColor = true;
            this.WylogujBtn.Click += new System.EventHandler(this.WylogujBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.TitleLabel.Location = new System.Drawing.Point(518, 37);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(138, 48);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Home";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(200, 108);
            this.LogoPanel.TabIndex = 0;
            // 
            // PagePanel
            // 
            this.PagePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PagePanel.BackColor = System.Drawing.Color.Transparent;
            this.PagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagePanel.Location = new System.Drawing.Point(90, 108);
            this.PagePanel.Margin = new System.Windows.Forms.Padding(0);
            this.PagePanel.Name = "PagePanel";
            this.PagePanel.Size = new System.Drawing.Size(1190, 612);
            this.PagePanel.TabIndex = 1;
            // 
            // MinBtn
            // 
            this.MinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinBtn.AutoSize = true;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.Image = global::PaGaApp.Properties.Resources.minimize;
            this.MinBtn.Location = new System.Drawing.Point(1103, 3);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(24, 24);
            this.MinBtn.TabIndex = 4;
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxBtn.AutoSize = true;
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.ForeColor = System.Drawing.Color.White;
            this.MaxBtn.Image = global::PaGaApp.Properties.Resources.Maximize;
            this.MaxBtn.Location = new System.Drawing.Point(1133, 3);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(24, 24);
            this.MaxBtn.TabIndex = 3;
            this.MaxBtn.UseVisualStyleBackColor = true;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Image = global::PaGaApp.Properties.Resources.Exit;
            this.ExitBtn.Location = new System.Drawing.Point(1163, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(24, 24);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PaGaApp.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(200, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UstawieniaBtn
            // 
            this.UstawieniaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.UstawieniaBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UstawieniaBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.UstawieniaBtn.Image = global::PaGaApp.Properties.Resources.Ustawienia;
            this.UstawieniaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UstawieniaBtn.Location = new System.Drawing.Point(0, 340);
            this.UstawieniaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.UstawieniaBtn.Name = "UstawieniaBtn";
            this.UstawieniaBtn.Padding = new System.Windows.Forms.Padding(5);
            this.UstawieniaBtn.Size = new System.Drawing.Size(69, 85);
            this.UstawieniaBtn.TabIndex = 6;
            this.UstawieniaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UstawieniaBtn.Click += new System.EventHandler(this.btn_Click);
            this.UstawieniaBtn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.UstawieniaBtn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // StatystykaBtn
            // 
            this.StatystykaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatystykaBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatystykaBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.StatystykaBtn.Image = global::PaGaApp.Properties.Resources.Statystyka;
            this.StatystykaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StatystykaBtn.Location = new System.Drawing.Point(0, 255);
            this.StatystykaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.StatystykaBtn.Name = "StatystykaBtn";
            this.StatystykaBtn.Padding = new System.Windows.Forms.Padding(5);
            this.StatystykaBtn.Size = new System.Drawing.Size(69, 85);
            this.StatystykaBtn.TabIndex = 5;
            this.StatystykaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatystykaBtn.Click += new System.EventHandler(this.btn_Click);
            this.StatystykaBtn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.StatystykaBtn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // AddAccBtn
            // 
            this.AddAccBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddAccBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAccBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.AddAccBtn.Image = global::PaGaApp.Properties.Resources.admin;
            this.AddAccBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddAccBtn.Location = new System.Drawing.Point(0, 635);
            this.AddAccBtn.Margin = new System.Windows.Forms.Padding(5);
            this.AddAccBtn.Name = "AddAccBtn";
            this.AddAccBtn.Padding = new System.Windows.Forms.Padding(5);
            this.AddAccBtn.Size = new System.Drawing.Size(69, 85);
            this.AddAccBtn.TabIndex = 4;
            this.AddAccBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddAccBtn.Click += new System.EventHandler(this.btn_Click);
            this.AddAccBtn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.AddAccBtn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // KlienciBtn
            // 
            this.KlienciBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.KlienciBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KlienciBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.KlienciBtn.Image = global::PaGaApp.Properties.Resources.Klienci;
            this.KlienciBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KlienciBtn.Location = new System.Drawing.Point(0, 170);
            this.KlienciBtn.Margin = new System.Windows.Forms.Padding(5);
            this.KlienciBtn.Name = "KlienciBtn";
            this.KlienciBtn.Padding = new System.Windows.Forms.Padding(5);
            this.KlienciBtn.Size = new System.Drawing.Size(69, 85);
            this.KlienciBtn.TabIndex = 3;
            this.KlienciBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KlienciBtn.Click += new System.EventHandler(this.btn_Click);
            this.KlienciBtn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.KlienciBtn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // ZleceniaZamknieteBtn
            // 
            this.ZleceniaZamknieteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ZleceniaZamknieteBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZleceniaZamknieteBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ZleceniaZamknieteBtn.Image = global::PaGaApp.Properties.Resources.ZleceniaZrobione;
            this.ZleceniaZamknieteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ZleceniaZamknieteBtn.Location = new System.Drawing.Point(0, 85);
            this.ZleceniaZamknieteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ZleceniaZamknieteBtn.Name = "ZleceniaZamknieteBtn";
            this.ZleceniaZamknieteBtn.Padding = new System.Windows.Forms.Padding(5);
            this.ZleceniaZamknieteBtn.Size = new System.Drawing.Size(69, 85);
            this.ZleceniaZamknieteBtn.TabIndex = 2;
            this.ZleceniaZamknieteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ZleceniaZamknieteBtn.Click += new System.EventHandler(this.btn_Click);
            this.ZleceniaZamknieteBtn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.ZleceniaZamknieteBtn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // ZleceniaOtwarteBtn
            // 
            this.ZleceniaOtwarteBtn.BackColor = System.Drawing.Color.Transparent;
            this.ZleceniaOtwarteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ZleceniaOtwarteBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZleceniaOtwarteBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ZleceniaOtwarteBtn.Image = global::PaGaApp.Properties.Resources.ZleceniaDoZrobienia;
            this.ZleceniaOtwarteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ZleceniaOtwarteBtn.Location = new System.Drawing.Point(0, 0);
            this.ZleceniaOtwarteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ZleceniaOtwarteBtn.Name = "ZleceniaOtwarteBtn";
            this.ZleceniaOtwarteBtn.Padding = new System.Windows.Forms.Padding(5);
            this.ZleceniaOtwarteBtn.Size = new System.Drawing.Size(69, 85);
            this.ZleceniaOtwarteBtn.TabIndex = 1;
            this.ZleceniaOtwarteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ZleceniaOtwarteBtn.Click += new System.EventHandler(this.btn_Click);
            this.ZleceniaOtwarteBtn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.ZleceniaOtwarteBtn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // PaGaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.PagePanel);
            this.Controls.Add(this.UpPanel);
            this.Controls.Add(this.LeftMenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "PaGaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.LeftMenuPanel.ResumeLayout(false);
            this.UpPanel.ResumeLayout(false);
            this.UpPanel.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftMenuPanel;
        private System.Windows.Forms.Button RozsuwaneMenuBtn;
        private System.Windows.Forms.Label UstawieniaBtn;
        private System.Windows.Forms.Label StatystykaBtn;
        private System.Windows.Forms.Label AddAccBtn;
        private System.Windows.Forms.Label KlienciBtn;
        private System.Windows.Forms.Label ZleceniaZamknieteBtn;
        private System.Windows.Forms.Label ZleceniaOtwarteBtn;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel PagePanel;
        private System.Windows.Forms.Button WylogujBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}