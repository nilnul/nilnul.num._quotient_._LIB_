using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.obj._slider_;
using N = nilnul.NumI1;


using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream_.slider_
{
	

	public class Func<T>:
		quotient.stream_.SliderA1
		,
		//SliderA,
		//quotient.stream_.SliderI1
		//,
		FuncI
		where T: nilnul.NumI1
	{
		Func<T, Q1> _func;

		T _index;

		public Func(Func<T,Q1> func, T init)
		{
			_func = func;
			_index.current = new nilnul.Num1( init);

		}

		


		public override Q1 current
		{
			get
			{
				return _func(_index.current);

				//throw new NotImplementedException();
			}
		}

		public void setIndex(nilnul.Num1 num) {
			_index.current = num;
		}


		public override void moveNext()
		{
			_index.moveNext();
			//throw new NotImplementedException();
		}

		public void moveNext(Num1 num)
		{
			_index.moveNext(num);
		}
	}


}
