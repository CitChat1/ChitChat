using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ChitChat
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-1T2OF72;Initial Catalog=ChitChat;User Id=Kullanici;Password=123456;";
        private string kullaniciTablo = "Kullanicilar";
        private static string GirisYapanKullaniciAdi;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT Sifre FROM {kullaniciTablo} WHERE KullaniciAdi = @KullaniciAdi";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                    string hashedPassword = (string)command.ExecuteScalar();

                    if (!string.IsNullOrEmpty(hashedPassword) && VerifyPassword(sifre, hashedPassword))
                    {
                        GirisYapanKullaniciAdi = kullaniciAdi;

                        this.Hide();
                        anasayfa anasayfaForm = new anasayfa(GirisYapanKullaniciAdi);
                        anasayfaForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz kullanıcı adı veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUyeOl_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            uyeol uyeOlForm = new uyeol();
            uyeOlForm.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] enteredPasswordBytes = Encoding.UTF8.GetBytes(enteredPassword);
                byte[] hashedBytes = sha256.ComputeHash(enteredPasswordBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return storedHash.Equals(builder.ToString());
            }
        }
    }
}
