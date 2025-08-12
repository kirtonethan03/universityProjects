///Authors: Tom & Ethan
using System.Collections.Generic;

namespace ImageManipulatorModel
{
    /// <summary>
    /// interface implemented by all class using the images, used to 
    /// help return a list of image objects from upload
    /// </summary>
    public interface IImageStore
    {
        List<Image> LoadImages();
    }
}
