namespace Schooler.Shared
{
    partial class EditSchoolboyForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QRCodeGroupBox = new System.Windows.Forms.GroupBox();
            this.QRPictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.QRCodeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClassComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PhoneMaskedTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BirthDateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PatronymicTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SurnameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о учащемся";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(429, 220);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Добавить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(160, 137);
            this.PhoneMaskedTextBox.Mask = "00000000000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(77, 20);
            this.PhoneMaskedTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Номер телефона";
            // 
            // BirthDateTimePicker
            // 
            this.BirthDateTimePicker.Location = new System.Drawing.Point(98, 106);
            this.BirthDateTimePicker.Name = "BirthDateTimePicker";
            this.BirthDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.BirthDateTimePicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата рождения";
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(68, 80);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(169, 20);
            this.PatronymicTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(68, 54);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(169, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(68, 28);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(169, 20);
            this.SurnameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // QRCodeGroupBox
            // 
            this.QRCodeGroupBox.Controls.Add(this.QRPictureBox);
            this.QRCodeGroupBox.Location = new System.Drawing.Point(280, 12);
            this.QRCodeGroupBox.Name = "QRCodeGroupBox";
            this.QRCodeGroupBox.Size = new System.Drawing.Size(227, 202);
            this.QRCodeGroupBox.TabIndex = 1;
            this.QRCodeGroupBox.TabStop = false;
            this.QRCodeGroupBox.Text = "QR-код";
            // 
            // QRPictureBox
            // 
            this.QRPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QRPictureBox.Location = new System.Drawing.Point(3, 16);
            this.QRPictureBox.Name = "QRPictureBox";
            this.QRPictureBox.Size = new System.Drawing.Size(221, 183);
            this.QRPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.QRPictureBox.TabIndex = 0;
            this.QRPictureBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Класс";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(116, 163);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassComboBox.TabIndex = 11;
            // 
            // EditSchoolboyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 252);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.QRCodeGroupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSchoolboyForm";
            this.Text = "Добавить учащегося";
            this.Load += new System.EventHandler(this.EditSchoolboyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.QRCodeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QRPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker BirthDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox QRCodeGroupBox;
        private System.Windows.Forms.PictureBox QRPictureBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.Label label6;
    }
}