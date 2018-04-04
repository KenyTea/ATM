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
        public static void createClient(ref Client c)
        {
            Generator gen = new Generator();
            c.FullName = gen.GenerateDefault(Gender.woman);
            c.IIN = "894556727671";
            c.PhoneNumber = "+77772221116";
            c.DoB = DateTime.Now;
        }
    }
}
