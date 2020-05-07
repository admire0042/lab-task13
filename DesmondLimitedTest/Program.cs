using System;

namespace DesmondLimitedTest
{
    public delegate void Interest();
    class Program
    {
        static void Main(string[] args)
        {
            
            Customers customer1 = new Customers("Adewale Johnson","5, Taiwo Oyeleru street, Ibadan",500m,0.05,10);
            Customers customer2 = new Customers("Oteboh Michael","7, Oroki Estate, Adekola street, Lagos",1000m,0.05,11);

            object[][] customers ={
                new object[]{customer1.Name, customer1.Address, customer1.P,customer1.R,customer1.T},
                new object[]{customer2.Name, customer2.Address, customer2.P,customer2.R,customer1.T}
                };

            Console.WriteLine("\n=============DETAILS OF THE TWO CUSTOMERS=============\n");
                for(int i = 0; i < customers.Length;i++){
                for (int k = 0; k < customers[i].Length; k++ )
                {
                    Console.Write($"{customers[i][k], 6} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n=============CUSTOMER1 INTEREST=============\n");
            Interest interest1 = customer1.SimpleInterest;
                     interest1 += customer1.CompoundInterest;
                     interest1();

            Console.WriteLine("\n=============CUSTOMER2 INTEREST=============\n");
            Interest interest = customer2.SimpleInterest;
            interest += customer2.CompoundInterest;
                     interest();
        }

        
    }
}
