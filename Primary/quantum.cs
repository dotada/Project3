using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Primary
{
    public class quantum
    {
        public void quantumm()
        {
            HttpClient client = new HttpClient();
            Task<string> task = client.GetStringAsync("https://raw.githubusercontent.com/dotada/Project3/master/Primary/ascii-art.txt");
            task.Wait();
            Console.WriteLine(task.Result);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
            return;
            
        }
        
    }
}
