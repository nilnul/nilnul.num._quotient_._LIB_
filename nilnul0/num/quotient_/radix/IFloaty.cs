namespace nilnul.num.quotient_.radix
{
	/// <summary>
	/// move the cimal point.
	/// eg:
	///		1.3 = 13 * 10^-1
	///			we can move the point to:
	///				1.3 * 10^-2 , which of course can be converted to (13* 10^-1) * 10^-2;
	///					where "-2" is called float, or slack
	/// So this is a radix with a float;
	/// </summary>
	/// <see cref="_radix.basic.indiced.ISignificed"/>
	public interface IFloaty { }


}
