///Authors: Tom & Ethan
namespace ImageManipulatorModel
{
    /// <summary>
    /// Here is where we Instantiated Image to be stored on the model
    /// </summary>
    public class Image
    {
        /// <summary>
        /// used to store image objects in the unit test
        /// </summary>
        public Image() { }
        /// <summary>
        /// used to create instances of images that are uploaded to the solution by the user
        /// </summary>
        /// <param name="pImageId"></param>
        /// <param name="pFilename"></param>
        public Image(int pImageId, string pFilename)
        {
            FileName = pFilename;
            ImageID = pImageId;
        }
        // used to give an uploaded image a unique id 
        public int ImageID { get; set; }
        // Used to obtain the file name of an image or to set the filename when saving or in testing
        public string FileName { get; set; }
    }
}
