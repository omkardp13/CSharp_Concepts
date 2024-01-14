using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class AccountInfo
        {
            public string Credit()
            {
                return "Balace is created";
            }
        }
        public class  DebitInfo:AccountInfo
        {
            public string Debit()
            {
                Credit();
                return "Balance is debited";
            }
        }


        static void Main(string[] args)
        {
           DebitInfo debitInfo = new DebitInfo();           
           debitInfo.Debit();
           

        }


    }
}
