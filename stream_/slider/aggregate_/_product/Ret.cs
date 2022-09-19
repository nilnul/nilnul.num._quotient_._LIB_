using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using S = nilnul.num. quotient.stream_.SliderI1;

namespace nilnul.num.quotient.stream_.slider.aggregate_._prod
{

	public class Ret
		:
		quotient.stream_.SliderA1

	{

		private IEnumerable<S> _args;

		public IEnumerable<S> args
		{
			get { return _args; }
			set { _args = value; }
		}

		public Ret(IEnumerable<S> streams)
		{
			_args = streams;

		}

		public override Quotient1 current
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

		public override void moveNext()
		{
			_args.ForEach(x=>x.moveNext());
		}
	}



}

