///Authors: Tom & Ethan
using ImageManipulatorModel;
using System.Collections.Generic;
namespace ImageManipulatorController.Controller 
{
    /// <summary>
    /// Interface handling any image requests to the model
    /// </summary>
    public interface IController
    {
        /// <summary>
        ///This method loads and validates any images uploaded, 
        ///making sure that they are .PNG resources 
        /// </summary>
        /// <returns> imageStore </returns>
        /// <param name="pDegrees"></param>
        List<Image> LoadGallery();
        /// <summary>
        /// Uses vector positions to arrange the images properly for view
        /// </summary>
        /// <param name="pXPosition"></param>
        /// <param name="pYPosition"></param>
        /// <returns> x and y positions</returns>
        (int xPosition, int yPosition) LoadPositions(int pXPosition, int pYPosition);
    }
}
    