using nilnul.num.quotient._ext;
using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.ext.op
{
	public partial class Subtract
	{
		static public num.quotient._ext.ExtI Eval(num.quotient._ext.ExtI x, num.quotient._ext.ExtI y) {
			return Add.Eval(x,Negate.Eval(y));
		
		}

		
	}
}
namespace nilnul.num.rational.ext.op
{
	public partial class Subtract
	{
		static public ExtendedI Eval(ExtendedI x, ExtendedI y) {
			return Add.Eval(x,Negate.Eval(y));
		
		}

		static public ExtendedI Eval(ExtendedI<Rational_InheritFraction2> x, ExtendedI<Rational_InheritFraction2> y) {

			return Eval(
				ExtendedX.Create(x)
				,
				ExtendedX.Create(y)
				);
		
		}
	}
}
