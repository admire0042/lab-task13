using System;

namespace DesmondLimitedTest
{
    public delegate void Interest(decimal a, double b, int c);
    //public delegate void Interest1();
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
            
            int count = 0;
            for(int i = 0; i < customers.Length;i++)
            {
                count++; 
                Console.WriteLine($"\n=============CUSTOMER{count} DETAILS AND INTEREST=============\n");
                for (int k = 0; k < customers[i].Length; k++ )
                {
                    Console.Write($"{customers[i][k], 6} ");
                }
                 Console.WriteLine("\n");
            Interest interest1 = SimpleInterest;
                     interest1 += CompoundInterest;
                     interest1((decimal)customers[i][2], (double)customers[i][3], (int)customers[i][4]);
                    Console.WriteLine();
            }
            
        }

        public static void SimpleInterest(decimal P, double R, int T)
        {
            decimal SI = (P*(decimal)(T*R))/100;
            Console.WriteLine($"The simple interest is: {SI:C}");
        }

        public static void CompoundInterest(decimal P, double R, int T)
        {
            
             decimal compoundInterest = P * (decimal)(Math.Pow((1.0 + R), T));
              Console.WriteLine($"The compound interest is: {compoundInterest:C}");
            
            //  decimal total = 0;

            //  for(int i = 1; i <= T; i++){
            //      decimal compoundInterest = P * (decimal)(Math.Pow((1.0 + R), i));
            //      total += compoundInterest;
            //  }
            // Console.WriteLine($"The compound interest is: {total:C}");
            
        }

    }
}
