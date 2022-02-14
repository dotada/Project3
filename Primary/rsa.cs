using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using StringCipher;

namespace Primary
{
    public class rsa
    {
        public void enc()
        {
            Console.WriteLine("Please enter password to use: ");
            string passwd = Console.ReadLine();
            Console.WriteLine("Please enter a string to encrypt: ");
            string plaintext = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Your encrypted string is: ");
            string encryptedstring = StringCipher128.Encrypt(plaintext, passwd);
            Console.WriteLine(encryptedstring);
            Console.WriteLine("");
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
            return;
        }

        public void dec()
        {
            Console.WriteLine("Please enter encrypted string: ");
            string enctext = Console.ReadLine();
            Console.WriteLine("Please enter password for encrypted string: ");
            string enctextpasswd = Console.ReadLine();
            Console.WriteLine("Your decrypted string is: ");
            string decstring = StringCipher128.Decrypt(enctext, enctextpasswd);
            Console.WriteLine(decstring);
            Console.WriteLine("");
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
            return;
        }
    }
}
