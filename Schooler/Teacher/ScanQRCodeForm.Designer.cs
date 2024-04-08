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
            // ScanQRCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 385);
            this.Controls.Add(this.SelectQRCodeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScanQRCodeForm";
            this.Text = "Сканировать QR-код";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectQRCodeButton;
    }
}