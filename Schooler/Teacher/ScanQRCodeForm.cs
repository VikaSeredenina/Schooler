using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Schooler.Teacher
{
    public partial class ScanQRCodeForm : Form
    {
        private MainTeacherForm teacherForm;
        private FilterInfoCollection CaptureDevice;
        private Image curImage;
        public ScanQRCodeForm(MainTeacherForm teacherForm)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;

            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (var device in CaptureDevice)
                CaptureDeviceComboBox.Items.Add(device);
            CaptureDeviceComboBox.SelectedItem = 1;
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Получаем изображение с веб-камеры
            Image image = (Bitmap)eventArgs.Frame.Clone();

            // Определяем размер PictureBox
            int pictureBoxWidth = CamPictureBox.Width;
            int pictureBoxHeight = CamPictureBox.Height;

            // Определяем размер полученного изображения
            int imageWidth = image.Width;
            int imageHeight = image.Height;

            // Масштабируем изображение, если оно не помещается в PictureBox
            if (imageWidth > pictureBoxWidth || imageHeight > pictureBoxHeight)
            {
                float aspectRatio = Math.Min((float)pictureBoxWidth / imageWidth, (float)pictureBoxHeight / imageHeight);
                int newWidth = (int)(imageWidth * aspectRatio);
                int newHeight = (int)(imageHeight * aspectRatio);
                Image scaledImage = image.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
                image.Dispose();
                image = scaledImage;
            }

            // Отображаем изображение на PictureBox
            CamPictureBox.Image = image;
            curImage = image;
        }

        private string RecognizeQRCode(string path)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            return decoder.Decode(new QRCodeBitmapImage(new Bitmap(path)));
        }

        private string RecognizeQRCode(Bitmap bmp)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            MessageBox.Show(decoder.Decode(new QRCodeBitmapImage(bmp)));
            return decoder.Decode(new QRCodeBitmapImage(bmp));
        }

        private void SelectQRCodeButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(RecognizeQRCode(ofd.FileName));
                    teacherForm.CheckSchoolboy(RecognizeQRCode(ofd.FileName));
                }
            }
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            RecognizeQRCode((Bitmap)curImage);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var FinalFrame = new VideoCaptureDevice(CaptureDevice[CaptureDeviceComboBox.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }
    }
}
