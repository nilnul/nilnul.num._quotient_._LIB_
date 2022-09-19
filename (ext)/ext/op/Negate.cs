using nilnul.num.quotient._ext;
using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.ext.op
{
	public partial class Negate
	{
		static public num.quotient._ext.ExtI Eval(num.quotient._ext.ExtI x) {

			if (x is _ext.NegInf)
			{
				return _ext.Inf.Singleton;
				
			}
			if (x is _ext.Inf)
			{
				return _ext.NegInf.Singleton;
				
			}
			return ExtendedX.Create(

					(x as Base).val.toNegate()
				
				
			);
		}
		static public num.quotient.ExtI Eval(num.quotient.ExtI x) {

			if (x is ext_.NegInf)
			{
				return ext_.Inf.Singleton;
				
			}
			if (x is ext_.Inf)
			{
				return ext_.NegInf.Singleton;
				
			}
			return new ext_.Bare(
					nilnul.num.quotient.op.Negate.Eval(
						(x as ext_.Bare).q
					)
				
				
			);
		}


	}




}

namespace nilnul.num.rational.ext.op
{
	public partial class Negate
	{
		static public ExtendedI Eval(ExtendedI<Rational_InheritFraction2> x) {

			if (x is nilnul.order.ext.NegInfI)
			{
				return NegInf.Singleton;
				
			}
			if (x is nilnul.order.ext.PosInfI)
			{
				return PosInf.Singleton;
				
			}
			return ExtendedX.Create(

					(x as nilnul.order.ext.Literal<Rational_InheritFraction2>).val.toNegate()
				
				
			);
		}
	}
}
