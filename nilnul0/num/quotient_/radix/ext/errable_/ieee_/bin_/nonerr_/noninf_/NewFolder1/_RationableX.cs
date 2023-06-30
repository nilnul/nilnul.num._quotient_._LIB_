using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_.nonerr_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_
{
	/*
> BitConverter.GetBytes(0d)
byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 }
> BitConverter.GetBytes(-0d)
byte[8] { 0, 0, 0, 0, 0, 0, 0, 128 }
 	 
	 */
	/*
	 if
		ponent is 0
			then
				if mantissa is 0
					then signed nil
				else
					subnormal numbers
		if ponent is all ones
			then
				if mantissa is 0
					it's infinity
				else
					NaN
	 */
	/// <summary>
	/// note: dbl includes some abnormal numbers such as infinity, NaN, negNil. We donot consider abnormal numbers here. We only consider normal number;
	/// </summary>
	/// <remarks>
	/// to make this a quotient, the indicand 
	/// </remarks>
	/// alias:
	///		finite
	///		

	[Obsolete(nameof(_NoninfX))]
	static public class _RationableX
		//:quotient_.radix.ext.errable_.ieee_.IBin
	{
		/// <summary>
		/// 2^(11-1)-1
		/// </summary>
		public const int INDIC_BIAS =1023;

		static public _radix.basic.indiced.significed_.Bin _ToSignificed_assumeNormal(double x)
		{
			var t = _ToSignificandIndic_assumeNormal(
				x
			);
			return new _radix.basic.indiced.significed_.Bin(t.Item1, t.Item2);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		/// alias:
		///		significAndIndic
		static public (long, int) _ToSignificandIndic_assumeNormal(double x)
		{
			return radix.ext.errable_.ieee_.bin_.nonerr_._NoninfX._ToSignificandIndic_0finite(x);
		}

		


	}
}
