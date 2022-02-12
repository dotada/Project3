using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary
{
    public class quantum
    {
        public void quantumm()
        {
            string dir = Environment.CurrentDirectory;
            string text = System.IO.File.ReadAllText(dir + "\\pc.txt");
            Console.WriteLine(text);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
            return;
            
        }
        
    }
}
