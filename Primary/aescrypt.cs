﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.IO;

namespace Primary
{
    public class aescrypt
    {
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);


        public static byte[] GenerateRandomSalt()
        {
           byte[] data = new byte[32];
           using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    rng.GetBytes(data);
                }
            }
           return data;
        }

        public void FileEncrypt()
        {
            Console.WriteLine("Please enter input file: ");
            string inputFile = Console.ReadLine();
            Console.WriteLine("Please enter password for encryption: ");
            string password = Console.ReadLine();
            GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);
            byte[] salt = GenerateRandomSalt();
            FileStream fsCrypt = new FileStream(inputFile + ".dejacrypt", FileMode.Create);
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Mode = CipherMode.CFB;
            fsCrypt.Write(salt, 0, salt.Length);
            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);
            FileStream fsIn = new FileStream(inputFile, FileMode.Open);
            byte[] buffer = new byte[1048576];
            int read;
            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    cs.Write(buffer, 0, read);
                }
                fsIn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
                File.Delete(inputFile);
                ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
                gch.Free();
                Console.WriteLine("Press enter to exit.");
                Console.ReadLine();
            }

        }
        
        public void FileDecrypt()
        {
            Console.WriteLine("Please enter path to encrypted file (I.E. C:\\Users\\User\\file.txt.aes): ");
            string inputFile = Console.ReadLine();
            Console.WriteLine("Please enter path to put original file (I.E. C:\\Users\\User\\file.txt): ");
            string outputFile = Console.ReadLine();
            Console.WriteLine("Please enter password for encrypted file: ");
            string password = Console.ReadLine();
            GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;
            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);
            FileStream fsOut = new FileStream(outputFile, FileMode.Create);
            int read;
            byte[] buffer = new byte[1048576];
            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsOut.Write(buffer, 0, read);

                }
            
            }
            catch (CryptographicException ex_CryptographicException)
            {
                Console.WriteLine("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
                File.Delete(inputFile);
                ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
                gch.Free();
                Console.WriteLine("Press enter to exit.");
                Console.ReadLine();
            }

        }
    }
}
