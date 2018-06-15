using System;

namespace E19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures = int.Parse(Console.ReadLine());
            int filterTimePerPicture = int.Parse(Console.ReadLine());
            int percentGoodPicture = int.Parse(Console.ReadLine());
            int timeToUploadPerPicture = int.Parse(Console.ReadLine());
            double totalTime = 0;

            double timeForFilter = (double)pictures * filterTimePerPicture;
            double goodPhotos = Math.Ceiling(pictures * (percentGoodPicture / 100.0));
            double timeToUploadGoodPictures = goodPhotos * timeToUploadPerPicture;
            totalTime = timeForFilter + timeToUploadGoodPictures;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            string str = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);

            
        }
    }
}
