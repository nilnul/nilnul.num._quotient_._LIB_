namespace nilnul.num.quotient_._floaty_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		abs
	///		amount
	///			"a" as in "abs"
	///		magnitude
	public interface MagnitudeI {
		/// <summary>
		/// we use <see cref="quotient_.nonneg_.FloatyI"/>, not <see cref="floaty_.INonneg"/> to avoid cyclic definition;
		/// </summary>
		quotient_.nonneg_.FloatyI magnitude { get; }
	}
}
