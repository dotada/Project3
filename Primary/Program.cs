using System;
using Renci.SshNet;
using System.Net.Http;
using HtmlAgilityPack;
using System.IO;
using System.Text;

namespace Primary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Please choose: multiplication, division, addition, subtraction, ssh or crawler.");
            string choice = Console.ReadLine();
            if (choice == "multiplication"){
                System.Threading.Thread.Sleep(500);
	            System.Console.WriteLine("Hello and welcome to my multiplication program.");
	            System.Threading.Thread.Sleep(500);
	            System.Console.WriteLine("Please enter first number: ");
	            string lin1 = Console.ReadLine();
	            int num1 = Int16.Parse(lin1);
	            System.Console.WriteLine("Please enter second number: ");
	            string lin2 = Console.ReadLine();
	            int num2 = Int16.Parse(lin2);
	            System.Console.WriteLine($"The result is: {(double)num1 * num2}");
	            System.Console.WriteLine("Press Enter to exit.");
	            Console.ReadLine();
            }

            if (choice == "division"){
                System.Threading.Thread.Sleep(500);
	            System.Console.WriteLine("Hello and welcome to my division program.");
	            System.Threading.Thread.Sleep(500);
	            System.Console.WriteLine("Please enter first number: ");
	            string lin1 = Console.ReadLine();
	            int num1 = Int16.Parse(lin1);
	            System.Console.WriteLine("Please enter second number: ");
	            string lin2 = Console.ReadLine();
	            int num2 = Int16.Parse(lin2);
	            System.Console.WriteLine($"The result is: {(double)num1 / num2}");
	            System.Console.WriteLine("Press Enter to exit.");
	            Console.ReadLine();
            }

            if (choice == "addition"){
               System.Threading.Thread.Sleep(500);
	            System.Console.WriteLine("Hello and welcome to my addition program.");
	            System.Threading.Thread.Sleep(500);
	            System.Console.WriteLine("Please enter first number: ");
	            string lin1 = Console.ReadLine();
	            int num1 = Int16.Parse(lin1);
	            System.Console.WriteLine("Please enter second number: ");
	            string lin2 = Console.ReadLine();
	            int num2 = Int16.Parse(lin2);
	            System.Console.WriteLine($"The result is: {(double)num1 + num2}");
	            System.Console.WriteLine("Press Enter to exit.");
	            Console.ReadLine(); 
            }

            if (choice == "subtraction"){
                System.Threading.Thread.Sleep(500);
	            System.Console.WriteLine("Hello and welcome to my subtraction program.");
	            System.Threading.Thread.Sleep(500);
	            System.Console.WriteLine("Please enter first number: ");
	            string lin1 = Console.ReadLine();
	            int num1 = Int16.Parse(lin1);
	            System.Console.WriteLine("Please enter second number: ");
	            string lin2 = Console.ReadLine();
	            int num2 = Int16.Parse(lin2);
	            System.Console.WriteLine($"The result is: {(double)num1 - num2}");
	            System.Console.WriteLine("Press Enter to exit.");
	            Console.ReadLine();
            }

			if (choice == "crawler")
            {
				System.Console.WriteLine("Enter URL (with http:// or https://): ");
				string url = Console.ReadLine();
				var html = @url;
				HtmlWeb web = new HtmlWeb();
				var htmlDoc = web.Load(html);
				htmlDoc.Save("site.html");

            }

            if (choice == "ssh"){
                System.Console.WriteLine("Please enter IP: ");
                string ip = Console.ReadLine();
                System.Threading.Thread.Sleep(500);
				System.Console.WriteLine("Please enter username: ");
				string username = Console.ReadLine();
				System.Threading.Thread.Sleep(500);
				System.Console.WriteLine("Please enter password: ");
				string password = Console.ReadLine();
				System.Threading.Thread.Sleep(500);
				using (var client = new SshClient(ip, username, password))
				{
				
					client.Connect();
					System.Console.WriteLine("Please enter command: ");
					string cmd = Console.ReadLine();
					var output = client.RunCommand(cmd).Result;
					System.Console.WriteLine(output);
					System.Threading.Thread.Sleep(500);
					System.Console.WriteLine("Run another command? (Y/N) ");
					string input2 = Console.ReadLine();
					if (input2 == "Y"){
						goto cmdrepeat;
					}

					if (input2 == "N"){
						return;
					}

					cmdrepeat:
						System.Console.WriteLine("Please enter command: ");
						string cmd5 = Console.ReadLine();
						var output2 = client.RunCommand(cmd5).Result;
						System.Console.WriteLine(output2);
						System.Threading.Thread.Sleep(500);
						System.Console.WriteLine("Run another command? (Y/N) ");
						string input5 = Console.ReadLine();
						if (input5 == "Y"){
							goto cmdrepeat;
						}

						if (input5 == "N"){
							return;
						}

				}

            }

        }
    }
}
