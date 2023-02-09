using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonnil
{
	static public class _IndexX
	{



		static public nilnul.num.Quotient1 RetQuotient_assumeRadicNonnil1IndexNeg(nilnul.num.Quotient1 quotient, BigInteger index)
		{

			return 1 / nilnul.num.quotient.op_.unary_.Poly.Eval(quotient, -index);
		}

		static public nilnul.num.Quotient1 RetQuotient_assumeRadicNonnil(nilnul.num.Quotient1 quotient, BigInteger index)
		{
			if (index >= 0)
			{
				return nilnul.num.quotient.op_.unary_.Poly.Eval(quotient, index);
			}
			return RetQuotient_assumeRadicNonnil1IndexNeg(quotient, index);
		}

		static public nilnul.num.Quotient1 RetQuotient_assumeIndexNeg(nilnul.num.quotient_.Nonnil1 quotient, BigInteger index)
		{
			return RetQuotient_assumeRadicNonnil1IndexNeg(quotient, index);
			;
		}

		static public nilnul.num.Quotient1 RetQuotient_assumeIndexNeg(nilnul.num.Quotient1 quotient, BigInteger index)
		{
			return RetQuotient_assumeIndexNeg(
				new Nonnil1(quotient)
				,
				index);
			;
		}

		static public nilnul.num.Quotient1 RetQuotient(nilnul.num.quotient_.Nonnil1 quotient, BigInteger index)
		{
			return RetQuotient_assumeRadicNonnil(quotient, index);
		}


		static public nilnul.num.Quotient1 RetQuotient(nilnul.num.Quotient1 quotient, BigInteger index)
		{
			return RetQuotient(new Nonnil1(quotient), index);
		}

		static public nilnul.num.Quotient1 RetQuotient(BigInteger quotient, BigInteger index)
		{
			if (index < 0)
			{
				//if (quotient==0)
				//{
				//	throw new DivideByZeroException();
				//}
				//else
				//{
				return nilnul.num.Quotient1.CreateUnit(
					nilnul.num.integer.op_.unary_._PolyX.Pow(quotient, -index)
				);
				//}
			}
			return nilnul.num.integer.op_.unary_._PolyX.Pow(quotient, index);
			//return RetQuotient(new Nonnil1( quotient),index);
		}
		static public nilnul.num.quotient_.Nonnil1 RetNonnil(nilnul.num.Quotient1 quotient, BigInteger index)
		{
			return new Nonnil1(RetQuotient(quotient, index));
		}

		static public nilnul.num.quotient_.Nonnil1 RetNonnil(nilnul.num.quotient_.Nonnil1 quotient, BigInteger index)
		{
			return new Nonnil1(RetQuotient(quotient, index));
		}




	}
}
