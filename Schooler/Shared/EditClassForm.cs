using Schooler.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schooler.Shared
{
    public partial class EditClassForm : Form
    {
        private _class cl = null;
        public EditClassForm()
        {
            InitializeComponent();
        }

        public EditClassForm( _class cl )
        {
            InitializeComponent();
            this.cl = cl;
            this.EditButton.Text = "Изменить";
            this.Text = "Редактировать класс";
        }

        private void EditClassForm_Load(object sender, EventArgs e)
        {
            if (cl != null)
                FillInfo();
        }

        private void FillInfo()
        {
            ClassNameTextBox.Text = cl.name_class;
            ClassroomTeacherTextBox.Text = cl.classroom_teacher;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Добавление
            if (cl == null)
            {
                _class nCl = new _class();
                nCl.classroom_teacher = ClassroomTeacherTextBox.Text;
                nCl.name_class = ClassNameTextBox.Text;

                using (Database.Model.Context db = new Context())
                {
                    db._class.Add(nCl);
                    db.SaveChanges();
                }
            }
            // Изменение
            else
            {
                using (Database.Model.Context db = new Context())
                {
                    var cCl = db._class.Find(cl.id_class);

                    cCl.classroom_teacher = ClassroomTeacherTextBox.Text;
                    cCl.name_class = ClassNameTextBox.Text;

                    db.SaveChanges();
                }
            }
            this.Close();
        }
    }
}
