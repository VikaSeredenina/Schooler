using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schooler
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            StateSingleton.getInstance().authForm = this;
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            // Устанавливаем контекст подключения
            StateSingleton.getInstance().connectionString =
                $"Data Source=CompV;Initial Catalog=schollers;Integrated Security=True;User ID={UsernameTextBox.Text};Password={PasswordTextBox.Text};encrypt=False";
			



			using (Database.Model.Context db = new Database.Model.Context())
            {
                try
                {
                    if (db.Database.SqlQuery<int>("SELECT IS_MEMBER('DIRECTORY')").First() == 0)
                        StateSingleton.getInstance().authState = AuthState.Director;
                    else if (db.Database.SqlQuery<int>("SELECT IS_MEMBER('ADMINISTRATOR')").First() == 1)
                        StateSingleton.getInstance().authState = AuthState.Sysadmin;
                    else if (db.Database.SqlQuery<int>("SELECT IS_MEMBER('TEACHER')").First() == 1)
                        StateSingleton.getInstance().authState = AuthState.Teacher;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
;                    StateSingleton.getInstance().authState = AuthState.NonAuth;
                }
            }

            // Открытие определенной формы в зависимости от роли пользователя
            switch (StateSingleton.getInstance().authState)
            {
                case AuthState.NonAuth:
                    MessageBox.Show("Вы не зарегистрированы");
                    break;
                case AuthState.Sysadmin:
                    MessageBox.Show("Вы сисадмин");
                    break;
                case AuthState.Director:
                    Director.DirectorMainForm dmf = new Director.DirectorMainForm();
                    dmf.Show();
                    this.Hide();
                    break;
                case AuthState.Teacher:
                    Teacher.MainTeacherForm mtf = new Teacher.MainTeacherForm();
                    mtf.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }

        }
    }
}
