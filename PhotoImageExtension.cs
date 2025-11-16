using System.IO;
namespace RagePhoto.Image {

    using Image = System.Drawing.Image;

    public static class PhotoImageExtension {

        public static Image GetImage(this Photo photo) {
            using MemoryStream jpegStream = new(photo.Jpeg);
            return Image.FromStream(jpegStream);
        }
    }
}
