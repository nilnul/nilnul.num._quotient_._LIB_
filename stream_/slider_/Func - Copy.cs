using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.obj._slider_;
using N = nilnul.Num;


using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.slider_
{
	public class Func:SliderA, SliderI2
	{
		Func<N, Q1> _func;
		nilnul.num.slider_.Starter _starter = new num.slider_.Starter();

		public Func(Func<N,Q1> func, nilnul.num.slider_.Starter starter)
		{
			_func = func;
			_starter = starter;

		}


		public override Q1 current
		{
			get
			{
				return _func(_starter.current);

				//throw new NotImplementedException();
			}
		}


		public override void moveNext()
		{
			_starter.moveNext();
			//throw new NotImplementedException();
		}

		static public Func CreateNatural(Func<N,Q1> func) {
			return new Func(func, new num.slider_.Starter());
		}

		static public Func CreatePositive(Func<N,Q1> func) {
			return new Func(func,  num.slider_.Starter.CreatePositive());
		}
		static public Func CreatePlural(Func<N,Q1> func) {
			return new Func(func,  new num.slider_.Starter(2));
		}
		static public Func CreatePoly(Func<N,Q1> func) {
			return new Func(func,  new num.slider_.Starter(3));
		}



	}
}
