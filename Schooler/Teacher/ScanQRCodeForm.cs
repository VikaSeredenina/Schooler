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
            string result = string.Empty;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    result = RecognizeQRCode(ofd.FileName);
                }
            }

            using (Database.Model.Context db = new Database.Model.Context())
            {
                Guid guid = Guid.Parse(result);
                var cAttendance = db.attendances
                    .Where(x => x.arrival_time.Value.Year == DateTime.Now.Year
                    && x.arrival_time.Value.Month == DateTime.Now.Month
                    && x.arrival_time.Value.Day == DateTime.Now.Day
                    && x.guid == guid)
                    .FirstOrDefault();

                if (cAttendance == null)
                {

                    attendance nAttendance = new attendance();
                    nAttendance.status = true;
                    nAttendance.guid = Guid.Parse(result);
                    nAttendance.data = DateTime.Now.Date;
                    nAttendance.arrival_time = DateTime.Now;

                    db.attendances.Add(nAttendance);
                }
                else
                {
                    cAttendance.time_of_departure = DateTime.Now;
                }
                db.SaveChanges();
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
                Guid guid = Guid.Parse(result);

                var cAttendance = db.attendances
                    .Where(x => x.arrival_time.Value.Year == DateTime.Now.Year
                    && x.arrival_time.Value.Month == DateTime.Now.Month
                    && x.arrival_time.Value.Day == DateTime.Now.Day
                    && x.guid == guid)
                    .FirstOrDefault();

                if (cAttendance == null)
                {

                    attendance nAttendance = new attendance();
                    nAttendance.status = true;
                    nAttendance.guid = Guid.Parse(result);
                    nAttendance.data = DateTime.Now.Date;
                    nAttendance.arrival_time = DateTime.Now;

                    db.attendances.Add(nAttendance);
                }
                else
                {
                    cAttendance.time_of_departure = DateTime.Now;
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
