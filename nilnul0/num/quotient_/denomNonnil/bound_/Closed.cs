using nilnul.num.quotient_.denomNonnil._range.border_;

namespace nilnul.num.quotient_.denomNonnil.bound_
{
	public class Closed : denomNonnil.co.be_.le.vow.Ee
		,
		denomNonnil.BoundI
	{
		public Closed(in (DenomNonnil, DenomNonnil) val) : base(val)
		{
		}

		public Closed((DenomNonnil, DenomNonnil) val) : base(val)
		{
		}

		public Closed(DenomNonnil x, DenomNonnil y) : base(x, y)
		{
		}

		public Lower lower => _range. border_.Lower.CreateClose(this.eeByRef.Item1);

		public Upper upper => _range. border_.Upper.CreateClose(this.eeByRef.Item2);
	}


}
