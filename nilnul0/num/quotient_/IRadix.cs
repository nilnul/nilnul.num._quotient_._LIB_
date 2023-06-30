namespace nilnul.num.quotient_
{
	/// a positional numeric system.
	/// <summary>
	/// a notation using <see cref="nilnul.num_._radix.IRadic"/>;
	///		eg:	-03123e-03
	///		or: -031.230
	/// </summary>
	/// <remarks>
	/// Here we involves no <see cref="nilnul.character.sorted_.alphabet_"/>; to involves alphabet, use <see cref="nilnul.txt_.frac_.IRadix"/>
	/// </remarks>
	/// vs： <seealso cref="nameof(nilnul.num_.BijectiveNum)"/>
	/// vs:
	///		<see cref="nilnul.txt_.frac_.IRadix"/>, which would further include an alphabet whileas here we only include the count|cardinality of the alphabet;
	/// alias:
	///		cimal
	///			eg:
	///				121.1333, whileas <see cref="quotient_._radix.basic.indiced.ISignificed"/> is -1230e-30
	///		float
	///			for integer it's called radix, for quotient|frac, it's called float as we have a moving point;
	///		radix
	///			we reuse the term <see cref="nilnul.num.integer_.Radix"/>
	///			radix is used in integer, for fraction, we need to float the radix point by allowing negative indicand;
	///			either scientific|engineering notation or decimal notation, we need a radicand;
	public interface IRadix { }
}
