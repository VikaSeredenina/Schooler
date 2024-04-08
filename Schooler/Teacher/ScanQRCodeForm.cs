using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading;
using System.Drawing.Imaging;
using System.Security.Cryptography;

namespace Schooler.Teacher
{
    public partial class ScanQRCodeForm : Form
    {
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = false;

        private MainTeacherForm teacherForm;
        public ScanQRCodeForm(MainTeacherForm teacherForm)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture = new VideoCapture(CaptureDevice.Any);
            capture.Open(1);

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {

                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    if (CamPictureBox.Image != null)
                    {
                        CamPictureBox.Image.Dispose();
                    }
                    CamPictureBox.Image = image;
                }
            }
        }

        private string RecognizeQRCode(string path)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            return decoder.Decode(new QRCodeBitmapImage(new Bitmap(path)));
        }

        private string RecognizeQRCode(Bitmap bmp)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            return decoder.Decode(new QRCodeBitmapImage(bmp));
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

        private void ScanButton_Click(object sender, EventArgs e)
        {
            if (isCameraRunning)
            {
                // Take snapshot of the current image generate by OpenCV in the Picture Box
                Bitmap snapshot = new Bitmap(CamPictureBox.Image);
                teacherForm.CheckSchoolboy(RecognizeQRCode(snapshot));
            }
            else
            {
                MessageBox.Show("Cannot take picture if the camera isn't capturing image!");
            }
        }
    }
}
