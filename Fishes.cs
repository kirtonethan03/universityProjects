using System;
using System.Drawing;
using System.Windows.Forms;

namespace FishyForms
{
    public partial class Fishes : Form
    {
        private Fishyform fishyForm;
        public Fishes()
        {
            InitializeComponent();
        }

        // My method to set and scale images
        public void SetImage(Image origionalImage)
        {
            // Scaling
            float scaleFactor = 1.5f;

            // Calculation of new image dimensions
            int newWidth = (int)(origionalImage.Width * scaleFactor); 
            int newHeight = (int)(origionalImage.Height * scaleFactor);

            // Creating the copy of the image 
            Image scaledImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(scaledImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(origionalImage, 2, 0, newWidth, newHeight);
            }

            // Setting the required Image to the picture box
            pictureBox1.Image = scaledImage;
        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide the current form 
                this.Hide();

                // Adjust the size of the background image to simulate Zoom
                int zoomFactor = 2;
                pictureBoxDelete.BackgroundImage = ResizeImage(Properties.Resources.starfish_Latest, zoomFactor);

            }

            catch (OutOfMemoryException )
            {
                // Handle the OutOfMemoryException
                MessageBox.Show("Out of memory error occurred. Please try again or free up system resources.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private Bitmap ResizeImage(Image image, int zoomFactor)
        {
            int newWidth = image.Width * zoomFactor;
            int newHeight = image.Height * zoomFactor;

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }

    }
}
