
namespace PaGaApp.Pages
{
    partial class CarDetailsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarDetailsPage));
            this.CancelBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.OpisBox = new System.Windows.Forms.TextBox();
            this.OpisLbl = new System.Windows.Forms.Label();
            this.KmBox = new System.Windows.Forms.TextBox();
            this.KMLbl = new System.Windows.Forms.Label();
            this.KwBox = new System.Windows.Forms.TextBox();
            this.KWLbl = new System.Windows.Forms.Label();
            this.VinBox = new System.Windows.Forms.TextBox();
            this.NrVINLbl = new System.Windows.Forms.Label();
            this.NrRejBox = new System.Windows.Forms.TextBox();
            this.NrRejLbl = new System.Windows.Forms.Label();
            this.RocznikBox = new System.Windows.Forms.TextBox();
            this.RocznikLbl = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.ModelLbl = new System.Windows.Forms.Label();
            this.MarkaBox = new System.Windows.Forms.TextBox();
            this.MarkaLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CancelBtn.Location = new System.Drawing.Point(335, 421);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(134, 23);
            this.CancelBtn.TabIndex = 29;
            this.CancelBtn.Text = "Anuluj";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.EditBtn.Location = new System.Drawing.Point(12, 421);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(134, 23);
            this.EditBtn.TabIndex = 28;
            this.EditBtn.Text = "Edytuj";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // OpisBox
            // 
            this.OpisBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpisBox.Location = new System.Drawing.Point(12, 149);
            this.OpisBox.Multiline = true;
            this.OpisBox.Name = "OpisBox";
            this.OpisBox.ReadOnly = true;
            this.OpisBox.Size = new System.Drawing.Size(466, 266);
            this.OpisBox.TabIndex = 25;
            // 
            // OpisLbl
            // 
            this.OpisLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpisLbl.AutoSize = true;
            this.OpisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.OpisLbl.Location = new System.Drawing.Point(9, 121);
            this.OpisLbl.Name = "OpisLbl";
            this.OpisLbl.Size = new System.Drawing.Size(137, 16);
            this.OpisLbl.TabIndex = 31;
            this.OpisLbl.Text = "Opis (Opcjonalnie)";
            // 
            // KmBox
            // 
            this.KmBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KmBox.Location = new System.Drawing.Point(192, 48);
            this.KmBox.MaxLength = 4;
            this.KmBox.Name = "KmBox";
            this.KmBox.ReadOnly = true;
            this.KmBox.Size = new System.Drawing.Size(37, 20);
            this.KmBox.TabIndex = 20;
            // 
            // KMLbl
            // 
            this.KMLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KMLbl.AutoSize = true;
            this.KMLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.KMLbl.Location = new System.Drawing.Point(124, 52);
            this.KMLbl.Name = "KMLbl";
            this.KMLbl.Size = new System.Drawing.Size(62, 16);
            this.KMLbl.TabIndex = 30;
            this.KMLbl.Text = "Moc KM";
            // 
            // KwBox
            // 
            this.KwBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KwBox.Location = new System.Drawing.Point(78, 85);
            this.KwBox.MaxLength = 4;
            this.KwBox.Name = "KwBox";
            this.KwBox.ReadOnly = true;
            this.KwBox.Size = new System.Drawing.Size(37, 20);
            this.KwBox.TabIndex = 22;
            // 
            // KWLbl
            // 
            this.KWLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KWLbl.AutoSize = true;
            this.KWLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.KWLbl.Location = new System.Drawing.Point(9, 86);
            this.KWLbl.Name = "KWLbl";
            this.KWLbl.Size = new System.Drawing.Size(64, 16);
            this.KWLbl.TabIndex = 27;
            this.KWLbl.Text = "Moc KW";
            // 
            // VinBox
            // 
            this.VinBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VinBox.Location = new System.Drawing.Point(301, 85);
            this.VinBox.MaxLength = 17;
            this.VinBox.Name = "VinBox";
            this.VinBox.ReadOnly = true;
            this.VinBox.Size = new System.Drawing.Size(114, 20);
            this.VinBox.TabIndex = 24;
            // 
            // NrVINLbl
            // 
            this.NrVINLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NrVINLbl.AutoSize = true;
            this.NrVINLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.NrVINLbl.Location = new System.Drawing.Point(213, 86);
            this.NrVINLbl.Name = "NrVINLbl";
            this.NrVINLbl.Size = new System.Drawing.Size(88, 16);
            this.NrVINLbl.TabIndex = 26;
            this.NrVINLbl.Text = "Numer VIN*";
            // 
            // NrRejBox
            // 
            this.NrRejBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NrRejBox.Location = new System.Drawing.Point(362, 48);
            this.NrRejBox.MaxLength = 7;
            this.NrRejBox.Name = "NrRejBox";
            this.NrRejBox.ReadOnly = true;
            this.NrRejBox.Size = new System.Drawing.Size(53, 20);
            this.NrRejBox.TabIndex = 21;
            // 
            // NrRejLbl
            // 
            this.NrRejLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NrRejLbl.AutoSize = true;
            this.NrRejLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.NrRejLbl.Location = new System.Drawing.Point(235, 50);
            this.NrRejLbl.Name = "NrRejLbl";
            this.NrRejLbl.Size = new System.Drawing.Size(129, 16);
            this.NrRejLbl.TabIndex = 23;
            this.NrRejLbl.Text = "Nr Rejestracyjny*";
            // 
            // RocznikBox
            // 
            this.RocznikBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RocznikBox.Location = new System.Drawing.Point(78, 49);
            this.RocznikBox.MaxLength = 4;
            this.RocznikBox.Name = "RocznikBox";
            this.RocznikBox.ReadOnly = true;
            this.RocznikBox.Size = new System.Drawing.Size(37, 20);
            this.RocznikBox.TabIndex = 18;
            // 
            // RocznikLbl
            // 
            this.RocznikLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RocznikLbl.AutoSize = true;
            this.RocznikLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.RocznikLbl.Location = new System.Drawing.Point(9, 52);
            this.RocznikLbl.Name = "RocznikLbl";
            this.RocznikLbl.Size = new System.Drawing.Size(63, 16);
            this.RocznikLbl.TabIndex = 19;
            this.RocznikLbl.Text = "Rocznik";
            // 
            // ModelBox
            // 
            this.ModelBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModelBox.Location = new System.Drawing.Point(272, 16);
            this.ModelBox.MaxLength = 20;
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.ReadOnly = true;
            this.ModelBox.Size = new System.Drawing.Size(143, 20);
            this.ModelBox.TabIndex = 17;
            // 
            // ModelLbl
            // 
            this.ModelLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModelLbl.AutoSize = true;
            this.ModelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ModelLbl.Location = new System.Drawing.Point(215, 20);
            this.ModelLbl.Name = "ModelLbl";
            this.ModelLbl.Size = new System.Drawing.Size(57, 16);
            this.ModelLbl.TabIndex = 16;
            this.ModelLbl.Text = "Model*";
            // 
            // MarkaBox
            // 
            this.MarkaBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MarkaBox.Location = new System.Drawing.Point(61, 16);
            this.MarkaBox.MaxLength = 20;
            this.MarkaBox.Name = "MarkaBox";
            this.MarkaBox.ReadOnly = true;
            this.MarkaBox.Size = new System.Drawing.Size(143, 20);
            this.MarkaBox.TabIndex = 15;
            // 
            // MarkaLbl
            // 
            this.MarkaLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MarkaLbl.AutoSize = true;
            this.MarkaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.MarkaLbl.Location = new System.Drawing.Point(9, 17);
            this.MarkaLbl.Name = "MarkaLbl";
            this.MarkaLbl.Size = new System.Drawing.Size(57, 16);
            this.MarkaLbl.TabIndex = 14;
            this.MarkaLbl.Text = "Marka*";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.Location = new System.Drawing.Point(167, 421);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(134, 23);
            this.SaveBtn.TabIndex = 32;
            this.SaveBtn.Text = "Zapisz";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CarDetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(496, 461);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.OpisBox);
            this.Controls.Add(this.OpisLbl);
            this.Controls.Add(this.KmBox);
            this.Controls.Add(this.KMLbl);
            this.Controls.Add(this.KwBox);
            this.Controls.Add(this.KWLbl);
            this.Controls.Add(this.VinBox);
            this.Controls.Add(this.NrVINLbl);
            this.Controls.Add(this.NrRejBox);
            this.Controls.Add(this.NrRejLbl);
            this.Controls.Add(this.RocznikBox);
            this.Controls.Add(this.RocznikLbl);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.ModelLbl);
            this.Controls.Add(this.MarkaBox);
            this.Controls.Add(this.MarkaLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(512, 500);
            this.Name = "CarDetailsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CarDetailsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox OpisBox;
        private System.Windows.Forms.Label OpisLbl;
        private System.Windows.Forms.TextBox KmBox;
        private System.Windows.Forms.Label KMLbl;
        private System.Windows.Forms.TextBox KwBox;
        private System.Windows.Forms.Label KWLbl;
        private System.Windows.Forms.TextBox VinBox;
        private System.Windows.Forms.Label NrVINLbl;
        private System.Windows.Forms.TextBox NrRejBox;
        private System.Windows.Forms.Label NrRejLbl;
        private System.Windows.Forms.TextBox RocznikBox;
        private System.Windows.Forms.Label RocznikLbl;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.Label ModelLbl;
        private System.Windows.Forms.TextBox MarkaBox;
        private System.Windows.Forms.Label MarkaLbl;
        private System.Windows.Forms.Button SaveBtn;
    }
}