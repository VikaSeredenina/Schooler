﻿using Schooler.Database.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
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
                ClassComboBox.DataSource = db._class.ToList();
                ClassComboBox.DisplayMember = "name_class";
                curClass = (_class)ClassComboBox.SelectedItem;

                DayDateTimePicker.Value = DateTime.Now;

                // Отображаем информацию
                UpdateAttendense();
            }
        }

        private void UpdateAttendense()
        {
            using (Database.Model.Context db = new Context())
            {
                var attendance = db.attendance
                        .Where(x => x.id_lesson == 1
                        && EntityFunctions.TruncateTime(x.time_of_entry) == DayDateTimePicker.Value.Date)
                        .Include(x => x.schoolboy)
                        .Include(x => x.lesson)
                        .ToList();

                List<AttendanceInfo> attendanceInfos = new List<AttendanceInfo>();

                foreach (var att in attendance)
                    attendanceInfos.Add(
                        new AttendanceInfo { FullName = $"{att.schoolboy.surname} {att.schoolboy.name} {att.schoolboy.patronymic}", start = att.time_of_entry, end = att.time_of_deportation }
                        );

                AttendenseDataGridView.DataSource = attendanceInfos;
            }
        }

        /// <summary>
        /// Обновляет таблицу SchoolboysDataGridView
        /// </summary>
        private async void UpdateSchoolboysDataGridView()
        {
            using (Database.Model.Context db = new Database.Model.Context())
                SchoolboysDataGridView.DataSource = await db.schoolboy
                    .Include(x => x.attendance)
                    .Include(x => x._class)
                    .Include(x => x.QRKod)
                    .ToListAsync();
        }

        /// <summary>
        /// Обновляет таблицу ClassesDataGridView
        /// </summary>
        private async void UpdateClassesDataGridView()
        {
            using (Database.Model.Context db = new Database.Model.Context())
                ClassesDataGridView.DataSource = await db._class
                    .Include(x => x.schoolboy)
                    .Include(x => x.lesson)
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
                cCl = db._class.Find(id);

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
                sc = db.schoolboy.Find(guid);

            Shared.EditSchoolboyForm esf = new Shared.EditSchoolboyForm(sc);
            esf.FormClosed += Esf_FormClosed;
            esf.ShowDialog();
        }

		/// <summary>
		/// Событие нажатия кнопки добавления нового предмета из меню
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Shared.EditLessonForm elf = new Shared.EditLessonForm();
			elf.FormClosed += Elf_FormClosed;
			elf.ShowDialog();
		}

		private void Elf_FormClosed(object sender, FormClosedEventArgs e)
		{
            //UpdateLessonDataGridView();
		}


        private void AttendenseDataChanged(object sender, EventArgs e)
        {
            UpdateAttendense();
        }
    }
}
