using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.slider_.bernoulli_
{
	public class Recur1 : SliderI2
	{
		private List<Q1> _previous=new List<Q1>() { 1};

		public List<Q1> previous
		{
			get { return _previous; }
			set { _previous= value; }
		}


		public Q1 current
		{
			get
			{
				return _previous.Last();
				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			var count = _previous.Count;
			
			_previous.Add(
				-
				nilnul.num.quotient.accumulate_._SumX.Sum(
					_previous.Select(
						(x,i)=>  nilnul.num.duo_.ge.combine_._combinate.Extensions._Eval(
							count,i  
						)
						*
						x
						/ 
						(count -i+1) 
					)
				)
			);
			//throw new NotImplementedException();
		}
	}
}
