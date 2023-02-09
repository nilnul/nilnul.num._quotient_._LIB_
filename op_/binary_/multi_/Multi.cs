using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.combine_
{
	 public class Multi 
	:CombineI2
	{
	

		public override string ToString()
		{
			return "*";
		}

		public nilnul.num.Quotient1 combine(nilnul.num.Quotient1 a, nilnul.num.Quotient1 b)
		{

			return new Quotient1(a.numerator * b.numerator, a.denominator * b.denominator);

		}

		static public Multi Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Multi>.Instance;
			}
		}

	}

	
}
