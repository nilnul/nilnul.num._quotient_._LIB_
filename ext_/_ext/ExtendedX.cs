using nilnul.num.rational.ext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient._ext
{
	static public partial class ExtendedX
	{
		static public ExtI Create(
			nilnul.order.ExtendedI<Q> x
			
		) {
			if (x is nilnul.order.ext.NegInfI)
			{
				return _ext.NegInf.Singleton;
			}
			if (x is nilnul.order.ext.PosInfI)
			{
				return _ext.Inf.Singleton;
				
			}
			return new _ext.Base(x as nilnul.order.ext.Literal<Q>);
		
		}

		static public _ext.Base Create(int x) {

			return new Base(x);
		}

		static public Base Create(Q x) {
			return new Base(x);
		}

		static public Base CreateZero() {
			return Create(0);
		}

		static public bool IsZero(this ExtI x) {

			return x is Base && (x as Base).val == 0;
		
		}

		static public Base CreateOne() {
			return new Base(1);
		}
	}
}
