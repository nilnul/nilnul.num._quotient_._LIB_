using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.op_.binary_
{
	static  public class _AddX 
	{

		public const string SYMBOL="*";

		

		static public Q0 Op(Q0 arg, Q0 arg1)
		{
			return new nilnul.num.Quotient1(
				arg.numerator * arg1.denominator +arg.denominator*arg1.numerator
				,
				new nilnul.num_.Positive(
				arg.denominator*arg1.denominator
				)
			);

			throw new NotImplementedException();
		}

		static public Quotient1 Op(QuotientI arg, QuotientI arg1)
		{
			return new nilnul.num.Quotient1(
				arg.numerator * arg1.denominator +arg.denominator*arg1.numerator
				,
				new nilnul.num_.Positive(
				arg.denominator*arg1.denominator
				)
			);

			throw new NotImplementedException();
		}

	
	}

	
}
