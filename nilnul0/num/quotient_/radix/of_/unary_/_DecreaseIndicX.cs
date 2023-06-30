using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using nilnul.num.quotient_.radix_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.of_.unary_
{

	static public class _DecreaseIndicX
	{

		public static (integer_.Radix, BigInteger) _Duo_1nonneg(RadixI radix, int _decreaseMagnitude)
		{
			return (
				new integer_.Radix(
					new nilnul.num_.Radix1(
						new num_.Plural(
						radix.signific.abs.radic.eeByRef
						)
						,
						new str_.List(
							radix.signific.abs.gits.Select(x=>new Num1(x.eeByRef)).Concat(
								Enumerable.Repeat(0, _decreaseMagnitude).Select(i => new Num1(i))
							)
						)
					)
					,
					radix.signific.sign
				)
				,
				radix.indic - _decreaseMagnitude
			);
		}
		public static radix_.ByNeg _AsByNeg_1pos(radix_.ByNeg radix, int _decreaseMagnitude)
		{
			return new radix_.ByNeg(
				quotient_.nonneg_.radix.of_.unary_._AppendNilX._Radix_1nonneg(
					radix.unsigned, _decreaseMagnitude
				)
				,
				radix.negated

			);
				//_Duo_1nonneg((RadixI)radix, _decreaseMagnitude)

		}
		public static radix_.ByNeg _AsByNeg_1nonneg(radix_.ByNeg radix, int _decreaseMagnitude)
		{
			if (_decreaseMagnitude == 0)
			{
				return radix;
			}
			return _AsByNeg_1nonneg(radix, _decreaseMagnitude);


		}

		static public Radix3 _Radix_1nonneg(
			Radix3 radix
			,
			int _decreaseMagnitude
		)
		{

			return new Radix3(
				_Duo_1nonneg(radix, _decreaseMagnitude)
			);
		}
		static public Radix3 _Nop8nil_1nonneg(
			Radix3 radix
			,
			int _decreaseMagnitude
		)
		{
			if (_decreaseMagnitude == 0)
			{
				return radix;
			}

			return _Radix_1nonneg(radix, _decreaseMagnitude);
		}






	}
}
