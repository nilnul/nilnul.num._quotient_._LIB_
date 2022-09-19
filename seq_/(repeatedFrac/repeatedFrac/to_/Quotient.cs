using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.quotient.continuedFrac_;

namespace nilnul.num.quotient.continuedFrac.to_
{
	public class Quotient : nilnul.obj._to_.ToI<ForQ, Q1>
		,
		nilnul.obj._to_.ToI<ForIrrational, Q1>
	{
		public Q1 to(ForQ src)
		{

			return src.floor + _continuedFrac.simpleProper.to_.Quotient.Singleton.to(src.proper);
			//throw new NotImplementedException();
		}

		static private Lazy<Quotient> _Lazy = new Lazy<Quotient>();
		static public Quotient Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}


		static public readonly Quotient Singleton = SingletonByDefault<Quotient>.Instance;

		public Q1 to(double x, nilnul.num_.Positive forPrecision) {
			return to(
				fro_.Ieee.Fro(x, forPrecision)	
			);
		}

		

		public Q1 to(ForIrrational src)
		{
			return src.floor + nilnul.num.quotient._continuedFrac.simpleProper.to_.Quotient.Singleton.to( src.proper);

			//throw new NotImplementedException();
		}
	}
}
