namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_.nonerr_
{
	/// <summary>
	/// when the raw indic is not all set;
	/// excluding:
	///		Nan
	///		,
	///		Nonfinite
	/// </summary>
	/// alias:
	///		noninf
	///			avoid <see cref="bin_.IFinite"/>, which is reserved;
	///		literal
	///		unextended
	///			note: here we not only have extended inf, we have also -0, Nan, etc;

	public interface INoninf :INonnan{ }
}
