///Authors: Tom & Ethan
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ImageManipulatorView
{
    /// <summary>
    /// Class for the EditView form - Used to edit a selected image by the user
    /// </summary>
    public partial class EditView : Form
    { 
        /// <summary>
        /// Constructor for EditView class and initialises view
        /// </summary>
        /// <param name="pClickedImage"></param>
        public EditView(ImageManipulatorModel.Image pClickedImage)
        {
            InitializeComponent();
            InitialiseImage(pClickedImage);
        }
        /// <summary>
        ///  initializes and configures the display of an image within a UI component based on the information provided in the pImage object
        /// </summary>
        /// <param name="pImage"></param>
        private void InitialiseImage(ImageManipulatorModel.Image pImage)
        {
            pictureBox2.Image = System.Drawing.Image.FromFile(pImage.FileName);
            pictureBox2.ImageLocation = pImage.FileName;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }
        /// <summary>
        /// enables users to save the displayed image to a specified location on their system in 
        /// PNG format with a timestamp in the file name to ensure uniqueness
        /// </summary>
        /// <param name="pSender"></param>
        /// <param name="e"></param>
        private void SaveImageBtn_Click(object pSender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string SelectedPath = openFileDialog.SelectedPath;
                string createdpath = SelectedPath + @"\Edit-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png";
                pictureBox2.Image.Save(createdpath, ImageFormat.Png );          

            }
        }
        /// <summary>
        /// performs a flip operation on an image
        /// </summary>
        /// <param name="pSender"></param>
        /// <param name="e"></param>
        private void RotateBtn_Click(object pSender, System.EventArgs e)
        {
            // rotates an image by 90° clockwise as default
            pictureBox2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            // Refresh the picture box to reflect the changes
            pictureBox2.Refresh();
        }
        /// <summary>
        /// performs a flip operation on an image
        /// </summary>
        /// <param name="pSender"></param>
        /// <param name="e"></param>
        private void FlipBtn_Click(object pSender, EventArgs e)
        {
            // Flip horizontally
            pictureBox2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            // Refresh the picture box to reflect the changes
            pictureBox2.Refresh(); 
        }
    }
}
