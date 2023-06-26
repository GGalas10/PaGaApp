
namespace PaGaApp.Pages
{
    partial class ZmianaHasla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZmianaHasla));
            this.OldBox = new System.Windows.Forms.TextBox();
            this.NewBox = new System.Windows.Forms.TextBox();
            this.OldLbl = new System.Windows.Forms.Label();
            this.New1Lbl = new System.Windows.Forms.Label();
            this.New2Lbl = new System.Windows.Forms.Label();
            this.New1Box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OldBox
            // 
            this.OldBox.Location = new System.Drawing.Point(143, 15);
            this.OldBox.MaxLength = 15;
            this.OldBox.Name = "OldBox";
            this.OldBox.PasswordChar = '*';
            this.OldBox.Size = new System.Drawing.Size(116, 20);
            this.OldBox.TabIndex = 1;
            // 
            // NewBox
            // 
            this.NewBox.Location = new System.Drawing.Point(143, 61);
            this.NewBox.MaxLength = 15;
            this.NewBox.Name = "NewBox";
            this.NewBox.PasswordChar = '*';
            this.NewBox.Size = new System.Drawing.Size(116, 20);
            this.NewBox.TabIndex = 2;
            // 
            // OldLbl
            // 
            this.OldLbl.AutoSize = true;
            this.OldLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.OldLbl.Location = new System.Drawing.Point(15, 18);
            this.OldLbl.Name = "OldLbl";
            this.OldLbl.Size = new System.Drawing.Size(73, 13);
            this.OldLbl.TabIndex = 2;
            this.OldLbl.Text = "Stare hasło";
            // 
            // New1Lbl
            // 
            this.New1Lbl.AutoSize = true;
            this.New1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.New1Lbl.Location = new System.Drawing.Point(15, 64);
            this.New1Lbl.Name = "New1Lbl";
            this.New1Lbl.Size = new System.Drawing.Size(75, 13);
            this.New1Lbl.TabIndex = 3;
            this.New1Lbl.Text = "Nowe hasło";
            // 
            // New2Lbl
            // 
            this.New2Lbl.AutoSize = true;
            this.New2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.New2Lbl.Location = new System.Drawing.Point(15, 100);
            this.New2Lbl.Name = "New2Lbl";
            this.New2Lbl.Size = new System.Drawing.Size(122, 13);
            this.New2Lbl.TabIndex = 5;
            this.New2Lbl.Text = "Powtórz nowe hasło";
            // 
            // New1Box
            // 
            this.New1Box.Location = new System.Drawing.Point(143, 97);
            this.New1Box.MaxLength = 15;
            this.New1Box.Name = "New1Box";
            this.New1Box.PasswordChar = '*';
            this.New1Box.Size = new System.Drawing.Size(116, 20);
            this.New1Box.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(18, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Zmień";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZmianaHasla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(289, 171);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.New2Lbl);
            this.Controls.Add(this.New1Box);
            this.Controls.Add(this.New1Lbl);
            this.Controls.Add(this.OldLbl);
            this.Controls.Add(this.NewBox);
            this.Controls.Add(this.OldBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(305, 210);
            this.MinimumSize = new System.Drawing.Size(305, 210);
            this.Name = "ZmianaHasla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zmiana hasła";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OldBox;
        private System.Windows.Forms.TextBox NewBox;
        private System.Windows.Forms.Label OldLbl;
        private System.Windows.Forms.Label New1Lbl;
        private System.Windows.Forms.Label New2Lbl;
        private System.Windows.Forms.TextBox New1Box;
        private System.Windows.Forms.Button button1;
    }
}