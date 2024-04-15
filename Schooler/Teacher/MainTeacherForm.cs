using Schooler.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace Schooler.Teacher
{
    public partial class MainTeacherForm : Form
    {
        private _class curClass = null;
        private Dictionary<string, string> days = new Dictionary<string, string>();
        public MainTeacherForm()
        {
            InitializeComponent();
            days.Add("Monday", "Понедельник");
            days.Add("Tuesday", "Вторник");
            days.Add("Wednesday", "Среда");
            days.Add("Thursday", "Четверг");
            days.Add("Friday", "Пятница");
            days.Add("Saturday", "Суббота");
            days.Add("Sunday", "Воскресенье");
        }

        public async void CheckSchoolboy(string guid)
        {
            using (Database.Model.Context db = new Database.Model.Context())
            {
                // Получаем учащегося
                var sc = await db.schoolboy
                    .FindAsync(Guid.Parse(guid));

                // Определяем класс и текущий урок
                curClass = sc._class;
                var curLesson = sc._class.lesson
                    .Where(x => (x.id_class == sc.id_class) 
                    && (x.start_time < DateTime.Now.TimeOfDay 
                    && x.end_time > DateTime.Now.TimeOfDay)
                    && (x.day == days[DateTime.Now.DayOfWeek.ToString()]))
                    .FirstOrDefault();

                if (curLesson == null)
                {
                    CurrentLessonLabel.Text = "нет";
                    return;
                }

                if (sc._class.id_class != curClass.id_class)
                {
                    MessageBox.Show($"Ученик не входит в класс {curClass.name_class}!");
                    return;
                }

                // Если сейчас идет урок, то выгружаем список класса
                if (SchoolboysDataGridView.RowCount == 0)
                    SchoolboysDataGridView.DataSource = db.schoolboy
                        .Include(x => x.attendance)
                        .Include(x => x.QRKod)
                        .Include(x => x._class)
                        .Where(x => x.id_class == curClass.id_class)
                        .ToList();

                CurrentLessonLabel.Text = curLesson.name_predmet;
                ClassLabel.Text = curClass.name_class;
        
                AddSchoolBoyAttendense(sc.guid, curLesson.id_lesson);
                ChangeColorAttendeseSchoolboy(sc.guid);
            }
        }

        private void ChangeColorAttendeseSchoolboy(Guid guid)
        {
            foreach (DataGridViewRow row in SchoolboysDataGridView.Rows)
                if (row.Cells["guid"].Value.ToString().Equals(guid.ToString()))
                    SchoolboysDataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.Green;
        }

        private void AddSchoolBoyAttendense(Guid guid, long id_lesson)
        {
            using (Database.Model.Context db = new Context())
            {
                attendance att = new attendance();
                att.status = true;
                att.guid_schoolboy = guid;
                att.id_lesson = id_lesson;
                att.time_of_entry = DateTime.Now;

                db.attendance.Add(att);
                db.SaveChanges();
            }
        }

        private void ScanQRButton_Click(object sender, EventArgs e)
        {
            ScanQRCodeForm scf = new ScanQRCodeForm();
            scf.ShowDialog();
        }

        private void MainTeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StateSingleton.getInstance().authForm.Close();
        }

        private void UpdateAttendenseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
