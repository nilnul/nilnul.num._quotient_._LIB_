using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.op_
{
	public interface BinaryI1

		:
		//nilnul.obj.op_._binary_.retParPar1_.ClosedI<nilnul.num.Quotient1>
		//,
		nilnul.obj.op_.BinaryI<nilnul.num.Quotient1>
	{
	}

	public interface BinaryI2

		:
		BinaryI1
		,
		_binary_.OfInterfaces
	{
	}

	public abstract class BinaryA_onInterfaces : BinaryI2
	{
		public Quotient1 op(Quotient1 par, Quotient1 par1) {
			return Quotient1.Ov( op((QuotientI1)par, (QuotientI1)par1) );
		}
		public abstract QuotientI1 op(QuotientI1 par, QuotientI1 par1);
	}

	public abstract class BinaryA : BinaryI2
	{
		public QuotientI1 op(QuotientI1 par, QuotientI1 par1) {
			return  op(
				Quotient1.Ov(par), Quotient1.Ov(par1)
			);
		}
		public abstract Quotient1 op(Quotient1 par, Quotient1 par1);
	}


}
