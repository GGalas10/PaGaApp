
namespace PaGaApp.Pages
{
    partial class KlientPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KlientPage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PanelWyszukiwania = new System.Windows.Forms.Panel();
            this.WyszukiwanieBtn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DaneStrip = new System.Windows.Forms.MenuStrip();
            this.IdKlienta = new System.Windows.Forms.ToolStripMenuItem();
            this.Imie = new System.Windows.Forms.ToolStripMenuItem();
            this.Nazwisko = new System.Windows.Forms.ToolStripMenuItem();
            this.NumerTelefonu = new System.Windows.Forms.ToolStripMenuItem();
            this.GornyPanel = new System.Windows.Forms.Panel();
            this.DelBtn = new System.Windows.Forms.Button();
            this.CountLbl = new System.Windows.Forms.Label();
            this.OpcjeBtn = new System.Windows.Forms.Button();
            this.AddKlient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelWyszukiwania.SuspendLayout();
            this.DaneStrip.SuspendLayout();
            this.GornyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 521);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // PanelWyszukiwania
            // 
            this.PanelWyszukiwania.Controls.Add(this.WyszukiwanieBtn);
            this.PanelWyszukiwania.Controls.Add(this.label3);
            this.PanelWyszukiwania.Controls.Add(this.textBox1);
            this.PanelWyszukiwania.Controls.Add(this.DaneStrip);
            this.PanelWyszukiwania.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelWyszukiwania.Location = new System.Drawing.Point(0, 40);
            this.PanelWyszukiwania.Name = "PanelWyszukiwania";
            this.PanelWyszukiwania.Size = new System.Drawing.Size(1174, 52);
            this.PanelWyszukiwania.TabIndex = 11;
            this.PanelWyszukiwania.Visible = false;
            // 
            // WyszukiwanieBtn
            // 
            this.WyszukiwanieBtn.AutoSize = true;
            this.WyszukiwanieBtn.Location = new System.Drawing.Point(114, 3);
            this.WyszukiwanieBtn.Name = "WyszukiwanieBtn";
            this.WyszukiwanieBtn.Size = new System.Drawing.Size(33, 13);
            this.WyszukiwanieBtn.TabIndex = 7;
            this.WyszukiwanieBtn.Text = "Dane";
            this.WyszukiwanieBtn.Click += new System.EventHandler(this.WyszukiwanieBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wyszukiwanie: ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(13, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1150, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // DaneStrip
            // 
            this.DaneStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.DaneStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IdKlienta,
            this.Imie,
            this.Nazwisko,
            this.NumerTelefonu});
            this.DaneStrip.Location = new System.Drawing.Point(177, 0);
            this.DaneStrip.Name = "DaneStrip";
            this.DaneStrip.Size = new System.Drawing.Size(291, 24);
            this.DaneStrip.TabIndex = 8;
            this.DaneStrip.Text = "menuStrip1";
            this.DaneStrip.Visible = false;
            this.DaneStrip.MenuDeactivate += new System.EventHandler(this.DaneStrip_MenuDeactivate);
            this.DaneStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.DaneStrip_ItemClicked);
            // 
            // IdKlienta
            // 
            this.IdKlienta.Name = "IdKlienta";
            this.IdKlienta.Size = new System.Drawing.Size(68, 20);
            this.IdKlienta.Text = "Id Klienta";
            // 
            // Imie
            // 
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(42, 20);
            this.Imie.Text = "Imie";
            // 
            // Nazwisko
            // 
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(69, 20);
            this.Nazwisko.Text = "Nazwisko";
            // 
            // NumerTelefonu
            // 
            this.NumerTelefonu.Name = "NumerTelefonu";
            this.NumerTelefonu.Size = new System.Drawing.Size(104, 20);
            this.NumerTelefonu.Text = "Numer Telefonu";
            // 
            // GornyPanel
            // 
            this.GornyPanel.Controls.Add(this.DelBtn);
            this.GornyPanel.Controls.Add(this.CountLbl);
            this.GornyPanel.Controls.Add(this.OpcjeBtn);
            this.GornyPanel.Controls.Add(this.AddKlient);
            this.GornyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GornyPanel.Location = new System.Drawing.Point(0, 0);
            this.GornyPanel.Name = "GornyPanel";
            this.GornyPanel.Size = new System.Drawing.Size(1174, 40);
            this.GornyPanel.TabIndex = 10;
            // 
            // DelBtn
            // 
            this.DelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelBtn.FlatAppearance.BorderSize = 0;
            this.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelBtn.Image = global::PaGaApp.Properties.Resources.minidel;
            this.DelBtn.Location = new System.Drawing.Point(882, 11);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(16, 16);
            this.DelBtn.TabIndex = 16;
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // CountLbl
            // 
            this.CountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CountLbl.AutoSize = true;
            this.CountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.CountLbl.Location = new System.Drawing.Point(1023, 13);
            this.CountLbl.Name = "CountLbl";
            this.CountLbl.Size = new System.Drawing.Size(89, 13);
            this.CountLbl.TabIndex = 16;
            this.CountLbl.Text = "Ilość klientów:";
            // 
            // OpcjeBtn
            // 
            this.OpcjeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcjeBtn.FlatAppearance.BorderSize = 0;
            this.OpcjeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpcjeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpcjeBtn.Location = new System.Drawing.Point(904, 8);
            this.OpcjeBtn.Name = "OpcjeBtn";
            this.OpcjeBtn.Size = new System.Drawing.Size(100, 23);
            this.OpcjeBtn.TabIndex = 15;
            this.OpcjeBtn.Text = "Wybór kolumn";
            this.OpcjeBtn.UseVisualStyleBackColor = true;
            this.OpcjeBtn.Click += new System.EventHandler(this.OpcjeBtn_Click);
            // 
            // AddKlient
            // 
            this.AddKlient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddKlient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddKlient.Location = new System.Drawing.Point(13, 3);
            this.AddKlient.Name = "AddKlient";
            this.AddKlient.Size = new System.Drawing.Size(106, 23);
            this.AddKlient.TabIndex = 11;
            this.AddKlient.Text = "Dodaj klienta";
            this.AddKlient.UseVisualStyleBackColor = true;
            this.AddKlient.Click += new System.EventHandler(this.AddKlient_Click);
            // 
            // KlientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1174, 573);
            this.Controls.Add(this.PanelWyszukiwania);
            this.Controls.Add(this.GornyPanel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "KlientPage";
            this.Text = "KlientPage";
            this.Load += new System.EventHandler(this.KlientPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KlientPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelWyszukiwania.ResumeLayout(false);
            this.PanelWyszukiwania.PerformLayout();
            this.DaneStrip.ResumeLayout(false);
            this.DaneStrip.PerformLayout();
            this.GornyPanel.ResumeLayout(false);
            this.GornyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel PanelWyszukiwania;
        private System.Windows.Forms.Label WyszukiwanieBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip DaneStrip;
        private System.Windows.Forms.Panel GornyPanel;
        private System.Windows.Forms.Button AddKlient;
        private System.Windows.Forms.ToolStripMenuItem IdKlienta;
        private System.Windows.Forms.ToolStripMenuItem Imie;
        private System.Windows.Forms.ToolStripMenuItem Nazwisko;
        private System.Windows.Forms.ToolStripMenuItem NumerTelefonu;
        private System.Windows.Forms.Label CountLbl;
        private System.Windows.Forms.Button OpcjeBtn;
        private System.Windows.Forms.Button DelBtn;
    }
}