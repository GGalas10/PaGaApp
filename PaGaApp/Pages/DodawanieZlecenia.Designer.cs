
namespace PaGaApp.Pages
{
    partial class DodawanieZlecenia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodawanieZlecenia));
            this.KlientBox = new System.Windows.Forms.ComboBox();
            this.CarBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdUslugi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UslugaBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CalBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // KlientBox
            // 
            this.KlientBox.FormattingEnabled = true;
            this.KlientBox.Location = new System.Drawing.Point(64, 14);
            this.KlientBox.Name = "KlientBox";
            this.KlientBox.Size = new System.Drawing.Size(121, 21);
            this.KlientBox.TabIndex = 0;
            this.KlientBox.SelectedIndexChanged += new System.EventHandler(this.KlientBox_SelectedIndexChanged);
            this.KlientBox.TextChanged += new System.EventHandler(this.KlientBox_TextChanged);
            this.KlientBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KlientBox_KeyPress);
            // 
            // CarBox
            // 
            this.CarBox.FormattingEnabled = true;
            this.CarBox.Location = new System.Drawing.Point(291, 14);
            this.CarBox.Name = "CarBox";
            this.CarBox.Size = new System.Drawing.Size(121, 21);
            this.CarBox.TabIndex = 1;
            this.CarBox.Visible = false;
            this.CarBox.SelectedIndexChanged += new System.EventHandler(this.CarBox_SelectedIndexChanged);
            this.CarBox.TextChanged += new System.EventHandler(this.CarBox_TextChanged);
            this.CarBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CarBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(203, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Samochód";
            this.label2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUslugi,
            this.Nazwa,
            this.Cena});
            this.dataGridView1.Location = new System.Drawing.Point(15, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(397, 247);
            this.dataGridView1.TabIndex = 4;
            // 
            // IdUslugi
            // 
            this.IdUslugi.HeaderText = "L.P";
            this.IdUslugi.Name = "IdUslugi";
            this.IdUslugi.ReadOnly = true;
            this.IdUslugi.Width = 40;
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // Cena
            // 
            this.Cena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            this.Cena.ReadOnly = true;
            // 
            // UslugaBtn
            // 
            this.UslugaBtn.FlatAppearance.BorderSize = 0;
            this.UslugaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UslugaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.UslugaBtn.Location = new System.Drawing.Point(15, 82);
            this.UslugaBtn.Name = "UslugaBtn";
            this.UslugaBtn.Size = new System.Drawing.Size(397, 23);
            this.UslugaBtn.TabIndex = 5;
            this.UslugaBtn.Text = "Dodaj usługę";
            this.UslugaBtn.UseVisualStyleBackColor = true;
            this.UslugaBtn.Visible = false;
            this.UslugaBtn.Click += new System.EventHandler(this.UslugaBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddBtn.Location = new System.Drawing.Point(15, 374);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(84, 47);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Dodaj zlecenie";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CalBtn
            // 
            this.CalBtn.FlatAppearance.BorderSize = 0;
            this.CalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CalBtn.Location = new System.Drawing.Point(191, 374);
            this.CalBtn.Name = "CalBtn";
            this.CalBtn.Size = new System.Drawing.Size(84, 47);
            this.CalBtn.TabIndex = 7;
            this.CalBtn.Text = "Wróc";
            this.CalBtn.UseVisualStyleBackColor = true;
            this.CalBtn.Click += new System.EventHandler(this.CalBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(283, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(8, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "\r\n\r\n";
            // 
            // DodawanieZlecenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.UslugaBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarBox);
            this.Controls.Add(this.KlientBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(458, 488);
            this.Name = "DodawanieZlecenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nowe Zlecenie";
            this.Load += new System.EventHandler(this.DodawanieZlecenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox KlientBox;
        private System.Windows.Forms.ComboBox CarBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UslugaBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CalBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUslugi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.Label label3;
    }
}