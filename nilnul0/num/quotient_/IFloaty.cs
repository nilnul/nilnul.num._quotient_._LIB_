namespace nilnul.num.quotient_
{
	/// <summary>
	/// eg:
	///		-030053e-33055
	///			note: this cannot be written as dotted form below if we don't prepend 0;
	///		-030e332
	///			this cannot be written as dotted form below if we dont append nil;
	///		-0123.54
	///	excluding:
	///		3.14 * 10^-3
	///			which has to extend this type;
	/// </summary>
	/// alias:
	///		floaty
	///			to avoid reserved keyword "float"
	///			means floating point;
	public interface IFloaty { }
}
