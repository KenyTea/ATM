using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;
using KKB.Bank.Module;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Menu");
                Console.WriteLine("Inter login");
                string Login1 = Console.ReadLine(); ;
                Console.WriteLine("Inter Password");
                string Password1 = Console.ReadLine();

                if(Login1 == "admin" && Password1 == "admin")
                {


                    Client client = new Client();
                    Servise.createClient(ref client);

                    client.Login = "admin";
                    client.Password = "admin";

                    Console.Clear();
                    Console.WriteLine(" 1 - Список счетов");
                    Console.WriteLine(" 2 - Создать счет");

                    int menu = 0;
                    Int32.TryParse(Console.ReadLine(), out menu);

                    if (menu > 2 || menu < 1)
                    {
                        throw new Exception("Invalid choice");
                    }
                    else
                    {
                        switch (menu)
                        {
                            case 1: { Console.Clear();
                                    client.PrintAccountInfo();


                                } break;
                            case 2: { Console.Clear(); } break;
                        }
                    }
                }
                else
                {
                    throw new Exception("Invalid login or password");
                }
            }
            catch (Exception)
            {

                throw;
            }
           

            List<Client> ListClient = new List<Client>();

            GeneratorName.Generator g= new Generator();

            Client c1 = new Client();

            c1.DoB = DateTime.Now.AddYears(-60);
            c1.FullName = g.GenerateDefault(Gender.man);
            c1.IIN = "970131301448";
            c1.Login = "Qwe";
            c1.Password = "123";
            c1.PhoneNumber = "87475458546";

            ListClient.Add(c1);

            c1.ClientInfoPrint();
        }
    }
}
