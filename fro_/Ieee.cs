using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.fro_
{
	public class Ieee
	{
		[Obsolete("coppied from online, not sure about its correctness",true)]
		static public Q1 Eval(double x) {

			///sign, exponent(62,52) and mantissa(51,0)
			var bits = BitConverter.DoubleToInt64Bits(x);

			int exponent = (int)((bits>>52) & 0x7ffL /*0111 1111 1111*/   );
			var negative = bits < 0;
			long mantissa = bits & 0xffffFFFFfffffL;

			if (exponent==0)
			{
				exponent++;
			}
			else
			{
				mantissa = mantissa | (1L << 52);
			}

			exponent -= 1075;
			if (mantissa==0)
			{
				return 0;

			}

			throw new NotImplementedException();
		

		}

		[Obsolete("implementation wrong when double is 181.45",true)]
		static public Q1 Eval_byMs(double x) {

			var casted = (microsoft.num.BigRational)x;
			return new Q1(
				casted.Numerator,casted.Denominator
			);
		}

		[Obsolete("implementation wrong when double is 181.45",true)]
		static public Q1 Eval_byMsLib(double x) {

			var casted = (Numerics.BigRational)x;
			return new Q1(
				casted.Numerator,casted.Denominator
			);
		}

	}
}
