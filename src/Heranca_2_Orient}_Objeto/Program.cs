using System;
using Heranca_2_Orient__Objeto.Entities;

namespace Heranca_2_Orient__Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.00);

            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.00, 500.00);

            //upcasting

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.00, 200.00);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.00, 0.01);

            //Downcasting

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3; >>> Error

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }

            Console.ReadKey();
        }
    }
}
