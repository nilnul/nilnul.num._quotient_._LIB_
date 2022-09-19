using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using N = nilnul.Num;


using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream_.slider_.func_
{
	public class Nonnil:
		nilnul.num.quotient.stream_.slider_.Func
		//,SliderI2
	{
		Func<N, Q1> _func;
		nilnul.num.slider_.Starter _index ;

		public Nonnil(
			Func<N,Q1> func ,
			nilnul.Num starter	
		)
		{
			_func = func;
			_index = new num.slider_.Starter( starter);

		}

		public Nonnil(Func<N,Q1> func, uint i):this(func, new N(i))
		{

		}


		public override Q1 current
		{
			get
			{
				return _func(_index.current);

				//throw new NotImplementedException();
			}
		}


		public override void moveNext()
		{
			_index.moveNext();
			//throw new NotImplementedException();
		}

		static public Nonnil CreatePositive(Func<N,Q1> func) { return new Nonnil(func, 1);  }

		
	}
}
