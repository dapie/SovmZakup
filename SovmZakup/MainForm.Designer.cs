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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.moneyButton = new MonoFlat.MonoFlat_MenuButton();
            this.clientsButton = new MonoFlat.MonoFlat_MenuButton();
            this.zakupButton = new MonoFlat.MonoFlat_MenuButton();
            this.monoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel6.Controls.Add(this.monoFlat_Label2);
            this.panel6.Controls.Add(this.monoFlat_Label1);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(27, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(208, 48);
            this.panel6.TabIndex = 3;
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
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(256, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(722, 644);
            this.mainPanel.TabIndex = 1;
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
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.monoFlat_Label2.Location = new System.Drawing.Point(61, 26);
            this.monoFlat_Label2.Margin = new System.Windows.Forms.Padding(0);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(46, 15);
            this.monoFlat_Label2.TabIndex = 4;
            this.monoFlat_Label2.Text = "Выход";
            this.monoFlat_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(58, 5);
            this.monoFlat_Label1.Margin = new System.Windows.Forms.Padding(0);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(119, 18);
            this.monoFlat_Label1.TabIndex = 3;
            this.monoFlat_Label1.Text = "Мария Тимеева";
            this.monoFlat_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Совместные закупки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_Label monoFlat_Label2;
        private MonoFlat.MonoFlat_MenuButton moneyButton;
        private MonoFlat.MonoFlat_MenuButton clientsButton;
        private MonoFlat.MonoFlat_MenuButton zakupButton;
        private System.Windows.Forms.Panel mainPanel;
    }
}

