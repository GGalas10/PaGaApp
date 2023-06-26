
namespace PaGaApp.Pages
{
    partial class StatystykaPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatystykaPage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Diagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ZlecBtn = new System.Windows.Forms.Button();
            this.KatBtn = new System.Windows.Forms.Button();
            this.ZlecMSBtn = new System.Windows.Forms.Button();
            this.ZlecRBtn = new System.Windows.Forms.Button();
            this.AllZlecBtn = new System.Windows.Forms.Button();
            this.Zlec3mBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ZlecWybBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WybOtwBtn = new System.Windows.Forms.Button();
            this.WszOtwBtn = new System.Windows.Forms.Button();
            this.MsOtwBtn = new System.Windows.Forms.Button();
            this.Ms3OtwBtn = new System.Windows.Forms.Button();
            this.ToOtwBtn = new System.Windows.Forms.Button();
            this.ROtwBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Diagram)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // Diagram
            // 
            this.Diagram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Diagram.BackColor = System.Drawing.Color.DarkGray;
            this.Diagram.BorderlineColor = System.Drawing.Color.DarkGray;
            this.Diagram.BorderSkin.PageColor = System.Drawing.Color.DarkGray;
            chartArea1.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.Diagram.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.DarkGray;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.Diagram.Legends.Add(legend1);
            this.Diagram.Location = new System.Drawing.Point(333, 12);
            this.Diagram.Name = "Diagram";
            this.Diagram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.Diagram.Size = new System.Drawing.Size(829, 549);
            this.Diagram.TabIndex = 2;
            this.Diagram.Text = "chart1";
            // 
            // ZlecBtn
            // 
            this.ZlecBtn.FlatAppearance.BorderSize = 0;
            this.ZlecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZlecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ZlecBtn.Location = new System.Drawing.Point(6, 50);
            this.ZlecBtn.Name = "ZlecBtn";
            this.ZlecBtn.Size = new System.Drawing.Size(289, 35);
            this.ZlecBtn.TabIndex = 3;
            this.ZlecBtn.Text = "Zlecenia dzień bieżący";
            this.ZlecBtn.UseVisualStyleBackColor = true;
            this.ZlecBtn.Click += new System.EventHandler(this.ZlecBtn_Click);
            // 
            // KatBtn
            // 
            this.KatBtn.FlatAppearance.BorderSize = 0;
            this.KatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.KatBtn.Location = new System.Drawing.Point(3, 41);
            this.KatBtn.Name = "KatBtn";
            this.KatBtn.Size = new System.Drawing.Size(289, 41);
            this.KatBtn.TabIndex = 4;
            this.KatBtn.Text = "Procentowy udział w sprzedaży";
            this.KatBtn.UseVisualStyleBackColor = true;
            this.KatBtn.Click += new System.EventHandler(this.KatBtn_Click);
            // 
            // ZlecMSBtn
            // 
            this.ZlecMSBtn.FlatAppearance.BorderSize = 0;
            this.ZlecMSBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZlecMSBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ZlecMSBtn.Location = new System.Drawing.Point(6, 91);
            this.ZlecMSBtn.Name = "ZlecMSBtn";
            this.ZlecMSBtn.Size = new System.Drawing.Size(289, 37);
            this.ZlecMSBtn.TabIndex = 6;
            this.ZlecMSBtn.Text = "Zlecenia bieżący miesiąc";
            this.ZlecMSBtn.UseVisualStyleBackColor = true;
            this.ZlecMSBtn.Click += new System.EventHandler(this.ZlecMSBtn_Click);
            // 
            // ZlecRBtn
            // 
            this.ZlecRBtn.FlatAppearance.BorderSize = 0;
            this.ZlecRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZlecRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ZlecRBtn.Location = new System.Drawing.Point(6, 178);
            this.ZlecRBtn.Name = "ZlecRBtn";
            this.ZlecRBtn.Size = new System.Drawing.Size(289, 38);
            this.ZlecRBtn.TabIndex = 7;
            this.ZlecRBtn.Text = "Zlecenia bieżący rok";
            this.ZlecRBtn.UseVisualStyleBackColor = true;
            this.ZlecRBtn.Click += new System.EventHandler(this.ZlecRBtn_Click);
            // 
            // AllZlecBtn
            // 
            this.AllZlecBtn.FlatAppearance.BorderSize = 0;
            this.AllZlecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllZlecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.AllZlecBtn.Location = new System.Drawing.Point(6, 6);
            this.AllZlecBtn.Name = "AllZlecBtn";
            this.AllZlecBtn.Size = new System.Drawing.Size(289, 38);
            this.AllZlecBtn.TabIndex = 10;
            this.AllZlecBtn.Text = "Wszystkie zlecenia";
            this.AllZlecBtn.UseVisualStyleBackColor = true;
            this.AllZlecBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zlec3mBtn
            // 
            this.Zlec3mBtn.FlatAppearance.BorderSize = 0;
            this.Zlec3mBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zlec3mBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Zlec3mBtn.Location = new System.Drawing.Point(6, 134);
            this.Zlec3mBtn.Name = "Zlec3mBtn";
            this.Zlec3mBtn.Size = new System.Drawing.Size(289, 38);
            this.Zlec3mBtn.TabIndex = 9;
            this.Zlec3mBtn.Text = "Zlecenia z 3 miesięcy";
            this.Zlec3mBtn.UseVisualStyleBackColor = true;
            this.Zlec3mBtn.Click += new System.EventHandler(this.Zlec3mBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.KatBtn);
            this.panel3.Location = new System.Drawing.Point(25, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 157);
            this.panel3.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(3, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 41);
            this.button2.TabIndex = 10;
            this.button2.Text = "Ilość usług w kategoriach";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(103, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kategorie";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(315, 298);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.ZlecWybBtn);
            this.tabPage1.Controls.Add(this.AllZlecBtn);
            this.tabPage1.Controls.Add(this.Zlec3mBtn);
            this.tabPage1.Controls.Add(this.ZlecBtn);
            this.tabPage1.Controls.Add(this.ZlecRBtn);
            this.tabPage1.Controls.Add(this.ZlecMSBtn);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(307, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zlecenia zamknięte";
            // 
            // ZlecWybBtn
            // 
            this.ZlecWybBtn.FlatAppearance.BorderSize = 0;
            this.ZlecWybBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZlecWybBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ZlecWybBtn.Location = new System.Drawing.Point(6, 222);
            this.ZlecWybBtn.Name = "ZlecWybBtn";
            this.ZlecWybBtn.Size = new System.Drawing.Size(289, 38);
            this.ZlecWybBtn.TabIndex = 11;
            this.ZlecWybBtn.Text = "Zlecenia z wybranej daty";
            this.ZlecWybBtn.UseVisualStyleBackColor = true;
            this.ZlecWybBtn.Click += new System.EventHandler(this.ZlecWybBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.WybOtwBtn);
            this.tabPage2.Controls.Add(this.WszOtwBtn);
            this.tabPage2.Controls.Add(this.MsOtwBtn);
            this.tabPage2.Controls.Add(this.Ms3OtwBtn);
            this.tabPage2.Controls.Add(this.ToOtwBtn);
            this.tabPage2.Controls.Add(this.ROtwBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(307, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zlecenia otwarte";
            // 
            // WybOtwBtn
            // 
            this.WybOtwBtn.FlatAppearance.BorderSize = 0;
            this.WybOtwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WybOtwBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.WybOtwBtn.Location = new System.Drawing.Point(6, 222);
            this.WybOtwBtn.Name = "WybOtwBtn";
            this.WybOtwBtn.Size = new System.Drawing.Size(289, 38);
            this.WybOtwBtn.TabIndex = 12;
            this.WybOtwBtn.Text = "Zlecenia z wybranej daty";
            this.WybOtwBtn.UseVisualStyleBackColor = true;
            this.WybOtwBtn.Click += new System.EventHandler(this.WybOtwBtn_Click);
            // 
            // WszOtwBtn
            // 
            this.WszOtwBtn.FlatAppearance.BorderSize = 0;
            this.WszOtwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WszOtwBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.WszOtwBtn.Location = new System.Drawing.Point(6, 6);
            this.WszOtwBtn.Name = "WszOtwBtn";
            this.WszOtwBtn.Size = new System.Drawing.Size(289, 38);
            this.WszOtwBtn.TabIndex = 10;
            this.WszOtwBtn.Text = "Wszystkie zlecenia";
            this.WszOtwBtn.UseVisualStyleBackColor = true;
            this.WszOtwBtn.Click += new System.EventHandler(this.WszOtwBtn_Click);
            // 
            // MsOtwBtn
            // 
            this.MsOtwBtn.FlatAppearance.BorderSize = 0;
            this.MsOtwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsOtwBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.MsOtwBtn.Location = new System.Drawing.Point(6, 91);
            this.MsOtwBtn.Name = "MsOtwBtn";
            this.MsOtwBtn.Size = new System.Drawing.Size(289, 37);
            this.MsOtwBtn.TabIndex = 6;
            this.MsOtwBtn.Text = "Zlecenia bieżący miesiąc";
            this.MsOtwBtn.UseVisualStyleBackColor = true;
            this.MsOtwBtn.Click += new System.EventHandler(this.MsOtwBtn_Click);
            // 
            // Ms3OtwBtn
            // 
            this.Ms3OtwBtn.FlatAppearance.BorderSize = 0;
            this.Ms3OtwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ms3OtwBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Ms3OtwBtn.Location = new System.Drawing.Point(6, 134);
            this.Ms3OtwBtn.Name = "Ms3OtwBtn";
            this.Ms3OtwBtn.Size = new System.Drawing.Size(289, 38);
            this.Ms3OtwBtn.TabIndex = 9;
            this.Ms3OtwBtn.Text = "Zlecenia z 3 miesięcy";
            this.Ms3OtwBtn.UseVisualStyleBackColor = true;
            this.Ms3OtwBtn.Click += new System.EventHandler(this.Ms3OtwBtn_Click);
            // 
            // ToOtwBtn
            // 
            this.ToOtwBtn.FlatAppearance.BorderSize = 0;
            this.ToOtwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToOtwBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ToOtwBtn.Location = new System.Drawing.Point(6, 50);
            this.ToOtwBtn.Name = "ToOtwBtn";
            this.ToOtwBtn.Size = new System.Drawing.Size(289, 35);
            this.ToOtwBtn.TabIndex = 3;
            this.ToOtwBtn.Text = "Zlecenia dzień bieżący";
            this.ToOtwBtn.UseVisualStyleBackColor = true;
            this.ToOtwBtn.Click += new System.EventHandler(this.ToOtwBtn_Click);
            // 
            // ROtwBtn
            // 
            this.ROtwBtn.FlatAppearance.BorderSize = 0;
            this.ROtwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ROtwBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ROtwBtn.Location = new System.Drawing.Point(6, 178);
            this.ROtwBtn.Name = "ROtwBtn";
            this.ROtwBtn.Size = new System.Drawing.Size(289, 38);
            this.ROtwBtn.TabIndex = 7;
            this.ROtwBtn.Text = "Zlecenia bieżący rok";
            this.ROtwBtn.UseVisualStyleBackColor = true;
            this.ROtwBtn.Click += new System.EventHandler(this.ROtwBtn_Click);
            // 
            // StatystykaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1174, 573);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Diagram);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatystykaPage";
            this.Text = "PaGaForm";
            this.Load += new System.EventHandler(this.StatystykaPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Diagram)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Diagram;
        private System.Windows.Forms.Button ZlecBtn;
        private System.Windows.Forms.Button KatBtn;
        private System.Windows.Forms.Button ZlecMSBtn;
        private System.Windows.Forms.Button ZlecRBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AllZlecBtn;
        private System.Windows.Forms.Button Zlec3mBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button WszOtwBtn;
        private System.Windows.Forms.Button MsOtwBtn;
        private System.Windows.Forms.Button Ms3OtwBtn;
        private System.Windows.Forms.Button ToOtwBtn;
        private System.Windows.Forms.Button ROtwBtn;
        private System.Windows.Forms.Button ZlecWybBtn;
        private System.Windows.Forms.Button WybOtwBtn;
    }
}