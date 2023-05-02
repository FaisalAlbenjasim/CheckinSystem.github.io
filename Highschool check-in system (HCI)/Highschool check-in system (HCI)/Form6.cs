using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
namespace Highschool_check_in_system__HCI_
{
    public partial class Form6 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // this will list the available cameras
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in videoDevices)
                comboBox.Items.Add(Device.Name);
            comboBox.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void openCameraButton_Click(object sender, EventArgs e)
        {
            // starts up the chosen camera
            videoSource = new VideoCaptureDevice(videoDevices[comboBox.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void closeCameraButton_Click(object sender, EventArgs e)
        {
            // turn the camera off
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                pictureBox1.Image = null;
            }
        }

        private void takePhotoButton_Click(object sender, EventArgs e)
        {
            // there is content in the camera preview
            if (pictureBox1.Image != null)
            {
                // copy it to a picture taken picturebox
                pictureBox2.Image = pictureBox1.Image;
                label4.Text = "Lovely Faces!";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Take a photo to proceed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                errorProvider1.SetError(pictureBox2, "Taking a photo is required!");
            }
            else
            {
                Form7 f7 = new Form7();
                f7.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this stage of check in process?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to abort your check in?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }
    }
}
