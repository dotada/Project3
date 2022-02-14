using System;
using Renci.SshNet;
using System.IO;
using System.Text;

namespace Primary
{
    class Program
	{ 
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Please choose: multiplication, division, addition, subtraction, ssh, crawler, quantum, encryption or decryption.");
            string choice = Console.ReadLine();
			if (choice == "ssh")
            {
				ssh sshyes = new ssh();
				sshyes.SSH();
            }

            if (choice == "multiplication"){
               calculator multiplication = new calculator();
				multiplication.multiplication();
            }

            if (choice == "division"){
                calculator division = new calculator();
				division.division();
            }

            if (choice == "addition"){
				calculator addition = new calculator();
				addition.addition();
            }

            if (choice == "subtraction"){
                calculator subtraction = new calculator();
                subtraction.subtraction();
            }

			if (choice == "crawler"){
				crawler crawler = new crawler();
                crawler.crawlerr();
            }

            if (choice == "quantum")
            {
                quantum quantumm = new quantum();
                quantumm.quantumm();
            }

            if (choice == "encryption")
            {
                rsa rsa = new rsa();
                rsa.enc();
            }

            if (choice == "decryption")
            {
                rsa rsa = new rsa();
                rsa.dec();
            }

        }
    }
}
