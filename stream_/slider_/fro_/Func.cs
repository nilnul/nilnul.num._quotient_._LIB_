using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using N = nilnul._num.bigint.be.Natural.Asserted;


using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.slider_.fro_
{
	public class Func:SliderI
	{
		Func<N, Q1> _func;

		public Func(Func<N,Q1> func)
		{
			_func = func;

		}

		nilnul.num.slider_.Natural _natural = new num.slider_.Natural();

		public Q1 current
		{
			get
			{
				return _func(_natural.current);

				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			_natural.moveNext();
			//throw new NotImplementedException();
		}
	}
}
