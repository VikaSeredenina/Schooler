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
            StateSingleton.getInstance().connectionString =
                $"Data Source=DESKTOP-QL85CJN\\SQLEXPRESS;Initial Catalog=schollers;User ID={UsernameTextBox.Text};Password={PasswordTextBox.Text};Integrated Security=True;Encrypt=False";
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
			using (Database.Model.Context db = new Database.Model.Context())
            {
                try
                {
                    if (db.Database.SqlQuery<int>("SELECT IS_MEMBER('DIRECTORY')").FirstOrDefault() == 0)
                        StateSingleton.getInstance().authState = AuthState.Director;
                    else if (db.Database.SqlQuery<int>("SELECT IS_MEMBER('ADMINISTRATOR')").FirstOrDefault() == 1)
                        StateSingleton.getInstance().authState = AuthState.Sysadmin;

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
                default:
                    break;
            }

        }

        private void OpenQRFormButton_Click(object sender, EventArgs e)
        {
            Teacher.ScanQRCodeForm scf = new Teacher.ScanQRCodeForm();
            scf.ShowDialog();
        }
    }
}
