using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.op_.binary_
{
	public class Multi1
   : nilnul.num.quotient.op_.BinaryI1
		,
		nilnul.num.quotient.op_._binary_.OfInterfaces
	{


		public override string ToString()
		{
			return "*";
		}

		public nilnul.num.Quotient1 op(nilnul.num.Quotient1 a, nilnul.num.Quotient1 b)
		{

			return  Quotient1.CreateByDivide(a.numerator * b.numerator, a.denominator * b.denominator);

		}

		public nilnul.num.Quotient1 op(bool a, nilnul.num.Quotient1 b)
		{

			return a?b:-b;

		}

		public nilnul.num.Quotient1 op( nilnul.num.Quotient1 b, bool a)
		{

			return op(a, b);

		}

		public QuotientI1 op(QuotientI1 a, QuotientI1 b)
		{
			return  Quotient1.CreateByDivide(a.numerator * b.numerator, a.denominator1 * b.denominator1);
		;
		}

		static public Multi1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Multi1>.Instance;
			}
		}

	}


}
