using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServer
{
    public class ResourceFileServer : IFileServer
    {
        public System.Drawing.Image LoadImage(string name)
        {
            try
            {
                var imageBytes = (byte[])Properties.Resources.ResourceManager.GetObject(name);

                using (var ms = new MemoryStream(imageBytes))
                {
                    return new Bitmap(ms);
                }
            }
            catch (System.Exception ex)
            {
                // Log($"An error occured getting the file from the server. [Exception = {ex.Message}]");
                throw;
            }
        }
    }
}
