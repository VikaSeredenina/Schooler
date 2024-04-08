using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Schooler.Teacher
{
    public partial class ScanQRCodeForm : Form
    {
        private MainTeacherForm teacherForm;
        public ScanQRCodeForm(MainTeacherForm teacherForm)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
        }
        
        private string RecognizeQRCode(string path)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            return decoder.Decode(new QRCodeBitmapImage(new Bitmap(path)));
        }

        private void SelectQRCodeButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    teacherForm.CheckSchoolboy(RecognizeQRCode(ofd.FileName));
                }
            }
        }
    }
}
