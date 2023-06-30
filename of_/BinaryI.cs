using nilnul.num._quotient_;
using nilnul.num.quotient_;
using nilnul.num.quotient_.denomNonnil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.of_
{
	public interface BinaryI

		:
		//nilnul.obj.op_._binary_.retParPar1_.ClosedI<nilnul.num.Quotient1>
		//,
		//nilnul.obj.of_.BinaryI<nilnul.num.quotient_.DenomNonnilI>
		//,
		_binary_.OfInterfaces
	{
	}

	


	public abstract class BinaryA : BinaryI
		,
		_binary_.OfImpls
	{
		public abstract DenomNonnil op(DenomNonnil par, DenomNonnil par1);

		public DenomNonnilI op(DenomNonnilI par, DenomNonnilI par1) {
			return  op(
				(par.ToImpl()), (par1.ToImpl())
			);
		}
	}

	public abstract class Binary4interfaceA : BinaryI
		,
		_binary_.OfImpls
	{
		public DenomNonnil op(DenomNonnil par, DenomNonnil par1) {
			return  op(
				(DenomNonnilI)par, (DenomNonnilI)par1
			).ToImpl();

		}

		public abstract DenomNonnilI op(DenomNonnilI par, DenomNonnilI par1);
	}


}
