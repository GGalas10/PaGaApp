
namespace PaGaApp.Pages
{
    partial class ZleceniaOtwartePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZleceniaOtwartePage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OpcjeBtn = new System.Windows.Forms.Button();
            this.GornyPanel = new System.Windows.Forms.Panel();
            this.DelBtn = new System.Windows.Forms.Button();
            this.CountLbl = new System.Windows.Forms.Label();
            this.Addzlecenie = new System.Windows.Forms.Button();
            this.DataStrip = new System.Windows.Forms.MenuStrip();
            this.dzis = new System.Windows.Forms.ToolStripMenuItem();
            this.tydzien = new System.Windows.Forms.ToolStripMenuItem();
            this.miesiac = new System.Windows.Forms.ToolStripMenuItem();
            this.rok = new System.Windows.Forms.ToolStripMenuItem();
            this.dowolny = new System.Windows.Forms.ToolStripMenuItem();
            this.brakDatyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.DataBtn = new System.Windows.Forms.Label();
            this.PanelWyszukiwania = new System.Windows.Forms.Panel();
            this.WyszukiwanieBtn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DaneStrip = new System.Windows.Forms.MenuStrip();
            this.IdZlecenia = new System.Windows.Forms.ToolStripMenuItem();
            this.DaneKlienta = new System.Windows.Forms.ToolStripMenuItem();
            this.MarkaSamochodu = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelSamochodu = new System.Windows.Forms.ToolStripMenuItem();
            this.NrRejestracyjny = new System.Windows.Forms.ToolStripMenuItem();
            this.NrVIN = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPrzyjęciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GornyPanel.SuspendLayout();
            this.DataStrip.SuspendLayout();
            this.PanelWyszukiwania.SuspendLayout();
            this.DaneStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
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
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
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
            this.OpcjeBtn.TabIndex = 7;
            this.OpcjeBtn.Text = "Wybór kolumn";
            this.OpcjeBtn.UseVisualStyleBackColor = true;
            this.OpcjeBtn.Click += new System.EventHandler(this.OpcjeBtn_Click);
            // 
            // GornyPanel
            // 
            this.GornyPanel.Controls.Add(this.DelBtn);
            this.GornyPanel.Controls.Add(this.CountLbl);
            this.GornyPanel.Controls.Add(this.Addzlecenie);
            this.GornyPanel.Controls.Add(this.DataStrip);
            this.GornyPanel.Controls.Add(this.label2);
            this.GornyPanel.Controls.Add(this.DataBtn);
            this.GornyPanel.Controls.Add(this.OpcjeBtn);
            this.GornyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GornyPanel.Location = new System.Drawing.Point(0, 0);
            this.GornyPanel.Name = "GornyPanel";
            this.GornyPanel.Size = new System.Drawing.Size(1174, 40);
            this.GornyPanel.TabIndex = 8;
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
            this.CountLbl.Size = new System.Drawing.Size(79, 13);
            this.CountLbl.TabIndex = 12;
            this.CountLbl.Text = "Ilość zleceń:";
            // 
            // Addzlecenie
            // 
            this.Addzlecenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addzlecenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Addzlecenie.Location = new System.Drawing.Point(12, 8);
            this.Addzlecenie.Name = "Addzlecenie";
            this.Addzlecenie.Size = new System.Drawing.Size(106, 23);
            this.Addzlecenie.TabIndex = 11;
            this.Addzlecenie.Text = "Dodaj zlecenie";
            this.Addzlecenie.UseVisualStyleBackColor = true;
            this.Addzlecenie.Click += new System.EventHandler(this.Addzlecenie_Click);
            // 
            // DataStrip
            // 
            this.DataStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.DataStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dzis,
            this.tydzien,
            this.miesiac,
            this.rok,
            this.dowolny,
            this.brakDatyToolStripMenuItem});
            this.DataStrip.Location = new System.Drawing.Point(237, 9);
            this.DataStrip.Name = "DataStrip";
            this.DataStrip.Size = new System.Drawing.Size(551, 24);
            this.DataStrip.TabIndex = 10;
            this.DataStrip.Text = "menuStrip1";
            this.DataStrip.Visible = false;
            this.DataStrip.MenuDeactivate += new System.EventHandler(this.DataStrip_MenuDeactivate);
            this.DataStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.DataStrip_ItemClicked);
            // 
            // dzis
            // 
            this.dzis.Name = "dzis";
            this.dzis.Size = new System.Drawing.Size(93, 20);
            this.dzis.Text = "Bierzący dzień";
            // 
            // tydzien
            // 
            this.tydzien.Name = "tydzien";
            this.tydzien.Size = new System.Drawing.Size(103, 20);
            this.tydzien.Text = "Bierzący tydzień";
            // 
            // miesiac
            // 
            this.miesiac.Name = "miesiac";
            this.miesiac.Size = new System.Drawing.Size(105, 20);
            this.miesiac.Text = "Bierzący miesiąc";
            // 
            // rok
            // 
            this.rok.Name = "rok";
            this.rok.Size = new System.Drawing.Size(82, 20);
            this.rok.Text = "Bierzący rok";
            // 
            // dowolny
            // 
            this.dowolny.Name = "dowolny";
            this.dowolny.Size = new System.Drawing.Size(92, 20);
            this.dowolny.Text = "Dowolna data";
            // 
            // brakDatyToolStripMenuItem
            // 
            this.brakDatyToolStripMenuItem.Name = "brakDatyToolStripMenuItem";
            this.brakDatyToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.brakDatyToolStripMenuItem.Text = "Brak daty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(124, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filtrowanie:";
            // 
            // DataBtn
            // 
            this.DataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataBtn.AutoSize = true;
            this.DataBtn.Location = new System.Drawing.Point(202, 13);
            this.DataBtn.Name = "DataBtn";
            this.DataBtn.Size = new System.Drawing.Size(30, 13);
            this.DataBtn.TabIndex = 6;
            this.DataBtn.Text = "Data";
            this.DataBtn.Click += new System.EventHandler(this.DataBtn_Click);
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
            this.PanelWyszukiwania.TabIndex = 9;
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
            // DaneStrip
            // 
            this.DaneStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.DaneStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IdZlecenia,
            this.DaneKlienta,
            this.MarkaSamochodu,
            this.ModelSamochodu,
            this.NrRejestracyjny,
            this.NrVIN,
            this.dataPrzyjęciaToolStripMenuItem});
            this.DaneStrip.Location = new System.Drawing.Point(177, 0);
            this.DaneStrip.Name = "DaneStrip";
            this.DaneStrip.Size = new System.Drawing.Size(702, 24);
            this.DaneStrip.TabIndex = 8;
            this.DaneStrip.Text = "menuStrip1";
            this.DaneStrip.Visible = false;
            this.DaneStrip.MenuDeactivate += new System.EventHandler(this.DaneStrip_MenuDeactivate);
            this.DaneStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.DaneStrip_ItemClicked);
            // 
            // IdZlecenia
            // 
            this.IdZlecenia.Name = "IdZlecenia";
            this.IdZlecenia.Size = new System.Drawing.Size(76, 20);
            this.IdZlecenia.Text = "Id Zlecenia";
            // 
            // DaneKlienta
            // 
            this.DaneKlienta.Name = "DaneKlienta";
            this.DaneKlienta.Size = new System.Drawing.Size(84, 20);
            this.DaneKlienta.Text = "Dane klienta";
            // 
            // MarkaSamochodu
            // 
            this.MarkaSamochodu.Name = "MarkaSamochodu";
            this.MarkaSamochodu.Size = new System.Drawing.Size(118, 20);
            this.MarkaSamochodu.Text = "Marka samochodu";
            // 
            // ModelSamochodu
            // 
            this.ModelSamochodu.Name = "ModelSamochodu";
            this.ModelSamochodu.Size = new System.Drawing.Size(120, 20);
            this.ModelSamochodu.Text = "Model Samochodu";
            // 
            // NrRejestracyjny
            // 
            this.NrRejestracyjny.Name = "NrRejestracyjny";
            this.NrRejestracyjny.Size = new System.Drawing.Size(128, 20);
            this.NrRejestracyjny.Text = "Numer Rejestracyjny";
            // 
            // NrVIN
            // 
            this.NrVIN.Name = "NrVIN";
            this.NrVIN.Size = new System.Drawing.Size(76, 20);
            this.NrVIN.Text = "Numer Vin";
            // 
            // dataPrzyjęciaToolStripMenuItem
            // 
            this.dataPrzyjęciaToolStripMenuItem.Name = "dataPrzyjęciaToolStripMenuItem";
            this.dataPrzyjęciaToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.dataPrzyjęciaToolStripMenuItem.Text = "Data przyjęcia";
            // 
            // ZleceniaOtwartePage
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
            this.MainMenuStrip = this.DataStrip;
            this.Name = "ZleceniaOtwartePage";
            this.Text = "ZleceniaZmaknietePage";
            this.Load += new System.EventHandler(this.ZleceniaOtwartePage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ZleceniaOtwartePage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GornyPanel.ResumeLayout(false);
            this.GornyPanel.PerformLayout();
            this.DataStrip.ResumeLayout(false);
            this.DataStrip.PerformLayout();
            this.PanelWyszukiwania.ResumeLayout(false);
            this.PanelWyszukiwania.PerformLayout();
            this.DaneStrip.ResumeLayout(false);
            this.DaneStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OpcjeBtn;
        private System.Windows.Forms.Panel GornyPanel;
        private System.Windows.Forms.Panel PanelWyszukiwania;
        private System.Windows.Forms.Label DataBtn;
        private System.Windows.Forms.MenuStrip DataStrip;
        private System.Windows.Forms.ToolStripMenuItem dzis;
        private System.Windows.Forms.ToolStripMenuItem tydzien;
        private System.Windows.Forms.ToolStripMenuItem miesiac;
        private System.Windows.Forms.ToolStripMenuItem rok;
        private System.Windows.Forms.ToolStripMenuItem dowolny;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WyszukiwanieBtn;
        private System.Windows.Forms.MenuStrip DaneStrip;
        private System.Windows.Forms.ToolStripMenuItem IdZlecenia;
        private System.Windows.Forms.ToolStripMenuItem DaneKlienta;
        private System.Windows.Forms.ToolStripMenuItem MarkaSamochodu;
        private System.Windows.Forms.ToolStripMenuItem ModelSamochodu;
        private System.Windows.Forms.ToolStripMenuItem NrRejestracyjny;
        private System.Windows.Forms.ToolStripMenuItem NrVIN;
        private System.Windows.Forms.Button Addzlecenie;
        private System.Windows.Forms.Label CountLbl;
        private System.Windows.Forms.ToolStripMenuItem dataPrzyjęciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brakDatyToolStripMenuItem;
        private System.Windows.Forms.Button DelBtn;
    }
}