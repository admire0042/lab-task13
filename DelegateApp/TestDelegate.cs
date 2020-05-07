using System;
using System.Linq;
namespace DelegateApp
{
    public class TestDelegate
    {
       public string Space(string str)
       {
            string strArr = String.Join(" ", str.Reverse());
            string EmpStr = "";
            for(int i = strArr.Length-1; i >= 0; i--)
            {
                EmpStr += strArr[i];
            }
            return EmpStr;
       } 

       public string Reverse(string str)
       {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

                // str.join;
                // str.Reverse();
       } 

    }
}