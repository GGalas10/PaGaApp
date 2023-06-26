
namespace PaGaApp.Pages
{
    partial class ZlecenieDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZlecenieDetails));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CanBtn = new System.Windows.Forms.Button();
            this.ImieBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NazwiskoBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MarkaBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NrRejBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RocznikBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NrTelBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NrVINBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.StanBox = new System.Windows.Forms.ComboBox();
            this.UslugaBtn = new System.Windows.Forms.Button();
            this.DataLbl = new System.Windows.Forms.Label();
            this.NetLbl = new System.Windows.Forms.Label();
            this.BrtLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(324, 410);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.EditBtn.Location = new System.Drawing.Point(384, 429);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edytuj";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.Location = new System.Drawing.Point(490, 429);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Zapisz";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CanBtn
            // 
            this.CanBtn.FlatAppearance.BorderSize = 0;
            this.CanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.CanBtn.Location = new System.Drawing.Point(592, 429);
            this.CanBtn.Name = "CanBtn";
            this.CanBtn.Size = new System.Drawing.Size(75, 23);
            this.CanBtn.TabIndex = 4;
            this.CanBtn.Text = "Wróc";
            this.CanBtn.UseVisualStyleBackColor = true;
            this.CanBtn.Click += new System.EventHandler(this.CanBtn_Click);
            // 
            // ImieBox
            // 
            this.ImieBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ImieBox.Location = new System.Drawing.Point(517, 101);
            this.ImieBox.Name = "ImieBox";
            this.ImieBox.ReadOnly = true;
            this.ImieBox.Size = new System.Drawing.Size(150, 20);
            this.ImieBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(384, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imie Klienta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(384, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nazwisko Klienta";
            // 
            // NazwiskoBox
            // 
            this.NazwiskoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.NazwiskoBox.Location = new System.Drawing.Point(517, 127);
            this.NazwiskoBox.Name = "NazwiskoBox";
            this.NazwiskoBox.ReadOnly = true;
            this.NazwiskoBox.Size = new System.Drawing.Size(150, 20);
            this.NazwiskoBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(384, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Model";
            // 
            // ModelBox
            // 
            this.ModelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ModelBox.Location = new System.Drawing.Point(517, 260);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.ReadOnly = true;
            this.ModelBox.Size = new System.Drawing.Size(150, 20);
            this.ModelBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(384, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Marka";
            // 
            // MarkaBox
            // 
            this.MarkaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.MarkaBox.Location = new System.Drawing.Point(517, 234);
            this.MarkaBox.Name = "MarkaBox";
            this.MarkaBox.ReadOnly = true;
            this.MarkaBox.Size = new System.Drawing.Size(150, 20);
            this.MarkaBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(384, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Numer rejestracyjny";
            // 
            // NrRejBox
            // 
            this.NrRejBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.NrRejBox.Location = new System.Drawing.Point(517, 312);
            this.NrRejBox.Name = "NrRejBox";
            this.NrRejBox.ReadOnly = true;
            this.NrRejBox.Size = new System.Drawing.Size(150, 20);
            this.NrRejBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(384, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rocznik";
            // 
            // RocznikBox
            // 
            this.RocznikBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.RocznikBox.Location = new System.Drawing.Point(517, 286);
            this.RocznikBox.Name = "RocznikBox";
            this.RocznikBox.ReadOnly = true;
            this.RocznikBox.Size = new System.Drawing.Size(150, 20);
            this.RocznikBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(384, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Numer telefonu";
            // 
            // NrTelBox
            // 
            this.NrTelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.NrTelBox.Location = new System.Drawing.Point(517, 156);
            this.NrTelBox.Name = "NrTelBox";
            this.NrTelBox.ReadOnly = true;
            this.NrTelBox.Size = new System.Drawing.Size(150, 20);
            this.NrTelBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(384, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Numer VIN";
            // 
            // NrVINBox
            // 
            this.NrVINBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.NrVINBox.Location = new System.Drawing.Point(517, 338);
            this.NrVINBox.Name = "NrVINBox";
            this.NrVINBox.ReadOnly = true;
            this.NrVINBox.Size = new System.Drawing.Size(150, 20);
            this.NrVINBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(410, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 31);
            this.label9.TabIndex = 21;
            this.label9.Text = "Dane Klienta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(410, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 31);
            this.label10.TabIndex = 22;
            this.label10.Text = "Dane samochodu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(12, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 31);
            this.label11.TabIndex = 23;
            this.label11.Text = "Lista usług";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(384, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Stan zlecenia";
            // 
            // StanBox
            // 
            this.StanBox.Enabled = false;
            this.StanBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StanBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.StanBox.FormattingEnabled = true;
            this.StanBox.Items.AddRange(new object[] {
            "W realizacji",
            "Zakończone"});
            this.StanBox.Location = new System.Drawing.Point(490, 8);
            this.StanBox.Name = "StanBox";
            this.StanBox.Size = new System.Drawing.Size(95, 21);
            this.StanBox.TabIndex = 25;
            // 
            // UslugaBtn
            // 
            this.UslugaBtn.FlatAppearance.BorderSize = 0;
            this.UslugaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UslugaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.UslugaBtn.Location = new System.Drawing.Point(173, 6);
            this.UslugaBtn.Name = "UslugaBtn";
            this.UslugaBtn.Size = new System.Drawing.Size(164, 23);
            this.UslugaBtn.TabIndex = 26;
            this.UslugaBtn.Text = "Dodaj usługę";
            this.UslugaBtn.UseVisualStyleBackColor = true;
            this.UslugaBtn.Visible = false;
            this.UslugaBtn.Click += new System.EventHandler(this.UslugaBtn_Click);
            // 
            // DataLbl
            // 
            this.DataLbl.AutoSize = true;
            this.DataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.DataLbl.Location = new System.Drawing.Point(607, 11);
            this.DataLbl.Name = "DataLbl";
            this.DataLbl.Size = new System.Drawing.Size(88, 26);
            this.DataLbl.TabIndex = 27;
            this.DataLbl.Text = "Data przyjęcia\r\n\r\n";
            // 
            // NetLbl
            // 
            this.NetLbl.AutoSize = true;
            this.NetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.NetLbl.Location = new System.Drawing.Point(384, 369);
            this.NetLbl.Name = "NetLbl";
            this.NetLbl.Size = new System.Drawing.Size(75, 13);
            this.NetLbl.TabIndex = 28;
            this.NetLbl.Text = "Suma netto:";
            // 
            // BrtLbl
            // 
            this.BrtLbl.AutoSize = true;
            this.BrtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BrtLbl.Location = new System.Drawing.Point(384, 396);
            this.BrtLbl.Name = "BrtLbl";
            this.BrtLbl.Size = new System.Drawing.Size(75, 13);
            this.BrtLbl.TabIndex = 29;
            this.BrtLbl.Text = "Suma brutto";
            // 
            // ZlecenieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(732, 458);
            this.Controls.Add(this.BrtLbl);
            this.Controls.Add(this.NetLbl);
            this.Controls.Add(this.DataLbl);
            this.Controls.Add(this.UslugaBtn);
            this.Controls.Add(this.StanBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NrTelBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NrVINBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NrRejBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RocznikBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MarkaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NazwiskoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImieBox);
            this.Controls.Add(this.CanBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(748, 497);
            this.Name = "ZlecenieDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zlecenie";
            this.Load += new System.EventHandler(this.ZlecenieDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CanBtn;
        private System.Windows.Forms.TextBox ImieBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NazwiskoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MarkaBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NrRejBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RocznikBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NrTelBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NrVINBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox StanBox;
        private System.Windows.Forms.Button UslugaBtn;
        private System.Windows.Forms.Label DataLbl;
        private System.Windows.Forms.Label NetLbl;
        private System.Windows.Forms.Label BrtLbl;
    }
}