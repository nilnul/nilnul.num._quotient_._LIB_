namespace nilnul.num.quotient_.radix._ieee
{
	/// <summary>
	/// evenly distributed indicand would represent unevenly distributed numbers,where it's dense in [0,1), and sparse in [1,inf)
	///
	/// for number representation, the numbers within [0,1) shall be denser than those in [1,inf).
	/// that means we need better precision within [0,1)
	///	for x in [0,1), 1/(1-x) =y is in [1,inf)
	///		the two intervals are in same monotonity, and the closedness of border is a good partition;
	///
	/// let's take supMin=2^-1022 as normal;
	///		then [0,supMin) as subnormal, which is dense; and [supMin,inf) is supnormal, which is sparse;
	/// </summary>
	/// 
	/// 
	public interface IBiased:IRadix { }
}
