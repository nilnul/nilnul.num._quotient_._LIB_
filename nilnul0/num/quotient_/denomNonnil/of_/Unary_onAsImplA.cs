using nilnul.obj.op_._unary_.par_;

namespace nilnul.num.quotient_.denomNonnil.of_
{
	public abstract class Unary_onAsImplA
		:
		_unary_.AsImplI
		,

		UnaryI

	{
		public DenomNonnilI op(DenomNonnilI par)
		{
			return opAsImpl(par);
		}

		public abstract DenomNonnil opAsImpl(DenomNonnilI a);
	}


}
