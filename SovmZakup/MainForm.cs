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

            mainPanel.Controls.Add(zakupPage);
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
    }
}
