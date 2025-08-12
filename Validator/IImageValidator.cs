/// Authors: Tom & Ethan
using ImageManipulatorModel;
using System.Collections.Generic;

namespace ImageManipulatorController
{
    /// <summary>
    /// Interface that will be implemented by the PngValidator 
    /// class to validate that uploaded images are .PNGs
    /// </summary>
    public interface IImageValidator
    {
        ///  <summary>
        /// Instance of the ValidateImage method that runs for the 
        /// list of images provided proving they are .PNG
        /// </summary>
        /// <param name="pImages"></param>
        void ValidateImages(List<Image> pImages);
    }
}
