using nilnul.num.quotient_.denomNonnil;
using Q1 = nilnul.num.quotient_.DenomNonnil;

namespace nilnul.num.quotient
{
	public abstract class Be4DenomNonnilImplA :
		nilnul.obj.BeA_ofIn<Q1>
		,

		Be4DenomNonnilInterfaceI
	{
		
		public bool be(in quotient_.DenomNonnilI val)
		{
			return base.be(val.ToImpl());
		}
	}
}
