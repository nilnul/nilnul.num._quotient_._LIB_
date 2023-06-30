using nilnul.num.quotient._ext;
using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.ext
{
	public partial class Eq
		:
		num.integer.ext._generic.Eq_default<Q, quotient.Eq, _ext.ExtI, _ext.Base, _ext.Inf,_ext.NegInf>
		
	{

		static public Eq Singleton = SingletonByDefault<Eq>.Instance;

		
		
	}
}
