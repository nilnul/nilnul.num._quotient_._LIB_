using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider.aggregate_._prod
{

	public class Ret
		:
		quotient.SliderI2
	{

		private IEnumerable<SliderI2> _args;

		public IEnumerable<SliderI2> args
		{
			get { return _args; }
			set { _args = value; }
		}

		public Ret(IEnumerable<SliderI2> streams)
		{
			_args = streams;

		}

		public Quotient1 current
		{
			get
			{
				return (
					nilnul.num.quotient.aggregate_._ProductX1.Product(
					_args.Select(x => x.current)
				))
				;

			}
		}

		public void moveNext()
		{
			_args.ForEach(x=>x.moveNext());
		}
	}



}

