namespace Schooler.Teacher
{
    partial class MainTeacherForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentLessonLabel = new System.Windows.Forms.Label();
            this.ScanQRButton = new System.Windows.Forms.Button();
            this.SchoolboysDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolboysDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий урок:";
            // 
            // CurrentLessonLabel
            // 
            this.CurrentLessonLabel.AutoSize = true;
            this.CurrentLessonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentLessonLabel.Location = new System.Drawing.Point(166, 10);
            this.CurrentLessonLabel.Name = "CurrentLessonLabel";
            this.CurrentLessonLabel.Size = new System.Drawing.Size(16, 24);
            this.CurrentLessonLabel.TabIndex = 1;
            this.CurrentLessonLabel.Text = "-";
            // 
            // ScanQRButton
            // 
            this.ScanQRButton.Location = new System.Drawing.Point(12, 80);
            this.ScanQRButton.Name = "ScanQRButton";
            this.ScanQRButton.Size = new System.Drawing.Size(158, 23);
            this.ScanQRButton.TabIndex = 2;
            this.ScanQRButton.Text = "Сканировать QR-код";
            this.ScanQRButton.UseVisualStyleBackColor = true;
            this.ScanQRButton.Click += new System.EventHandler(this.ScanQRButton_Click);
            // 
            // SchoolboysDataGridView
            // 
            this.SchoolboysDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SchoolboysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchoolboysDataGridView.Location = new System.Drawing.Point(188, 80);
            this.SchoolboysDataGridView.Name = "SchoolboysDataGridView";
            this.SchoolboysDataGridView.ReadOnly = true;
            this.SchoolboysDataGridView.Size = new System.Drawing.Size(574, 400);
            this.SchoolboysDataGridView.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(188, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(574, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Все учащиеся";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(433, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Класс:";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassLabel.Location = new System.Drawing.Point(517, 11);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(16, 24);
            this.ClassLabel.TabIndex = 8;
            this.ClassLabel.Text = "-";
            // 
            // MainTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 492);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SchoolboysDataGridView);
            this.Controls.Add(this.ScanQRButton);
            this.Controls.Add(this.CurrentLessonLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainTeacherForm";
            this.Text = "Учитель";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainTeacherForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.SchoolboysDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentLessonLabel;
        private System.Windows.Forms.Button ScanQRButton;
        private System.Windows.Forms.DataGridView SchoolboysDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ClassLabel;
    }
}