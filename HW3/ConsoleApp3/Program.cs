using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter credit amount:");
            string amountInput = Console.ReadLine();
            decimal amount = Convert.ToDecimal(amountInput);

            Console.WriteLine("Enter credit interest:");
            string interestInput = Console.ReadLine();
            decimal interest = Convert.ToDecimal(interestInput) / 100;
           
            decimal monthlyPayment = amount / 12;
            decimal mainDebt = amount;
            decimal totalPayments = 0;
            for (int i = 1; i <= 12; i++)
            {
                decimal interestPayment = amount * interest;
                Console.WriteLine(i + " месяц = " + (monthlyPayment + interestPayment));
                amount -= monthlyPayment;
                totalPayments += interestPayment;
            }
            Console.WriteLine("Общая сумма выплат составит: " + (amount + totalPayments));
            Console.ReadKey();
        }
    }
}
