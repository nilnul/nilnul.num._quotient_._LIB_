using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.op_.binary_
{
	[Obsolete()]
	 public class Multi 
	:BinaryI
	{
	

		public override string ToString()
		{
			return "*";
		}

		public nilnul.num.QuotientI op(nilnul.num.QuotientI a, nilnul.num.QuotientI b)
		{

			return new Quotient1(a.numerator * b.numerator, a.denominator * b.denominator);

		}

		static public Multi Singleton
		{
			get
			{
				return nilnul.Singleton1<Multi>.Instance;
			}
		}

	}

	
}
