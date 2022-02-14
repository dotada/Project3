using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCipher;
using System.IO;

namespace Primary
{
    public class filenc
    {
        public void fileenc()
        {
            Console.WriteLine("Welcome to my file encryption.");
            Console.WriteLine("Please enter full path to original file: ");
            string origfile = Console.ReadLine();
            string origfileconts = System.IO.File.ReadAllText(origfile);
            Console.WriteLine("Please enter password for encryption: ");
            string origfilepasswd = Console.ReadLine();
            string encfileconts = StringCipher.StringCipher128.Encrypt(origfileconts, origfilepasswd);
            string filename = Path.GetFileName(origfile);
            Console.WriteLine("Please enter path to save new file (I.E. C:\\Users\\User\\): ");
            string path1 = Console.ReadLine();
            string path = path1 + filename + ".dejacrypt";
            File.WriteAllText(path, encfileconts);
            File.Delete(origfile);
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
            return;
        }

        public void filedec()
        {
            Console.WriteLine("Welcome to my file decryption.");
            Console.WriteLine("Please enter full path to encrypted file: ");
            string encfilepath = Console.ReadLine();
            string encfile = File.ReadAllText(encfilepath);
            Console.WriteLine("Please enter encrypted file password: ");
            string encfilepasswd = Console.ReadLine();
            string decfile = StringCipher.StringCipher128.Decrypt(encfile, encfilepasswd);
            Console.WriteLine("Enter full path for the original file to be created: ");
            string decfilepath = Console.ReadLine();
            File.WriteAllText(decfilepath, decfile);
            File.Delete(encfilepath);
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
            return;
            
        }
    }
}
