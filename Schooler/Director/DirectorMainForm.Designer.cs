namespace Schooler.Director
{
    partial class DirectorMainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SchoolboysDataGridViewPanel = new System.Windows.Forms.Panel();
            this.SchoolboysDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ClassesDataGridViewPanel = new System.Windows.Forms.Panel();
            this.ClassesDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LessonDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.учащиесяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.классыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.урокиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.LessonComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AttendenseDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SchoolboysDataGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolboysDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.ClassesDataGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassesDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LessonDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendenseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 425);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SchoolboysDataGridViewPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(864, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Учащиеся";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SchoolboysDataGridViewPanel
            // 
            this.SchoolboysDataGridViewPanel.Controls.Add(this.SchoolboysDataGridView);
            this.SchoolboysDataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SchoolboysDataGridViewPanel.Location = new System.Drawing.Point(3, 3);
            this.SchoolboysDataGridViewPanel.Name = "SchoolboysDataGridViewPanel";
            this.SchoolboysDataGridViewPanel.Size = new System.Drawing.Size(412, 393);
            this.SchoolboysDataGridViewPanel.TabIndex = 0;
            // 
            // SchoolboysDataGridView
            // 
            this.SchoolboysDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SchoolboysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchoolboysDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SchoolboysDataGridView.Location = new System.Drawing.Point(0, 0);
            this.SchoolboysDataGridView.Name = "SchoolboysDataGridView";
            this.SchoolboysDataGridView.ReadOnly = true;
            this.SchoolboysDataGridView.RowHeadersWidth = 51;
            this.SchoolboysDataGridView.Size = new System.Drawing.Size(412, 393);
            this.SchoolboysDataGridView.TabIndex = 0;
            this.SchoolboysDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SchoolboysDataGridView_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ClassesDataGridViewPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(864, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Классы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ClassesDataGridViewPanel
            // 
            this.ClassesDataGridViewPanel.Controls.Add(this.ClassesDataGridView);
            this.ClassesDataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClassesDataGridViewPanel.Location = new System.Drawing.Point(3, 3);
            this.ClassesDataGridViewPanel.Name = "ClassesDataGridViewPanel";
            this.ClassesDataGridViewPanel.Size = new System.Drawing.Size(365, 393);
            this.ClassesDataGridViewPanel.TabIndex = 0;
            // 
            // ClassesDataGridView
            // 
            this.ClassesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ClassesDataGridView.Name = "ClassesDataGridView";
            this.ClassesDataGridView.ReadOnly = true;
            this.ClassesDataGridView.RowHeadersWidth = 51;
            this.ClassesDataGridView.Size = new System.Drawing.Size(365, 393);
            this.ClassesDataGridView.TabIndex = 0;
            this.ClassesDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassesDataGridView_CellContentDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LessonDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(864, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Уроки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LessonDataGridView
            // 
            this.LessonDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LessonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LessonDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LessonDataGridView.Location = new System.Drawing.Point(0, 0);
            this.LessonDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LessonDataGridView.Name = "LessonDataGridView";
            this.LessonDataGridView.ReadOnly = true;
            this.LessonDataGridView.RowHeadersWidth = 51;
            this.LessonDataGridView.RowTemplate.Height = 24;
            this.LessonDataGridView.Size = new System.Drawing.Size(864, 399);
            this.LessonDataGridView.TabIndex = 0;
            this.LessonDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LessonDataGridView_CellContentDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 25);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учащиесяToolStripMenuItem,
            this.классыToolStripMenuItem,
            this.урокиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // учащиесяToolStripMenuItem
            // 
            this.учащиесяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1});
            this.учащиесяToolStripMenuItem.Name = "учащиесяToolStripMenuItem";
            this.учащиесяToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.учащиесяToolStripMenuItem.Text = "Учащиеся";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.AddSchoolboyToolStripMenuItem1_Click);
            // 
            // классыToolStripMenuItem
            // 
            this.классыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.классыToolStripMenuItem.Name = "классыToolStripMenuItem";
            this.классыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.классыToolStripMenuItem.Text = "Классы";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AddClassToolStripMenuItem_Click);
            // 
            // урокиToolStripMenuItem
            // 
            this.урокиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem2});
            this.урокиToolStripMenuItem.Name = "урокиToolStripMenuItem";
            this.урокиToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.урокиToolStripMenuItem.Text = "Уроки";
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            this.добавитьToolStripMenuItem2.Click += new System.EventHandler(this.добавитьToolStripMenuItem2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.AttendenseDataGridView);
            this.tabPage4.Controls.Add(this.DayDateTimePicker);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.LessonComboBox);
            this.tabPage4.Controls.Add(this.ClassComboBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(864, 399);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Посещаемость";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(111, 12);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassComboBox.TabIndex = 0;
            this.ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.AttendenseDataChanged);
            // 
            // LessonComboBox
            // 
            this.LessonComboBox.FormattingEnabled = true;
            this.LessonComboBox.Location = new System.Drawing.Point(111, 39);
            this.LessonComboBox.Name = "LessonComboBox";
            this.LessonComboBox.Size = new System.Drawing.Size(121, 21);
            this.LessonComboBox.TabIndex = 1;
            this.LessonComboBox.SelectedIndexChanged += new System.EventHandler(this.AttendenseDataChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Класс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата";
            // 
            // DayDateTimePicker
            // 
            this.DayDateTimePicker.Location = new System.Drawing.Point(111, 69);
            this.DayDateTimePicker.Name = "DayDateTimePicker";
            this.DayDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.DayDateTimePicker.TabIndex = 6;
            this.DayDateTimePicker.ValueChanged += new System.EventHandler(this.AttendenseDataChanged);
            // 
            // AttendenseDataGridView
            // 
            this.AttendenseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AttendenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendenseDataGridView.Location = new System.Drawing.Point(238, 12);
            this.AttendenseDataGridView.Name = "AttendenseDataGridView";
            this.AttendenseDataGridView.ReadOnly = true;
            this.AttendenseDataGridView.Size = new System.Drawing.Size(618, 379);
            this.AttendenseDataGridView.TabIndex = 7;
            // 
            // DirectorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DirectorMainForm";
            this.Text = "Директор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DirectorMainForm_FormClosed);
            this.Load += new System.EventHandler(this.DirectorMainForm_Load);
            this.Resize += new System.EventHandler(this.DirectorMainForm_Resize);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.SchoolboysDataGridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SchoolboysDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ClassesDataGridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassesDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LessonDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendenseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel SchoolboysDataGridViewPanel;
        private System.Windows.Forms.DataGridView SchoolboysDataGridView;
        private System.Windows.Forms.Panel ClassesDataGridViewPanel;
        private System.Windows.Forms.DataGridView ClassesDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem учащиесяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataGridView LessonDataGridView;
		private System.Windows.Forms.ToolStripMenuItem урокиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LessonComboBox;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.DateTimePicker DayDateTimePicker;
        private System.Windows.Forms.DataGridView AttendenseDataGridView;
    }
}