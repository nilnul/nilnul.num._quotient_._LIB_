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
	public class FuncWithIndex:SliderI
	{
		Func<N, Q1> _func;

		public FuncWithIndex(Func<N,Q1> func ,
			nilnul.num.SliderI index	
		)
		{
			_func = func;
			_index = index;

		}

		nilnul.num.SliderI _index ;

		public Q1 current
		{
			get
			{
				return _func(_index.current);

				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			_index.moveNext();
			//throw new NotImplementedException();
		}
	}
}
