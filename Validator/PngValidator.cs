/// Authors: Tom & Ethan
using ImageManipulatorModel;
using System.Collections.Generic;
using System.Linq;

namespace ImageManipulatorController.Validator
{
    /// <summary>
    /// Implementation of the IImageValidator interface, runs a loop to 
    /// check all images in the uploaded images list
    /// </summary>
    public class PngValidator : IImageValidator
    {
        /// <summary>
        /// The method below iterates through the list of uploaded images, 
        /// converting the filenames to lowercase text and checking that the 
        /// file ends with ".png" if it does't then the file is removed from the list 
        /// </summary>
        /// <param name="pImages"></param>
        public void ValidateImages(List<Image> pImages)
        {
            foreach (var image in pImages.ToList())
            {
                if (!image.FileName.ToLower().EndsWith(".png"))
                {
                    pImages.Remove(image);
                }
            }
        }
    }
}
