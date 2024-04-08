using Schooler.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schooler.Shared
{
	public partial class EditLessonForm : Form
	{
		private lesson lesson = null;
		public EditLessonForm()
		{
			InitializeComponent();
		}


		public EditLessonForm(lesson lesson)
		{
			InitializeComponent();
			this.lesson = lesson;
			this.Text = "Редактировать предмет";
			this.EditButton.Text = "Изменить";
		}


		private void EditButton_Click(object sender, EventArgs e)
		{
			// Добавление
			if (lesson == null)
			{
				Database.Model.lesson ls = new lesson();
				ls.name_predmet = NameLessonTextBox.Text;
				ls.teacher = TeacherTextBox.Text;
				ls.day = DayComboBox1.Text;
				ls.start_time = TimeSpan.Parse(StartTimedateTimePicker1.Value.ToString("hh:mm:ss"));
				ls.end_time = TimeSpan.Parse(EndTimedateTimePicker2.Value.ToString("hh:mm:ss"));
				ls.id_class = (ClasscomboBox2.SelectedItem as _class).id_class;

				using (Database.Model.Context db = new Context())
				{
					db.lesson.Add(ls);
					db.SaveChanges();
				}
			}
			// Изменение
			else
			{
				using (Database.Model.Context db = new Context())
				{
					var LeS = db.lesson.Find(lesson.id_lesson);

					LeS.name_predmet = NameLessonTextBox.Text;
					LeS.teacher = TeacherTextBox.Text;
					LeS.day = DayComboBox1.Text;
					LeS.start_time = TimeSpan.Parse(StartTimedateTimePicker1.Value.ToString("hh:mm:ss"));
					LeS.end_time = TimeSpan.Parse(EndTimedateTimePicker2.Value.ToString("hh:mm:ss"));
					LeS.id_class = (ClasscomboBox2.SelectedItem as _class).id_class;

					db.SaveChanges();
				}
			}
			this.Close();
		}

		private void EditLessonForm_Load(object sender, EventArgs e)
		{
			FillClasses();
			if (lesson != null)
				FillInfo();
		}

		private async void FillClasses()
		{
			using (Database.Model.Context db = new Context())
				ClasscomboBox2.DataSource = await db._class.ToListAsync();
			ClasscomboBox2.DisplayMember = "name_class";
		}
		private void FillInfo()
		{
			NameLessonTextBox.Text = lesson.name_predmet;
			TeacherTextBox.Text = lesson.teacher;
			DayComboBox1.Text = lesson.day;
			StartTimedateTimePicker1.Value = DateTime.Today + lesson.start_time;
			EndTimedateTimePicker2.Value = DateTime.Today + lesson.end_time;
		}
	}
}
