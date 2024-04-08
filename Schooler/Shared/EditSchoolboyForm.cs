using MessagingToolkit.QRCode.Codec;
using Schooler.Database.Model;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Windows.Forms;

namespace Schooler.Shared
{
    public partial class EditSchoolboyForm : Form
    {
        private schoolboy schoolboy = null;
        public EditSchoolboyForm()
        {
            InitializeComponent();
        }
        
        public EditSchoolboyForm(schoolboy schoolboy)
        {
            InitializeComponent();
            this.schoolboy = schoolboy;
            this.Text = "Редактировать учащегося";
            this.EditButton.Text = "Изменить";
        }

        private void EditSchoolboyForm_Load(object sender, EventArgs e)
        {
            FillClasses();
            if (schoolboy != null)
            {
                FillInfo();
                GetQRCode();
            }
        }

        private async void FillClasses()
        {
            using (Database.Model.Context db = new Context())
                ClassComboBox.DataSource = await db._class.ToListAsync();
            ClassComboBox.DisplayMember = "name_class";
        }

        private void FillInfo()
        {
            SurnameTextBox.Text = schoolboy.surname;
            NameTextBox.Text = schoolboy.name;
            PatronymicTextBox.Text = schoolboy.patronymic;
            BirthDateTimePicker.Value = schoolboy.date_of_birth;
            PhoneMaskedTextBox.Text = schoolboy.contacts;
        }

        // Отображение QR-кода при условии, что запись об учащемся уже существует
        private void GetQRCode()
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrCode = encoder.Encode(schoolboy.guid.ToString());
            QRPictureBox.Image = qrCode;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Добавление
            if (schoolboy == null)
            {
                Database.Model.schoolboy sc = new schoolboy();
                sc.guid = Guid.NewGuid();
                sc.surname = SurnameTextBox.Text;
                sc.name = NameTextBox.Text;
                sc.patronymic = PatronymicTextBox.Text;
                sc.date_of_birth = BirthDateTimePicker.Value;
                sc.contacts = PhoneMaskedTextBox.Text;
                sc.id_class = (ClassComboBox.SelectedItem as _class).id_class;

                using (Database.Model.Context db = new Context())
                {
                    db.schoolboy.Add(sc);
                    db.SaveChanges();
                }
            }
            // Изменение
            else
            {
                using (Database.Model.Context db = new Context())
                {
                    var cSc = db.schoolboy.Find(schoolboy.guid);

                    cSc.surname = SurnameTextBox.Text;
                    cSc.name = NameTextBox.Text;
                    cSc.patronymic = PatronymicTextBox.Text;
                    cSc.date_of_birth = BirthDateTimePicker.Value;
                    cSc.contacts = PhoneMaskedTextBox.Text;
                    cSc.id_class = (ClassComboBox.SelectedItem as _class).id_class;

                    db.SaveChanges();
                }
            }
            this.Close();
        }
    }
}
