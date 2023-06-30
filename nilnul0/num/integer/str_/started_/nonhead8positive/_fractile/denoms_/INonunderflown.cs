namespace nilnul.num.integer.str_.started_.nonhead8positive._fractile.denoms_
{
	/// <summary>
	/// if it's not empty, the last one is not 1;
	/// eg:
	///		""
	///		2
	///		2,3
	///		1,3
	///	excluding:
	///		1
	///		2,1
	/// </summary>
	/// alias:
	///		proper
	///			as it's in [0,1)
	///			but 1/(2+1/1) is still proper. So it's not a good name
	///		noncollasible
	///		Nonunderflown
	///		nonflown
	public interface INonunderflown { }

}
