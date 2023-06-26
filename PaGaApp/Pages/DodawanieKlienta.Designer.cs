
namespace PaGaApp.Pages
{
    partial class DodawanieKlienta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodawanieKlienta));
            this.ImieLbl = new System.Windows.Forms.Label();
            this.ImieBox = new System.Windows.Forms.TextBox();
            this.NazwiskoBox = new System.Windows.Forms.TextBox();
            this.NazwiskoLbl = new System.Windows.Forms.Label();
            this.NrtelBox = new System.Windows.Forms.TextBox();
            this.NumerTelLbl = new System.Windows.Forms.Label();
            this.SamochodLbl = new System.Windows.Forms.Label();
            this.CarList = new System.Windows.Forms.ListBox();
            this.AddCarBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImieLbl
            // 
            this.ImieLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImieLbl.AutoSize = true;
            this.ImieLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImieLbl.Location = new System.Drawing.Point(20, 25);
            this.ImieLbl.Name = "ImieLbl";
            this.ImieLbl.Size = new System.Drawing.Size(37, 16);
            this.ImieLbl.TabIndex = 0;
            this.ImieLbl.Text = "Imie";
            // 
            // ImieBox
            // 
            this.ImieBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImieBox.Location = new System.Drawing.Point(139, 24);
            this.ImieBox.MaxLength = 15;
            this.ImieBox.Name = "ImieBox";
            this.ImieBox.Size = new System.Drawing.Size(100, 20);
            this.ImieBox.TabIndex = 1;
            this.ImieBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImieBox_KeyPress);
            // 
            // NazwiskoBox
            // 
            this.NazwiskoBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NazwiskoBox.Location = new System.Drawing.Point(139, 71);
            this.NazwiskoBox.MaxLength = 15;
            this.NazwiskoBox.Name = "NazwiskoBox";
            this.NazwiskoBox.Size = new System.Drawing.Size(100, 20);
            this.NazwiskoBox.TabIndex = 3;
            this.NazwiskoBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NazwiskoBox_KeyPress);
            // 
            // NazwiskoLbl
            // 
            this.NazwiskoLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NazwiskoLbl.AutoSize = true;
            this.NazwiskoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwiskoLbl.Location = new System.Drawing.Point(20, 72);
            this.NazwiskoLbl.Name = "NazwiskoLbl";
            this.NazwiskoLbl.Size = new System.Drawing.Size(74, 16);
            this.NazwiskoLbl.TabIndex = 2;
            this.NazwiskoLbl.Text = "Nazwisko";
            // 
            // NrtelBox
            // 
            this.NrtelBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NrtelBox.Location = new System.Drawing.Point(139, 120);
            this.NrtelBox.MaxLength = 9;
            this.NrtelBox.Name = "NrtelBox";
            this.NrtelBox.Size = new System.Drawing.Size(100, 20);
            this.NrtelBox.TabIndex = 5;
            this.NrtelBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NrtelBox_KeyPress);
            // 
            // NumerTelLbl
            // 
            this.NumerTelLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumerTelLbl.AutoSize = true;
            this.NumerTelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumerTelLbl.Location = new System.Drawing.Point(20, 121);
            this.NumerTelLbl.Name = "NumerTelLbl";
            this.NumerTelLbl.Size = new System.Drawing.Size(112, 16);
            this.NumerTelLbl.TabIndex = 4;
            this.NumerTelLbl.Text = "Numer telefonu";
            // 
            // SamochodLbl
            // 
            this.SamochodLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SamochodLbl.AutoSize = true;
            this.SamochodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SamochodLbl.Location = new System.Drawing.Point(290, 23);
            this.SamochodLbl.Name = "SamochodLbl";
            this.SamochodLbl.Size = new System.Drawing.Size(82, 16);
            this.SamochodLbl.TabIndex = 7;
            this.SamochodLbl.Text = "Samochód";
            // 
            // CarList
            // 
            this.CarList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CarList.FormattingEnabled = true;
            this.CarList.Location = new System.Drawing.Point(289, 45);
            this.CarList.Name = "CarList";
            this.CarList.Size = new System.Drawing.Size(225, 95);
            this.CarList.TabIndex = 8;
            // 
            // AddCarBtn
            // 
            this.AddCarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddCarBtn.AutoSize = true;
            this.AddCarBtn.FlatAppearance.BorderSize = 0;
            this.AddCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddCarBtn.Location = new System.Drawing.Point(378, 18);
            this.AddCarBtn.Name = "AddCarBtn";
            this.AddCarBtn.Size = new System.Drawing.Size(136, 26);
            this.AddCarBtn.TabIndex = 9;
            this.AddCarBtn.Text = "Dodaj samochód";
            this.AddCarBtn.UseVisualStyleBackColor = true;
            this.AddCarBtn.Click += new System.EventHandler(this.AddCarBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveBtn.AutoSize = true;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.Location = new System.Drawing.Point(15, 149);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(115, 26);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Zapisz Klienta";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackBtn.AutoSize = true;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BackBtn.Location = new System.Drawing.Point(420, 152);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(94, 26);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "Anuluj";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DodawanieKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(526, 187);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.AddCarBtn);
            this.Controls.Add(this.CarList);
            this.Controls.Add(this.SamochodLbl);
            this.Controls.Add(this.NrtelBox);
            this.Controls.Add(this.NumerTelLbl);
            this.Controls.Add(this.NazwiskoBox);
            this.Controls.Add(this.NazwiskoLbl);
            this.Controls.Add(this.ImieBox);
            this.Controls.Add(this.ImieLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(542, 226);
            this.MinimumSize = new System.Drawing.Size(542, 226);
            this.Name = "DodawanieKlienta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImieLbl;
        private System.Windows.Forms.TextBox ImieBox;
        private System.Windows.Forms.TextBox NazwiskoBox;
        private System.Windows.Forms.Label NazwiskoLbl;
        private System.Windows.Forms.TextBox NrtelBox;
        private System.Windows.Forms.Label NumerTelLbl;
        private System.Windows.Forms.Label SamochodLbl;
        private System.Windows.Forms.ListBox CarList;
        private System.Windows.Forms.Button AddCarBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}