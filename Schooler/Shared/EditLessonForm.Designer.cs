namespace Schooler.Shared
{
	partial class EditLessonForm
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
			this.EditButton = new System.Windows.Forms.Button();
			this.TeacherTextBox = new System.Windows.Forms.TextBox();
			this.NameLessonTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.NameLes = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.DayComboBox1 = new System.Windows.Forms.ComboBox();
			this.StartTimedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.EndTimedateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.ClasscomboBox2 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(208, 274);
			this.EditButton.Margin = new System.Windows.Forms.Padding(4);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(100, 28);
			this.EditButton.TabIndex = 9;
			this.EditButton.Text = "Добавить";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// TeacherTextBox
			// 
			this.TeacherTextBox.Location = new System.Drawing.Point(208, 62);
			this.TeacherTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.TeacherTextBox.Name = "TeacherTextBox";
			this.TeacherTextBox.Size = new System.Drawing.Size(217, 22);
			this.TeacherTextBox.TabIndex = 8;
			// 
			// NameLessonTextBox
			// 
			this.NameLessonTextBox.Location = new System.Drawing.Point(208, 25);
			this.NameLessonTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.NameLessonTextBox.Name = "NameLessonTextBox";
			this.NameLessonTextBox.Size = new System.Drawing.Size(217, 22);
			this.NameLessonTextBox.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 65);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Учитель";
			// 
			// NameLes
			// 
			this.NameLes.AutoSize = true;
			this.NameLes.Location = new System.Drawing.Point(19, 28);
			this.NameLes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NameLes.Name = "NameLes";
			this.NameLes.Size = new System.Drawing.Size(173, 16);
			this.NameLes.TabIndex = 5;
			this.NameLes.Text = "Наименование предмета";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 100);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "День недели";
			// 
			// DayComboBox1
			// 
			this.DayComboBox1.FormattingEnabled = true;
			this.DayComboBox1.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
			this.DayComboBox1.Location = new System.Drawing.Point(208, 100);
			this.DayComboBox1.Name = "DayComboBox1";
			this.DayComboBox1.Size = new System.Drawing.Size(217, 24);
			this.DayComboBox1.TabIndex = 11;
			// 
			// StartTimedateTimePicker1
			// 
			this.StartTimedateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.StartTimedateTimePicker1.Location = new System.Drawing.Point(208, 139);
			this.StartTimedateTimePicker1.Name = "StartTimedateTimePicker1";
			this.StartTimedateTimePicker1.Size = new System.Drawing.Size(217, 22);
			this.StartTimedateTimePicker1.TabIndex = 12;
			this.StartTimedateTimePicker1.Value = new System.DateTime(2024, 4, 8, 19, 5, 0, 0);
			// 
			// EndTimedateTimePicker2
			// 
			this.EndTimedateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.EndTimedateTimePicker2.Location = new System.Drawing.Point(208, 177);
			this.EndTimedateTimePicker2.Name = "EndTimedateTimePicker2";
			this.EndTimedateTimePicker2.Size = new System.Drawing.Size(217, 22);
			this.EndTimedateTimePicker2.TabIndex = 13;
			this.EndTimedateTimePicker2.Value = new System.DateTime(2024, 4, 8, 19, 5, 0, 0);
			// 
			// ClasscomboBox2
			// 
			this.ClasscomboBox2.FormattingEnabled = true;
			this.ClasscomboBox2.Location = new System.Drawing.Point(208, 213);
			this.ClasscomboBox2.Name = "ClasscomboBox2";
			this.ClasscomboBox2.Size = new System.Drawing.Size(123, 24);
			this.ClasscomboBox2.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 139);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 16);
			this.label4.TabIndex = 15;
			this.label4.Text = "Время начала";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 177);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 16);
			this.label5.TabIndex = 16;
			this.label5.Text = "Время окончания";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 216);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 16);
			this.label6.TabIndex = 17;
			this.label6.Text = "Класс";
			// 
			// EditLessonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 406);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ClasscomboBox2);
			this.Controls.Add(this.EndTimedateTimePicker2);
			this.Controls.Add(this.StartTimedateTimePicker1);
			this.Controls.Add(this.DayComboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.TeacherTextBox);
			this.Controls.Add(this.NameLessonTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NameLes);
			this.Name = "EditLessonForm";
			this.Text = "EditLessonForm";
			this.Load += new System.EventHandler(this.EditLessonForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.TextBox TeacherTextBox;
		private System.Windows.Forms.TextBox NameLessonTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label NameLes;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox DayComboBox1;
		private System.Windows.Forms.DateTimePicker StartTimedateTimePicker1;
		private System.Windows.Forms.DateTimePicker EndTimedateTimePicker2;
		private System.Windows.Forms.ComboBox ClasscomboBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}