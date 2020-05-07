using System;
namespace DesmondLimitedTest
{
    public class Customers
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal p;
        public double r;
        public int t;

        public Customers(string name, string address, decimal pp, double rr, int tt)
        {
          Name = name;
          Address = address;
          P = pp;
          R = rr;
          T = tt;
        }

        
        public decimal P
        {
            get { return p; }

            private set
            {
                if(value > 0.0m)
                {
                    p = value;
                }
            }
            
        }

        public double R
        {
            get { return r; }

            private set
                {
                    if(value > 0.0)
                    {
                        r = value;
                    }
                }
            
        }

        public int T
        {
            get { return t; }

            set
            {
                if(value > 0)
                {
                    t = value;
                }
            }
            
        }
        
        
        public void SimpleInterest()
        {
            decimal SI = (P*(decimal)(T*R))/100;
            Console.WriteLine($"The simple interest is: {SI:C}");
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