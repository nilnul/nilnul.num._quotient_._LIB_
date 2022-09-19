using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.str.duo.be
{
	public partial class Multiplicable
	{

		static public bool Eval(Q[] a, Q[] b)
		{
			return nilnul.obj.str.be.Multiplicable.Eval(a, b);
		}

		public class Be {
			public class Asserted
			{
				static public Q _Multi(Q[] a, Q[] b) {
					return a.Zip(b, (x, y) => x * y).Aggregate(
						(Q)0,
						(ac,w)=>ac+w
					);
				}
				static public Q _Multi(IEnumerable<Q> a, IEnumerable<Q> b) {
					return a.Zip(b, (x, y) => x * y).Aggregate(
						(Q)0,
						(ac,w)=>ac+w
					);
				}
			}
		}
	}
}
