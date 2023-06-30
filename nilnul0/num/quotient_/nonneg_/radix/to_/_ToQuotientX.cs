using System.Numerics;

namespace nilnul.num.quotient_.nonneg_.radix.to_
{
	static public class _ToQuotientX
	{
		

		static public num.Quotient1 ToQuotient (this nonneg_. Radix radix){
			return nilnul.num.quotient.op_.binary_.Multi1.Singleton.op(
				radix.precision.toBigint()
				,
				quotient.op_.unary_._IndexX.RetQuotient(
					radix.precision.radic.eeByRef, radix.indic
				)
			)
			;
		}
		static public num.quotient_.DenomNonnil ToDenomNonnil (this nonneg_. RadixI radix){
			var t= nilnul.num.quotient.op_.binary_.Multi1.Singleton.op(
				radix.precision.toBigint()
				,
				quotient.op_.unary_._IndexX.RetQuotient(
					radix.precision.radic.eeByRef, radix.indic
				)
			)
			;
			return new DenomNonnil(t.numerator, t.denominator1.en);
		}

		static public num.Quotient1 ToQuotient (this nonneg_. radix_.FloatyI radix){
			return ToQuotient((nonneg_.RadixI)radix);
		}

		static public num.Quotient1 ToQuotient (this nonneg_. RadixI radix){
			return nilnul.num.quotient.op_.binary_.Multi1.Singleton.op(
				radix.precision.toBigint()
				,
				quotient.op_.unary_._IndexX.RetQuotient(
					radix.precision.radic.eeByRef, radix.indic
				)
			)
			;
		}

		static public num.quotient_.denomNonnil_.Nonneg ToNonnegQuotient (this nonneg_.Radix radix){
			return new denomNonnil_.Nonneg(
				denomNonnil._RegressionsX.ToDenomNonnil(
					ToQuotient(radix)
				)
			);
		}


	}
}
