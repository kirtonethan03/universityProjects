///Authors: Tom & Ethan
using System.Collections.Generic;
using ImageManipulatorController.Controller;
using ImageManipulatorController.Validator;
using ImageManipulatorModel;

namespace ImageManipulatorController
{
    /// <summary>
    /// Controller that manages image validation and positions of image on the gallery 
    /// </summary>
    public class ImageGalleryController : IController
    {
        /// <summary>
        ///This method loads and validates any images uploaded, making sure that they are .PNG resources 
        /// </summary>
        /// <returns> imageStore </returns>
        public List<Image> LoadGallery()
        {
            var imageStore = new ImageStore().LoadImages();
            var validator = new PngValidator();
            validator.ValidateImages(imageStore);
            return imageStore;
        }
        /// <summary>
        /// Uses vector positions to arrange the images properly for view
        /// </summary>
        /// <param name="pXPosition"></param>
        /// <param name="pYPosition"></param>
        /// <returns> x and y positions</returns>
        public (int xPosition, int yPosition) LoadPositions(int pXPosition, int pYPosition)
        {
            // When the image xPosition is 600 it is at the edge of pictureBox2
            if ((pXPosition / 600) == 1)
            {
                // x position increment by 300 to 900 then set Y + 300 and x back to 0
                return (0, pYPosition += 300);
            }
            else
            {
                return (pXPosition += 300, pYPosition);
            }
        }
    }
}
