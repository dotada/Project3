using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace Primary
{

  public class ssh
  {
          public void SSH()
      {
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
                          CommandCall(client);
                      }
              }
    
      public void CommandCall(SshClient client)
      {
                  System.Console.WriteLine("Please enter command: ");
                  string cmd = Console.ReadLine();
                  var output = client.RunCommand(cmd).Result;
                  System.Console.WriteLine(output);
                  System.Threading.Thread.Sleep(500);
                  System.Console.WriteLine("Run another command? (Y/N) ");
                  string input2 = Console.ReadLine();
                  if (input2 == "Y")
                      {
                          CommandCall(client);
                      }
        
          if (input2 == "N")
                      {
                          return;
                      }
              }
      }
}
