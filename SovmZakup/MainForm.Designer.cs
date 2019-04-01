namespace SovmZakup
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.moneyButton = new MonoFlat.MonoFlat_MenuButton();
            this.clientsButton = new MonoFlat.MonoFlat_MenuButton();
            this.zakupButton = new MonoFlat.MonoFlat_MenuButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.exitLabel = new MonoFlat.MonoFlat_Label();
            this.nameLabel = new MonoFlat.MonoFlat_Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.passTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new MonoFlat.MonoFlat_Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.moneyButton);
            this.panel1.Controls.Add(this.clientsButton);
            this.panel1.Controls.Add(this.zakupButton);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 644);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // moneyButton
            // 
            this.moneyButton.BackColor = System.Drawing.Color.Transparent;
            this.moneyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.moneyButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.moneyButton.Image = global::SovmZakup.Properties.Resources.deals;
            this.moneyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moneyButton.IsActive = false;
            this.moneyButton.Location = new System.Drawing.Point(0, 261);
            this.moneyButton.Name = "moneyButton";
            this.moneyButton.Size = new System.Drawing.Size(256, 50);
            this.moneyButton.TabIndex = 6;
            this.moneyButton.Text = "Денежная сводка";
            this.moneyButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.moneyButton.Click += new System.EventHandler(this.moneyButton_Click);
            // 
            // clientsButton
            // 
            this.clientsButton.BackColor = System.Drawing.Color.Transparent;
            this.clientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientsButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.clientsButton.Image = global::SovmZakup.Properties.Resources.contacts;
            this.clientsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsButton.IsActive = false;
            this.clientsButton.Location = new System.Drawing.Point(0, 211);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(256, 50);
            this.clientsButton.TabIndex = 5;
            this.clientsButton.Text = "Клиенты";
            this.clientsButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.clientsButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // zakupButton
            // 
            this.zakupButton.BackColor = System.Drawing.Color.Transparent;
            this.zakupButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.zakupButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.zakupButton.Image = global::SovmZakup.Properties.Resources.a_dashboard;
            this.zakupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zakupButton.IsActive = true;
            this.zakupButton.Location = new System.Drawing.Point(0, 161);
            this.zakupButton.Name = "zakupButton";
            this.zakupButton.Size = new System.Drawing.Size(256, 50);
            this.zakupButton.TabIndex = 4;
            this.zakupButton.Text = "Закупки";
            this.zakupButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.zakupButton.Click += new System.EventHandler(this.zakupButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(256, 100);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.exitLabel);
            this.panel6.Controls.Add(this.nameLabel);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(27, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 48);
            this.panel6.TabIndex = 3;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exitLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.exitLabel.Location = new System.Drawing.Point(61, 26);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(46, 15);
            this.exitLabel.TabIndex = 4;
            this.exitLabel.Text = "Выход";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitLabel.MouseEnter += new System.EventHandler(this.exitLabel_MouseEnter);
            this.exitLabel.MouseLeave += new System.EventHandler(this.exitLabel_MouseLeave);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.nameLabel.Location = new System.Drawing.Point(57, 5);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(127, 19);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Мария Тимеева";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::SovmZakup.Properties.Resources.profile_photo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 48);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 1);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 60);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(146)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Совместные закупки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = global::SovmZakup.Properties.Resources.bg;
            this.mainPanel.Controls.Add(this.loginPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(256, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(722, 644);
            this.mainPanel.TabIndex = 1;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.errorLabel);
            this.loginPanel.Controls.Add(this.panel8);
            this.loginPanel.Controls.Add(this.label4);
            this.loginPanel.Controls.Add(this.panel7);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Controls.Add(this.pictureBox2);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Location = new System.Drawing.Point(334, 123);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(300, 400);
            this.loginPanel.TabIndex = 11;
            // 
            // errorLabel
            // 
            this.errorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.errorLabel.Location = new System.Drawing.Point(0, 359);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(300, 41);
            this.errorLabel.TabIndex = 18;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.passTB);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 237);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.panel8.Size = new System.Drawing.Size(300, 37);
            this.panel8.TabIndex = 17;
            // 
            // passTB
            // 
            this.passTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTB.Location = new System.Drawing.Point(30, 0);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(240, 27);
            this.passTB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(146)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(0, 206);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(300, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Пароль";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.loginTB);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 171);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.panel7.Size = new System.Drawing.Size(300, 35);
            this.panel7.TabIndex = 15;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // loginTB
            // 
            this.loginTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTB.Location = new System.Drawing.Point(30, 0);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(240, 27);
            this.loginTB.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(146)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(0, 127);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(300, 44);
            this.label3.TabIndex = 14;
            this.label3.Text = "Логин";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SovmZakup.Properties.Resources.profile_photo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 67);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(146)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 60);
            this.label2.TabIndex = 12;
            this.label2.Text = "Совместные закупки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Image = null;
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Location = new System.Drawing.Point(110, 280);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(160, 42);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "Войти";
            this.loginButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Совместные закупки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private MonoFlat.MonoFlat_Label nameLabel;
        private MonoFlat.MonoFlat_Label exitLabel;
        private MonoFlat.MonoFlat_MenuButton moneyButton;
        private MonoFlat.MonoFlat_MenuButton clientsButton;
        private MonoFlat.MonoFlat_MenuButton zakupButton;
        private System.Windows.Forms.Panel mainPanel;
        private MonoFlat.MonoFlat_Button loginButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label errorLabel;
    }
}

