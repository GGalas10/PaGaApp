using PaGaApp.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaGaApp
{
    public partial class PaGaMenu : Form
    {
        private Form ActiveForm;
        public static Pracownik zal;
        public PaGaMenu(Pracownik zalogowany)
        {
            zal = zalogowany;
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void OpenPage(Form newPage)
        {
            if (ActiveForm != null)
            {
                if (pictureBox1.Visible == false)
                {
                    pictureBox1.Visible = true;
                }
                ActiveForm.Close();
            }
            ActiveForm = newPage;
            newPage.TopLevel = false;
            newPage.AutoScroll = true;
            newPage.Dock = DockStyle.Fill;
            PagePanel.Controls.Add(newPage);
            PagePanel.Tag = newPage;
            newPage.BringToFront();
            newPage.Show();
            newPage.Focus();
        }
        private void btn_Click(object sender, EventArgs e)
        {

            Label BtnMenu = (sender as Label);
            switch (BtnMenu.Name)
            {
                case "AddAccBtn":
                    TitleLabel.Text = "Administartor";
                    OpenPage(new AdminPage());
                    break;
                case "UstawieniaBtn":
                    TitleLabel.Text = "Ustawienia";
                    OpenPage(new UstawieniaPage());
                    break;
                case "ZleceniaOtwarteBtn":
                    TitleLabel.Text = "Zlecenia otwarte";
                    OpenPage(new ZleceniaOtwartePage());
                    break;
                case "ZleceniaZamknieteBtn":
                    TitleLabel.Text = "Zlecenia zakończone";
                    OpenPage(new ZleceniaZamknietePage());
                    break;
                case "KlienciBtn":
                    TitleLabel.Text = "Klienci";
                    OpenPage(new KlientPage());
                    break;
                case "StatystykaBtn":
                    TitleLabel.Text = "Statystyka";
                    OpenPage(new StatystykaPage());
                    break;
            }
            Label sen = sender as Label;
            foreach (var kontrolka in LeftMenuPanel.Controls)
            {
                if (kontrolka is Label)
                {
                    if ((kontrolka as Label).BackColor == Color.LightSlateGray)
                    {
                        (kontrolka as Label).Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        (kontrolka as Label).BackColor = System.Drawing.Color.Transparent;
                        (kontrolka as Label).MouseLeave += Btn_MouseLeave;
                        (kontrolka as Label).MouseEnter += Btn_MouseEnter;
                    }
                }
            }
            sen.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sen.BackColor = System.Drawing.Color.LightSlateGray;
            sen.MouseLeave -= Btn_MouseLeave;
            sen.MouseEnter -= Btn_MouseEnter;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            switch (zal.Uprawnienia)
            {
                case 0:
                    break;
                case 1:
                    AddAccBtn.Visible = false;
                    break;
                case 2:
                    AddAccBtn.Visible = false;
                    StatystykaBtn.Visible = false;
                    break;
            }
            OpenPage(new PaGaHomePage());
        }
        public void zmianaTesktu(string text)
        {
            if (text == ">")
            {
                ZleceniaOtwarteBtn.Text = "Zlecenia\notwarte";
                ZleceniaZamknieteBtn.Text = "Zlecenia\nzakończone";
                KlienciBtn.Text = "Klienci";
                AddAccBtn.Text = "Administracja";
                StatystykaBtn.Text = "Statystyka";
                UstawieniaBtn.Text = "Ustawienia";
            }
            else
            {
                ZleceniaOtwarteBtn.Text = null;
                ZleceniaZamknieteBtn.Text = null;
                KlienciBtn.Text = null;
                AddAccBtn.Text = null;
                StatystykaBtn.Text = null;
                UstawieniaBtn.Text = null;
            }
        }
        private void RozsuwaneMenuBtn_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == ">")
            {
                zmianaTesktu(">");
                LeftMenuPanel.Size = new Size(220, 681);
                if (this.Size == new Size(1280, 720))
                {
                    this.Size = new Size(1410, 720);
                }
                (sender as Button).Text = "<";
            }
            else
            {
                if (this.Size == new Size(1410, 720))
                {
                    this.Size = new Size(1280, 720);
                }
                zmianaTesktu("<");
                LeftMenuPanel.Size = new Size(90, 681);
                (sender as Button).Text = ">";
            }
        }
        private void ZmianakoloruNajechanie(Label sender)
        {
            sender.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sender.BackColor = System.Drawing.Color.Lavender;
        }
        private void ZmianakoloruZjechanie(Label sender)
        {
            sender.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sender.BackColor = sender.BackColor = System.Drawing.Color.Transparent;
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            ZmianakoloruNajechanie(sender as Label);
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            ZmianakoloruZjechanie(sender as Label);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            TitleLabel.Text = "Home";
            foreach (var kontrolka in LeftMenuPanel.Controls)
            {
                if (kontrolka is Label)
                {
                    if ((kontrolka as Label).BackColor == Color.LightSlateGray)
                    {
                        (kontrolka as Label).Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        (kontrolka as Label).BackColor = System.Drawing.Color.Transparent;
                        (kontrolka as Label).MouseLeave += Btn_MouseLeave;
                        (kontrolka as Label).MouseEnter += Btn_MouseEnter;
                    }
                }
            }
            OpenPage(new PaGaHomePage());
            pictureBox1.Visible = false;
        }

        private void WylogujBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
