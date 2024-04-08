namespace Schooler.Shared
{
    partial class EditClassForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.ClassNameTextBox = new System.Windows.Forms.TextBox();
            this.ClassroomTeacherTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование класса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Классный руководитель";
            // 
            // ClassNameTextBox
            // 
            this.ClassNameTextBox.Location = new System.Drawing.Point(154, 25);
            this.ClassNameTextBox.Name = "ClassNameTextBox";
            this.ClassNameTextBox.Size = new System.Drawing.Size(47, 20);
            this.ClassNameTextBox.TabIndex = 2;
            // 
            // ClassroomTeacherTextBox
            // 
            this.ClassroomTeacherTextBox.Location = new System.Drawing.Point(154, 55);
            this.ClassroomTeacherTextBox.Name = "ClassroomTeacherTextBox";
            this.ClassroomTeacherTextBox.Size = new System.Drawing.Size(164, 20);
            this.ClassroomTeacherTextBox.TabIndex = 3;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(167, 87);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Добавить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // EditClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 122);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ClassroomTeacherTextBox);
            this.Controls.Add(this.ClassNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditClassForm";
            this.Text = "Добавить класс";
            this.Load += new System.EventHandler(this.EditClassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassNameTextBox;
        private System.Windows.Forms.TextBox ClassroomTeacherTextBox;
        private System.Windows.Forms.Button EditButton;
    }
}