using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient
{
	public abstract class BeA : BeI4,BeI5
	{
		public abstract bool be(Q1 obj);
		public bool be(nilnul.num.QuotientI1 q) {
			return be(new Q1(q));
		}
	}
}
