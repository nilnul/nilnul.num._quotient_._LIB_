using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.stream.set.op_
{
	public class Product
	{
		[Obsolete(nameof(stream.aggregate_._prod.Ret))]
		public class Ret
			:
			quotient.StreamI3
		{

			private IEnumerable<StreamI3> _args;

			public IEnumerable<StreamI3> args
			{
				get { return _args; }
				set { _args = value; }
			}

			public Ret(IEnumerable<StreamI3> streams)
			{
				_args = streams;

			}

			public Simplify.Ed1 next()
			{

				return nilnul.num.quotient.set.op_._ProductX.Product(
					_args.Select(x=>x.next())
				)	
				;
			}
		}

		static public Ret Eval(IEnumerable<StreamI3> streams) {
			return new Ret(streams);
		}

		static public Ret Eval(params StreamI3[] streams) {
			return new Ret(streams);
		}

		

		

	}
}
