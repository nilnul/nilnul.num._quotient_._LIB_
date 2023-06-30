using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.stream.aggregate_._prod
{

	public class Ret
		:
		quotient.StreamI6
	{
		private IEnumerable<StreamI6> _args;
		public IEnumerable<StreamI6> args
		{
			get { return _args; }
			set { _args = value; }
		}

		public Ret(IEnumerable<StreamI6> streams)
		{
			_args = streams;

		}

		public Quotient1 next()
		{

			return (nilnul.num.quotient.aggregate_._ProductX1.Product(
				_args.Select(x => (x as nilnul.obj._stream_.NextI<nilnul.num.Quotient1>).next())
			))
			;
		}
	}



}

