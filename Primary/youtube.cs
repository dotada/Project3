using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using VideoLibrary;

namespace Primary
{
    public class youtube
    {
        public void downloader()
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Please enter youtube link to download: ");
            string link = Console.ReadLine();
            var youtube = YouTube.Default;
            var video = youtube.GetVideo(link);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Please enter path to save video (I.E. C:\\Users\\User\\Downloads\\): ");
            string path = Console.ReadLine();
            Console.WriteLine("Working.");
            File.WriteAllBytes(path + video.FullName, video.GetBytes());
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
            return;
        }
    }
}
