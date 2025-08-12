///Authors: Tom & Ethan
using System.Collections.Generic;
using System.Windows.Forms;

namespace ImageManipulatorModel
{   
   
    /// <summary>
    /// uploads and stores the images from users fileExplorer, implementing the IImageStore interface 
    /// </summary>
    public class ImageStore : IImageStore 
    {
        /// <summary>
        /// method which loads images from a users fileexplorer using 'OpenFileDialog'
        /// uses an if statement which will iterate for every file that is uploaded, checking that it 
        /// was grabbed from the users file dialog and provides it with a new unique ID
        /// </summary>
        /// <returns></returns>
        public List<Image> LoadImages()
        {
            // implementation of the image list
            List<Image> images = new List<Image>();
            var imageId = 0;

            var openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            var result = openFileDialog.ShowDialog();
            // If statement which iterates providing any uploaded images with an ID and adding them to the 
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                foreach( var file in openFileDialog.FileNames)
                {
                    var image = new Image(imageId++, file);
                    images.Add(image);
                }
            }

            return images;
        }

    }
}