using nilnul.num.quotient._radix;
using nilnul.num.quotient_._radix.basic;
using nilnul.num.quotient_.nonneg_._radix;
using nilnul.num.quotient_.radix_;
using nilnul.num.rational.float_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix.of_
{
	/// <summary>
	/// convert an <see cref="_radix.radic.indiced.Amplified"/> to radix of the same base;
	/// </summary>
	/// <remarks>
	/// to a different base, just convert to quotient, then from quotient to radix;
	/// </remarks>
	/// todo:
	///		from a base,  nx, to a tgt base,  x,  we may convert from amplified to tgt amplified. that is: a* (nx)^b = an^b *x^b
	///		from a base,  x, to a tgt base,  x/n,  we may convert from amplified to tgt amplified. that is: a*x^b= a/n^b *(x/n)^b, which is <see cref="radix.recur.IOffset"/> and a/n^b can be converted to base x/n.
	///		
	static public class _OfAmpliticedX
	{
		
		/// <summary>
		/// eg:
		///		123*10^567 to radix based 2;
		/// </summary>
		/// <param name="radic">
		/// would be vowed inside;
		/// </param>
		/// <param name="indic"></param>
		/// <param name="amplific">
		/// assumed prior outside;
		/// </param>
		/// <returns></returns>
		public static quotient_.nonneg_.Radix _AsRadix_2nonneg( BigInteger radic, BigInteger indic, BigInteger amplific)
		{
			
			var precision = nilnul.num_.radix.of_._OfNumX._Of_1nonneg(
				radic
				,
				amplific
			);

			return new Radix(
				precision
				,
				indic
			);
			
		
		}
		public static Radix _AsRadix_1amplificNonneg(BigInteger radic, (BigInteger amplific, BigInteger indic) amplific9indic)
		{
			return _AsRadix_2nonneg(radic, amplific9indic.indic,amplific9indic.amplific);
		}
		public static quotient_.nonneg_.Radix _AsRadix_2nonneg(Indiced indiced, BigInteger precisionAsInteger)
		{
			return _AsRadix_2nonneg(indiced.baseAsBigInt, indiced.indic,precisionAsInteger );
		}
		public static quotient_.nonneg_.Radix AsRadix( _radix.radic.indiced.Amplified amplified)
		{

			return _AsRadix_2nonneg(amplified.indiced,amplified.precisionAsInteger);
		}


		public static Radix AsRadix(BigInteger radic, Scientific peregrinate)
		{
			return _AsRadix_2nonneg(radic, peregrinate.indic,peregrinate.precision);
		}

		public static quotient_.nonneg_.Radix AsRadix((BigInteger radic, _radix.Scientific peregrinate) regressed)
		{
			return AsRadix(
				regressed.radic,
				regressed.peregrinate
			);

		}

	}
}
