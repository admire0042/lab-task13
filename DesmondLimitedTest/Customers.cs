using System;
namespace DesmondLimitedTest
{
    public class Customers
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal P { get; set; }
        public double R { get; set; }
        public int T { get; set; }

        public Customers(string name, string address, decimal p, double r, int t)
        {
          Name = name;
          Address = address;
          P = p;
          R = r;
          T = t;
        }
        
        public void SimpleInterest()
        {
            decimal SI = (P*(decimal)(T*R))/100;
            Console.WriteLine($"The simple interest is: {SI}");
        }

        public void CompoundInterest()
        {
                decimal total = 0;
             for(int i = 1; i <= T; i++){
                 decimal compoundInterest = P * (decimal)(Math.Pow((1.0 + R), i));
                 total += compoundInterest;
             }
            Console.WriteLine($"The compound interest is: {total:C}");
            
        }
       
    }
}