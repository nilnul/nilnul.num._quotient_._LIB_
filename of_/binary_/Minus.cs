using nilnul.num.quotient_;
using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.of_.binary_
{
	public class Minus:
		quotient_.denomNonnil.of_.Binary_onAsImplA
		,


		nilnul.num.quotient.op_.BinaryI1
	{

		public override string ToString()
		{
			return "-";
		}

		public Quotient1 op(Quotient1 a, Quotient1 b )
		{
			return  Quotient1.CreateByDivide(a.numerator * b.denominator - a.denominator * b.numerator, a.denominator.val * b.denominator.val);
		}

		public Quotient1 op(QuotientI1 a, QuotientI1 b )
		{
			return  Quotient1.CreateByDivide(a.numerator * b.denominator1 - a.denominator1 * b.numerator, a.denominator1 * b.denominator1);
		}

		public override DenomNonnil opAsImpl(DenomNonnilI a, DenomNonnilI b)
		{
			return Add.Singleton.opAsImpl(
				a,
				unary_.Neg.Singleton.opAsImpl(b)
			);
		}

		static public Minus Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Minus>.Instance;
			}
		}

	}
}
