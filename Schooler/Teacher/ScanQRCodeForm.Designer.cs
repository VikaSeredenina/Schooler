namespace Schooler.Teacher
{
    partial class ScanQRCodeForm
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
            this.SelectQRCodeButton = new System.Windows.Forms.Button();
            this.CamPictureBox = new System.Windows.Forms.PictureBox();
            this.ScanButton = new System.Windows.Forms.Button();
            this.CaptureDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.SchoolerImagePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CamPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolerImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectQRCodeButton
            // 
            this.SelectQRCodeButton.Location = new System.Drawing.Point(12, 350);
            this.SelectQRCodeButton.Name = "SelectQRCodeButton";
            this.SelectQRCodeButton.Size = new System.Drawing.Size(149, 23);
            this.SelectQRCodeButton.TabIndex = 0;
            this.SelectQRCodeButton.Text = "Сканировать из файла";
            this.SelectQRCodeButton.UseVisualStyleBackColor = true;
            this.SelectQRCodeButton.Click += new System.EventHandler(this.SelectQRCodeButton_Click);
            // 
            // CamPictureBox
            // 
            this.CamPictureBox.Location = new System.Drawing.Point(12, 12);
            this.CamPictureBox.Name = "CamPictureBox";
            this.CamPictureBox.Size = new System.Drawing.Size(502, 332);
            this.CamPictureBox.TabIndex = 1;
            this.CamPictureBox.TabStop = false;
            // 
            // ScanButton
            // 
            this.ScanButton.Location = new System.Drawing.Point(416, 350);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(98, 23);
            this.ScanButton.TabIndex = 2;
            this.ScanButton.Text = "Сканировать";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // CaptureDeviceComboBox
            // 
            this.CaptureDeviceComboBox.FormattingEnabled = true;
            this.CaptureDeviceComboBox.Location = new System.Drawing.Point(289, 350);
            this.CaptureDeviceComboBox.Name = "CaptureDeviceComboBox";
            this.CaptureDeviceComboBox.Size = new System.Drawing.Size(121, 21);
            this.CaptureDeviceComboBox.TabIndex = 3;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(208, 350);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SchoolerImagePictureBox
            // 
            this.SchoolerImagePictureBox.Location = new System.Drawing.Point(570, 12);
            this.SchoolerImagePictureBox.Name = "SchoolerImagePictureBox";
            this.SchoolerImagePictureBox.Size = new System.Drawing.Size(155, 138);
            this.SchoolerImagePictureBox.TabIndex = 5;
            this.SchoolerImagePictureBox.TabStop = false;
            // 
            // ScanQRCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 385);
            this.Controls.Add(this.SchoolerImagePictureBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CaptureDeviceComboBox);
            this.Controls.Add(this.ScanButton);
            this.Controls.Add(this.CamPictureBox);
            this.Controls.Add(this.SelectQRCodeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScanQRCodeForm";
            this.Text = "Сканировать QR-код";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScanQRCodeForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CamPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolerImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectQRCodeButton;
        private System.Windows.Forms.PictureBox CamPictureBox;
        private System.Windows.Forms.Button ScanButton;
        private System.Windows.Forms.ComboBox CaptureDeviceComboBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox SchoolerImagePictureBox;
    }
}