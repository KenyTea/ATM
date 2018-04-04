using KKB.Bank.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;

namespace Bankomat
{
    class Servise
    {
        private static Random ran = new Random();
        public static void createClient(ref Client c)
        {
            Generator gen = new Generator();
            c.FullName = gen.GenerateDefault(Gender.woman);
            c.IIN = "894556727671";
            c.PhoneNumber = "+77772221116";
            c.DoB = DateTime.Now;
            for (int i = 0; i < ran.Next(1,8); i++)
            {
                c.ListAccount.Add(createAccount());
            }
        }

        public static Account createAccount ()
        {
             
            Account acc = new Account();
            acc.AccountNumber = "KZ" + ran.Next(100000000, 1000000000);
            acc.Balance = ran.Next(10000 , 10000000);
            acc.CreateDate = DateTime.Now.AddMinutes(-ran.Next());

            return acc;

        }
    }
}
