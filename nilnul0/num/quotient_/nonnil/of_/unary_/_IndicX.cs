using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonnil.of_.unary_
{
	static public class _IndicX
	{

		static public DenomNonnil DenomNonnil_radicAssumeNonnil_indicAssumeNeg(nilnul.num.quotient_.DenomNonnilI quotient, BigInteger index)
		{

			return 1 / nilnul.num.quotient.of_.unary_._PonentX.DenomNonnil_ponentAssumeNat(quotient, -index);
		}

		static public DenomNonnil DenomNonnil_radicAssumeNonnil(nilnul.num.quotient_.DenomNonnilI quotient, BigInteger index)
		{
			if (index >= 0)
			{
				return nilnul.num.quotient.of_.unary_._PonentX.DenomNonnil_ponentAssumeNat(quotient, index);
			}
			return DenomNonnil_radicAssumeNonnil_indicAssumeNeg(quotient, index);
		}

		static public nilnul.num.quotient_.DenomNonnil DenomNonnil_indicAssumeNeg(
			nilnul.num.quotient_.denomNonnil_.Nonnil quotient
			,
			BigInteger index
		)
		{
			return DenomNonnil_radicAssumeNonnil_indicAssumeNeg(quotient, index);
			;
		}

		static public DenomNonnil DenomNonnil_indicAssumeNeg(nilnul.num.quotient_.DenomNonnilI quotient, BigInteger index)
		{
			return DenomNonnil_indicAssumeNeg(
				new denomNonnil_.Nonnil(quotient)
				,
				index);
			;
		}

		static public nilnul.num.quotient_.DenomNonnil DenomNonnil(nilnul.num.quotient_.denomNonnil_.Nonnil quotient, BigInteger index)
		{
			return DenomNonnil_radicAssumeNonnil(quotient, index);
		}


		static public nilnul.num.quotient_.DenomNonnil DenomNonnil(nilnul.num.quotient_.DenomNonnilI quotient, BigInteger index)
		{
			return DenomNonnil(new quotient_.denomNonnil_.Nonnil(quotient), index);
		}

		static public DenomNonnil DenomNonnil_indicAssumeNeg(BigInteger quotient, BigInteger index)
		{
			
				return nilnul.num.quotient.of_.unary_.Inverse.Singleton.op(
					nilnul.num.integer.op_.unary_._PolyX.Pow(quotient, -index)
				);
				//}
		}
		static public DenomNonnil DenomNonnil(BigInteger quotient, BigInteger index)
		{
			if (index < 0)
			{
				return DenomNonnil_indicAssumeNeg(quotient, index);
			}
			return nilnul.num.integer.op_.unary_._PolyX.Pow(quotient, index);
			//return RetQuotient(new Nonnil1( quotient),index);
		}

		static public nilnul.num.quotient_.denomNonnil_.Nonnil Nonnil(nilnul.num.quotient_.DenomNonnilI quotient, BigInteger index)
		{
			return new denomNonnil_.Nonnil(DenomNonnil(quotient, index));
		}

		static public nilnul.num.quotient_.denomNonnil_.Nonnil Nonnil(nilnul.num.quotient_.denomNonnil_.Nonnil quotient, BigInteger index)
		{
			return new denomNonnil_.Nonnil(DenomNonnil(quotient, index));
		}




	}
}
