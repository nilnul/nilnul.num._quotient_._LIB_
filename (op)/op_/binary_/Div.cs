using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.op_.binary_
{
	 public class Div1 
	:
		BinaryA,
		BinaryI1
	{
	

		public override string ToString()
		{
			return "/";
		}

		public override nilnul.num.Quotient1 op(nilnul.num.Quotient1 a, nilnul.num.Quotient1 b)
		{

			return new Quotient1(a.numerator * b.denominator, a.denominator * b.numerator);


		}

		public  nilnul.num.Quotient1 op(nilnul.NumI1 a, nilnul.num.Quotient1 b)
		{

			return op( a.ToNum(),b );


		}

		public  nilnul.num.Quotient1 op(nilnul.Num1 a, nilnul.num.Quotient1 b)
		{

			return new Quotient1(a * b.denominator,  b.numerator);


		}


		static public Div1 Singleton
		{
			get
			{
				return nilnul.Singleton1<Div1>.Instance;
			}
		}

	}

	
}
