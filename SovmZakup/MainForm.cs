using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Security.Cryptography;

namespace SovmZakup
{
    public partial class MainForm : Form
    {
        Zakup zakupPage = new Zakup();
        Clients clientsPage = new Clients();
        Money moneyPage = new Money();
        public MainForm()
        {
            InitializeComponent();
            loginPanel.Visible = true;
            panel1.Visible = false;
            mainPanel.Controls.Add(loginPanel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            resetButtons();
            clientsButton.IsActive = true;
            clientsButton.Image = global::SovmZakup.Properties.Resources.a_contacts;
            mainPanel.Controls.Add(clientsPage);
        }

        private void resetButtons()
        {
            clientsButton.IsActive = false;
            zakupButton.IsActive = false;
            moneyButton.IsActive = false;
            clientsButton.ForeColor = System.Drawing.Color.FromArgb(51, 77, 110);
            zakupButton.ForeColor = System.Drawing.Color.FromArgb(51, 77, 110);
            moneyButton.ForeColor = System.Drawing.Color.FromArgb(51, 77, 110);
            clientsButton.Image = global::SovmZakup.Properties.Resources.contacts;
            zakupButton.Image = global::SovmZakup.Properties.Resources.dashboard;
            moneyButton.Image = global::SovmZakup.Properties.Resources.deals;
            mainPanel.Controls.Clear();
        }

        private void zakupButton_Click(object sender, EventArgs e)
        {
            resetButtons();
            zakupButton.IsActive = true;
            zakupButton.Image = global::SovmZakup.Properties.Resources.a_dashboard;
            mainPanel.Controls.Add(zakupPage);
        }

        private void moneyButton_Click(object sender, EventArgs e)
        {
            resetButtons();
            moneyButton.IsActive = true;
            moneyButton.Image = global::SovmZakup.Properties.Resources.a_deals;
            mainPanel.Controls.Add(moneyPage);
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e)
        {
            exitLabel.Font = new System.Drawing.Font(exitLabel.Font.Name, exitLabel.Font.Size, FontStyle.Underline);
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.Font = new System.Drawing.Font(exitLabel.Font.Name, exitLabel.Font.Size, FontStyle.Regular);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var connString = "Host=localhost;Port=5433;Username=postgres;Password=postgres;Database=sovmzak";
            var passHash = GenerateSHA256String(passTB.Text);
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                bool blnfound = false;
                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT * FROM users WHERE login = '" + loginTB.Text + "' AND password = '" + passHash.ToLower() + "'", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nameLabel.Text = reader.GetString(1) + " " + reader.GetString(2);
                            blnfound = true;
                            loginPanel.Visible = false;
                            panel1.Visible = true;
                            mainPanel.Controls.Add(zakupPage);
                        }
                        if (blnfound == false)
                            errorLabel.Text = "Неверный логин или пароль";

                        reader.Close();
                    }
                    conn.Close();
                }
            }
        }

        public static string GenerateSHA256String(string inputString)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha256.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
