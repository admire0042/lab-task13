using System;

namespace DelegateApp
{
    public delegate string strMyDel(string a);
    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate testdelegate = new TestDelegate();
            strMyDel myDel = testdelegate.Space;
            string result = myDel("Olusoji");
            Console.WriteLine($"The spaced string of Soji is: {result}");

            TestDelegate testdelegate1 = new TestDelegate();
            strMyDel myDel1 = testdelegate1.Reverse;
            string result1 = myDel1("Adewale");
            Console.WriteLine($"The reversed string Adewale is: {result1}");

        }
    }
}
