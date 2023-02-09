using nilnul.obj.op_._unary_.par_;

namespace nilnul.num.quotient_.denomNonnil.of_
{
	public abstract class Binary_onAsImplA
		:
		_binary_.AsImplI
		,

		BinaryI

	{
		public DenomNonnilI op(DenomNonnilI par, DenomNonnilI par1)
		{
			return opAsImpl(par,par1);
		}

		public abstract DenomNonnil opAsImpl(DenomNonnilI a, DenomNonnilI b);
	}


}
