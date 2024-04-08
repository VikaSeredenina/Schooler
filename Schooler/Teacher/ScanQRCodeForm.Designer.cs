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
            ((System.ComponentModel.ISupportInitialize)(this.CamPictureBox)).BeginInit();
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
            // ScanQRCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 385);
            this.Controls.Add(this.ScanButton);
            this.Controls.Add(this.CamPictureBox);
            this.Controls.Add(this.SelectQRCodeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScanQRCodeForm";
            this.Text = "Сканировать QR-код";
            ((System.ComponentModel.ISupportInitialize)(this.CamPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectQRCodeButton;
        private System.Windows.Forms.PictureBox CamPictureBox;
        private System.Windows.Forms.Button ScanButton;
    }
}