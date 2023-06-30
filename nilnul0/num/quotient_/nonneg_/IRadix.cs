namespace nilnul.num.quotient_.nonneg_
{
	/// <summary>
	/// to emphasize the <see cref="nilnul.num_._radix.IRadic"/>
	/// </summary>
	/// <remarks>
	/// it would be weird that the magnitude|mantissa is in a different radic than that of <see cref="indic"/> in such as -123e-456, where 123 in different radic of 456 would be anti-intuitive; for that with different indics or no indics specified, consider using a <see cref="quotient.ICalc"/> such as 123* 10^ 356;
	/// with "e", we would take that as radix, with explicit radic literal such as "10" in 123*10^356, we would take that as a calculation;
	/// </remarks>
	/// alias:
	///		radix
	///			like <see cref="nilnul.num.integer_.RadixI"/>
	///			it 's an extension of integer_.radix;
	///		floaty
	///			like <see cref="System.Single"/>
	///			as this adds a floating point to radix, hence it's not only radix
	public interface IRadix { }
}
