using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.ext.bound.be
{
	public partial class IntervalUpper
	{
		static public bool IsRestricted(
			ext.Bound x
			
		) {

			return (x.pinpoint is _ext.Inf && !x.openFalseCloseTrue)
				||
				(x.pinpoint is _ext.Base)
			;
		
		}

		public class Be:
			nilnul.bit.Be<ext.Bound>
		{

			public Be()
				:base(IsRestricted)
			{

			}
		}

		public class Expr
			:nilnul.bit.be.Asserted<ext.Bound,Be>
		{
			public Expr(ext.Bound bound)
				:base(bound)
			{

			}

			static public Expr Add(Expr a, Expr b)
			{

				return new Expr(ext.bound.op.Add.Eval(a.val, b.val));

			}

			static public Expr Add(Bound x_restrictedUpper, Bound y_restrictedUpper)
			{

				return Add(
					new Expr(x_restrictedUpper)
					,
					new Expr(y_restrictedUpper)
				);


			}



			
		}
	}
}
