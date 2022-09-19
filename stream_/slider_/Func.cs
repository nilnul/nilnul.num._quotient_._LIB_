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
	public interface _FuncI

		:nilnul.obj.stream_.slider_._FuncI

	{
		//void setIndex(nilnul.Num1 num);
		//void moveNext(nilnul.Num1 num);

	}

	public interface FuncI
		:
		nilnul.num.quotient.stream_.SliderI1
		,
		_FuncI
	{

	}
	public class Func:
		quotient.stream_.SliderA1
		,
		//SliderA,

		quotient.stream_.SliderI1
		,
		FuncI
	{
		Func<N, Q1> _func;

		nilnul.num.stream_.slider_.Nat  _starter = new num.stream_.slider_.Nat();

		public Func(Func<N,Q1> func)
		{
			_func = func;

		}

		


		public override Q1 current
		{
			get
			{
				return _func(_starter.current);

				//throw new NotImplementedException();
			}
		}

		public void setIndex(nilnul.Num1 num) {
			_starter.current = num;
		}


		public override void moveNext()
		{
			_starter.moveNext();
			//throw new NotImplementedException();
		}

		public void moveNext(Num1 num)
		{
			_starter.moveNext(num);
		}
	}


}
