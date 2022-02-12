using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Primary
{
    public class crawler
    {
        public void crawlerr()
        {
            System.Console.WriteLine("Enter URL (with http:// or https://): ");
            string url = Console.ReadLine();
            var html = @url;
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            htmlDoc.Save("site.html");
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
            return;
        }
    }
}
