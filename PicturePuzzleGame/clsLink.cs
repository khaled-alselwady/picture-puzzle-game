using System.IO;

namespace PicturePuzzleGame
{
    public static class clsLink
    {
        private const string ImagesFolder = "Cat-Images";

        public static string Pic1 => Path.Combine(ImagesFolder, "1.jpg");
        public static string Pic2 => Path.Combine(ImagesFolder, "2.jpg");
        public static string Pic3 => Path.Combine(ImagesFolder, "3.jpg");
        public static string Pic4 => Path.Combine(ImagesFolder, "4.jpg");
        public static string Pic5 => Path.Combine(ImagesFolder, "5.jpg");
        public static string Pic6 => Path.Combine(ImagesFolder, "6.jpg");
        public static string Pic7 => Path.Combine(ImagesFolder, "7.jpg");
        public static string Pic8 => Path.Combine(ImagesFolder, "8.jpg");
        public static string Pic9 => Path.Combine(ImagesFolder, "9.jpg");
        public static string Black => Path.Combine(ImagesFolder, "black.jpg");
    }
}
