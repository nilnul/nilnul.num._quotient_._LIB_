using nilnul.num.quotient_.denomNonnil._range.border_;

namespace nilnul.num.quotient_.denomNonnil.bound_
{
	public class Clopen : denomNonnil.co.be_.lt.vow.Ee
		,
		denomNonnil.BoundI
	{
		public Clopen(in (DenomNonnil, DenomNonnil) val) : base(val)
		{
		}

		public Clopen((DenomNonnil, DenomNonnil) val) : base(val)
		{
		}

		public Clopen(DenomNonnil x, DenomNonnil y) : base(x, y)
		{
		}

		public Lower lower => _range. border_.Lower.CreateClose(this.eeByRef.Item1);

		public Upper upper => _range. border_.Upper.CreateOpen(this.eeByRef.Item2);
	}


}
