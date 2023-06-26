
namespace PaGaApp.Pages
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.DelBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddKatBtn = new System.Windows.Forms.Button();
            this.LogiBtn = new System.Windows.Forms.Button();
            this.UzyBtn = new System.Windows.Forms.Button();
            this.KatBtn = new System.Windows.Forms.Button();
            this.AddPracBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 0);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(230, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(932, 520);
            this.dataGridView1.TabIndex = 7;
            // 
            // TitleLbl
            // 
            this.TitleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLbl.Location = new System.Drawing.Point(657, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(117, 20);
            this.TitleLbl.TabIndex = 8;
            this.TitleLbl.Text = "Wybierz dane";
            // 
            // DelBtn
            // 
            this.DelBtn.FlatAppearance.BorderSize = 0;
            this.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.DelBtn.Image = global::PaGaApp.Properties.Resources.del;
            this.DelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DelBtn.Location = new System.Drawing.Point(4, 504);
            this.DelBtn.MinimumSize = new System.Drawing.Size(158, 57);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(158, 57);
            this.DelBtn.TabIndex = 14;
            this.DelBtn.TabStop = false;
            this.DelBtn.Text = "Usuń wybrane";
            this.DelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Visible = false;
            this.DelBtn.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PaGaApp.Properties.Resources.Pasek;
            this.pictureBox1.Location = new System.Drawing.Point(4, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 5);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // AddKatBtn
            // 
            this.AddKatBtn.FlatAppearance.BorderSize = 0;
            this.AddKatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddKatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.AddKatBtn.Image = global::PaGaApp.Properties.Resources.Kat;
            this.AddKatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddKatBtn.Location = new System.Drawing.Point(12, 311);
            this.AddKatBtn.Name = "AddKatBtn";
            this.AddKatBtn.Size = new System.Drawing.Size(150, 67);
            this.AddKatBtn.TabIndex = 5;
            this.AddKatBtn.Text = "Dodawania\r\nkategorii";
            this.AddKatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddKatBtn.UseVisualStyleBackColor = true;
            this.AddKatBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // LogiBtn
            // 
            this.LogiBtn.FlatAppearance.BorderSize = 0;
            this.LogiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.LogiBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogiBtn.Image")));
            this.LogiBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogiBtn.Location = new System.Drawing.Point(12, 165);
            this.LogiBtn.Name = "LogiBtn";
            this.LogiBtn.Size = new System.Drawing.Size(150, 45);
            this.LogiBtn.TabIndex = 3;
            this.LogiBtn.Text = "Logi";
            this.LogiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogiBtn.UseVisualStyleBackColor = true;
            this.LogiBtn.Click += new System.EventHandler(this.LogiBtn_Click);
            // 
            // UzyBtn
            // 
            this.UzyBtn.FlatAppearance.BorderSize = 0;
            this.UzyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UzyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.UzyBtn.Image = global::PaGaApp.Properties.Resources.emp;
            this.UzyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UzyBtn.Location = new System.Drawing.Point(12, 101);
            this.UzyBtn.Name = "UzyBtn";
            this.UzyBtn.Size = new System.Drawing.Size(150, 45);
            this.UzyBtn.TabIndex = 2;
            this.UzyBtn.Text = "Użytkownicy";
            this.UzyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UzyBtn.UseVisualStyleBackColor = true;
            this.UzyBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // KatBtn
            // 
            this.KatBtn.FlatAppearance.BorderSize = 0;
            this.KatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.KatBtn.Image = global::PaGaApp.Properties.Resources.Katakt;
            this.KatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KatBtn.Location = new System.Drawing.Point(12, 41);
            this.KatBtn.Name = "KatBtn";
            this.KatBtn.Size = new System.Drawing.Size(150, 45);
            this.KatBtn.TabIndex = 1;
            this.KatBtn.Text = "Kategorie";
            this.KatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KatBtn.UseVisualStyleBackColor = true;
            this.KatBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddPracBtn
            // 
            this.AddPracBtn.FlatAppearance.BorderSize = 0;
            this.AddPracBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPracBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.AddPracBtn.Image = global::PaGaApp.Properties.Resources.NowyPracownik;
            this.AddPracBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPracBtn.Location = new System.Drawing.Point(12, 238);
            this.AddPracBtn.Name = "AddPracBtn";
            this.AddPracBtn.Size = new System.Drawing.Size(150, 67);
            this.AddPracBtn.TabIndex = 4;
            this.AddPracBtn.Text = "Dodawanie użytkownika";
            this.AddPracBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddPracBtn.UseVisualStyleBackColor = true;
            this.AddPracBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1174, 573);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddKatBtn);
            this.Controls.Add(this.LogiBtn);
            this.Controls.Add(this.UzyBtn);
            this.Controls.Add(this.KatBtn);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddPracBtn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPage";
            this.Text = "PaGaForm";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddPracBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button KatBtn;
        private System.Windows.Forms.Button UzyBtn;
        private System.Windows.Forms.Button LogiBtn;
        private System.Windows.Forms.Button AddKatBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DelBtn;
    }
}