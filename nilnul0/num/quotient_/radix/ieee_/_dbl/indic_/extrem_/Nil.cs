namespace nilnul.num.quotient_.radix.ieee_._dbl.indic_.extrem_
{
	/// <summary>
	/// the indicand is 0;
	/// sometimes we called it as subnormal;
	/// the dbl would include:
	///		when significand is 0
	///			+0
	///			neg nil, which is not ordianry rational, or it needs to be regarded as the same as +0, or just 0;
	///			in both case, it can be converted to rational:0;
	///		when significand is not 0:
	///			rationals, in  2^-1022 * (-1,1)
	/// </summary>
	/// <remarks>
	/// <see cref="indic_.Nonextrem"/>, the smallest precision there is -1022, whileas this would have a indicand less than -1022; it's -1023 or -1024, ..., -(1022+52)
	/// </remarks>
	public class Nil
	{

	}
}
