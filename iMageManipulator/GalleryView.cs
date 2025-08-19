/// Authors: Tom & Ethan
using ImageManipulatorController;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageManipulatorView
{
    /// <summary>
    /// Form class for GalleryView showing all images in a grid with their thumbnails
    /// </summary>
    public partial class GalleryView : Form
    {
        //Create an instance of the _galleryController to be used in the methods below
        ImageGalleryController _galleryController = new ImageGalleryController();
        int _xPosition = 0;
        int _yPosition = 0;
        /// <summary>
        /// initialises the form for view
        /// </summary>
        public GalleryView()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  handles the user interaction for loading and displaying images in the application's gallery interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadImagesBtn_Click(object sender, EventArgs e)
        {
            //Var declared and LoadGallery is called where it leads to a filedialog window is opened and the selected images image paths are returned
            var images = _galleryController.LoadGallery();
            //If multiple images are uploaded by the user then it will add each one to gallery
            foreach(var image in images)
            {
                PictureBox imageControl = new PictureBox();
                imageControl.Height = 300;
                imageControl.Width = 300;
                //Setting event on the image created so it can be used to open another form with it in for editing
                imageControl.MouseClick += Image_MouseClick;
                // ***
                Image.GetThumbnailImageAbort myCallback =
                    new Image.GetThumbnailImageAbort(ThumbnailCallback);
                Bitmap myBitmap = new Bitmap(image.FileName);
                Image myThumbnail = myBitmap.GetThumbnailImage(300, 300,
                    myCallback, IntPtr.Zero);

                imageControl.Image = myThumbnail;
                // To store the image object in the Tag property for later retrieval 
                imageControl.Tag = image;
                imageControl.Name = image.FileName;  
                imageControl.Location = new Point(_xPosition, _yPosition);
                imageControl.BorderStyle = BorderStyle.Fixed3D;

                ImagePanel.Controls.Add(imageControl);
                //Calls method in controller to adjust position of next image so they do not overlap in the grid
                var positions = _galleryController.LoadPositions(_xPosition, _yPosition);
                _xPosition = positions.xPosition;
                _yPosition = positions.yPosition;
            }
        }
        /// <summary>
        /// Event waiting for user to click an image in the gallery
        /// </summary>
        void Image_MouseClick(object pSender, MouseEventArgs e)
        {
            var filepath = ((PictureBox)pSender).Name;
            var editGallery = new EditView(new ImageManipulatorModel.Image(0, filepath));
            editGallery.ShowDialog();
        }
        /// <summary>
        /// the class provides a placeholder for a thumbnail callback, but it does not actually perform any thumbnail generation
        /// </summary>
        /// <returns></returns>
        private bool ThumbnailCallback() => false;
    }
}
