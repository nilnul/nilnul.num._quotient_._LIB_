using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.rational
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleContinuedFraction a=new SimpleContinuedFraction(1,7,3,8);
			SimpleContinuedFraction b = new SimpleContinuedFraction(1, 7, 3, 8, 5);
			//
			System.Diagnostics.Debug.WriteLine(a.CompareTo(b));

           // Console.WriteLine(a.CompareTo(b));	
            
        }
    }
}
