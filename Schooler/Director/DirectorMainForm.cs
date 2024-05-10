using Schooler.Database.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace Schooler.Director
{
    public partial class DirectorMainForm : Form
    {
        private _class curClass = null;
        public DirectorMainForm()
        {
            InitializeComponent();
        }

        private void DirectorMainForm_Load(object sender, EventArgs e)
        {
            UpdateSchoolboysDataGridView();
            UpdateClassesDataGridView();
            DefaultAttendense();
		}

        private void DefaultAttendense()
        {
            using (Database.Model.Context db = new Database.Model.Context())
            {
                // Задаем начальные значения
                ClassComboBox.DataSource = db.classes.ToList();
                ClassComboBox.DisplayMember = "name_class";
                curClass = (_class)ClassComboBox.SelectedItem;

                SchoolerComboBox.DataSource = db.schoolboys
                        .Where(x => x.id_class == curClass.id_class)
                        .ToList();
                SchoolerComboBox.DisplayMember = "surname";

                DayDateTimePicker.Value = DateTime.Now;

                // Отображаем информацию
                UpdateAttendense();
            }
        }

        /// <summary>
        /// Обновляет таблицу SchoolboysDataGridView
        /// </summary>
        private async void UpdateSchoolboysDataGridView()
        {
            using (Database.Model.Context db = new Database.Model.Context())
                SchoolboysDataGridView.DataSource = await db.schoolboys
                    .Include(x => x.attendances)
                    .Include(x => x._class)
                    .ToListAsync();
        }

        /// <summary>
        /// Обновляет таблицу ClassesDataGridView
        /// </summary>
        private async void UpdateClassesDataGridView()
        {
            using (Database.Model.Context db = new Database.Model.Context())
                ClassesDataGridView.DataSource = await db.classes
                    .Include(x => x.schoolboys)
                    .ToListAsync();
        }


		private void DirectorMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StateSingleton.getInstance().authForm.Close();
        }

        private void DirectorMainForm_Resize(object sender, EventArgs e)
        {
            SchoolboysDataGridViewPanel.Width = this.Width / 2;
            ClassesDataGridViewPanel.Width = this.Width / 2;
        }

        private void AddClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shared.EditClassForm ecf = new Shared.EditClassForm();
            ecf.FormClosed += Ecf_FormClosed;
            ecf.ShowDialog();
        }

        private void Ecf_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateClassesDataGridView();
        }

        /// <summary>
        /// Открытие формы изменения по двойному щелку на строку таблицы ClassesDataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClassesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(ClassesDataGridView.Rows[e.RowIndex].Cells["id_class"].Value.ToString());

            _class cCl = null;
            using (Database.Model.Context db = new Database.Model.Context())
                cCl = db.classes.Find(id);

            Shared.EditClassForm ecf = new Shared.EditClassForm(cCl);
            ecf.FormClosed += Ecf_FormClosed;
            ecf.ShowDialog();
        }

        /// <summary>
        /// Событие нажатия кнопки добавления нового учащегося из меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSchoolboyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Shared.EditSchoolboyForm esf = new Shared.EditSchoolboyForm();
            esf.FormClosed += Esf_FormClosed;
            esf.ShowDialog();
        }

        private void Esf_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateSchoolboysDataGridView();
        }

        /// <summary>
        /// Открытие формы изменения по двойному щелку на строку таблицы SchoolboysDataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SchoolboysDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid guid = Guid.Parse(SchoolboysDataGridView.Rows[e.RowIndex].Cells["guid"].Value.ToString());

            schoolboy sc = null;
            using (Database.Model.Context db = new Database.Model.Context())
                sc = db.schoolboys.Find(guid);

            Shared.EditSchoolboyForm esf = new Shared.EditSchoolboyForm(sc);
            esf.FormClosed += Esf_FormClosed;
            esf.ShowDialog();
        }

		/// <summary>
		/// Событие нажатия кнопки добавления нового предмета из меню
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>


        private void AttendenseDataChanged(object sender, EventArgs e)
        {
            UpdateAttendense();
        }


        private void UpdateAttendense()
        {
            using (Context db = new Context()) {

                // Поиск по всем
                if (AllSearchCheckBox.Checked)
                {
                    int classId = (int)(ClassComboBox.SelectedItem as _class).id_class;

                    var all = db.attendances
                        .Include(x => x.schoolboy)
                        .Where(x => x.schoolboy.id_class == classId
                        && x.data.Year == DayDateTimePicker.Value.Year
                        && x.data.Month == DayDateTimePicker.Value.Month
                        && x.data.Day == DayDateTimePicker.Value.Day)
                        .ToList();

                    AttendenseDataGridView.DataSource = all;
                        
                }
                // Поиск по ученику
                else
                {
                    int classId = (int)(ClassComboBox.SelectedItem as _class).id_class;
                    Guid sGuid = (SchoolerComboBox.SelectedItem as schoolboy).guid;

                    var all = db.attendances
                        .Include(x => x.schoolboy)
                        .Where(x => x.schoolboy.id_class == classId
                        && x.data.Year == DayDateTimePicker.Value.Year
                        && x.data.Month == DayDateTimePicker.Value.Month
                        && x.data.Day == DayDateTimePicker.Value.Day
                        && x.schoolboy.guid == sGuid)
                        .ToList();

                    AttendenseDataGridView.DataSource = all;
                }

            }
        }

        private void AllSearchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AllSearchCheckBox.Checked)
                SchoolerComboBox.Enabled = false;
            else SchoolerComboBox.Enabled = true;
            UpdateAttendense();
        }

        private void NoAttendanceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NoAttendanceCheckBox.Checked)
            {
                int classId = (int)(ClassComboBox.SelectedItem as _class).id_class;
                Guid sGuid = (SchoolerComboBox.SelectedItem as schoolboy).guid;

                using (Context db = new Context())
                {
                    var nonAtt = db.schoolboys
                        .Include(x => x.attendances)
                        .Include(x => x._class)
                        .Where(x => x.attendances
                            .Where(y => y.data.Year == DayDateTimePicker.Value.Year
                            && y.data.Month == DayDateTimePicker.Value.Month
                            && y.data.Day == DayDateTimePicker.Value.Day).ToList().Count == 0
                        )
                        .ToList();

                    AttendenseDataGridView.DataSource = nonAtt;
                }
            }
            else UpdateAttendense();
        }
    }
}
