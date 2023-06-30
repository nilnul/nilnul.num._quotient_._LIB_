using nilnul.num.quotient_.denomNonnil._range.border_;

namespace nilnul.num.quotient_.denomNonnil.bound_
{
	public class Openose : denomNonnil.co.be_.lt.vow.Ee
		,
		denomNonnil.BoundI
	{
		public Openose(in (DenomNonnil, DenomNonnil) val) : base(val)
		{
		}

		public Openose((DenomNonnil, DenomNonnil) val) : base(val)
		{
		}

		public Openose(DenomNonnil x, DenomNonnil y) : base(x, y)
		{
		}

		public Lower lower => _range. border_.Lower.CreateOpen(this.eeByRef.Item1);

		public Upper upper => _range. border_.Upper.CreateClose(this.eeByRef.Item2);
	}


}
