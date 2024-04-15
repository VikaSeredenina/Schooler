using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Schooler.Database.Model;
using System.Linq;
using System.Data.Entity.Core.Objects;

namespace Schooler.Teacher
{
    public partial class ScanQRCodeForm : Form
    {
        private FilterInfoCollection CaptureDevice;
        private Image curImage;
        private VideoCaptureDevice FinalFrame;
        public ScanQRCodeForm()
        {
            InitializeComponent();

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
                }
            }
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            try
            {
                result = RecognizeQRCode((Bitmap)curImage);
            }
            catch { MessageBox.Show("QR-код не распознан, попробуйте еще раз!"); return;  }

            using (Database.Model.Context db = new Database.Model.Context())
            {
                var cAttendance = db.attendance
                    .Where(x => x.time_of_entry.Year == DateTime.Now.Year
                    && x.time_of_entry.Month == DateTime.Now.Month
                    && x.time_of_entry.Day == DateTime.Now.Day)
                    .FirstOrDefault();

                if (cAttendance == null)
                {

                    attendance nAttendance = new attendance();
                    nAttendance.status = true;
                    nAttendance.id_lesson = 1;
                    nAttendance.guid_schoolboy = Guid.Parse(result);
                    nAttendance.time_of_entry = DateTime.Now;

                    db.attendance.Add(nAttendance);
                }
                else
                {
                    cAttendance.time_of_deportation = DateTime.Now;
                }
                db.SaveChanges();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[CaptureDeviceComboBox.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void ScanQRCodeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FinalFrame.Stop();
        }
    }
}
