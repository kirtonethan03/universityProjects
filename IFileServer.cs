namespace MediaServer
{
    public interface IFileServer
    {
        /// <summary>
        /// Capable of loading finding an image using a name.
        /// </summary>
        /// <param name="name">The name of the image to find</param>
        /// <returns>A bit map image.</returns>
        System.Drawing.Image LoadImage(string name);
    }
}
