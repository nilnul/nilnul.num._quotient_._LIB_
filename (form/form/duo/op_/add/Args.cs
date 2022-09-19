using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.form.duo.op_.add
{
	public class Args
		: nilnul._call.argArg1_.Closed<Q1>

	{
		public Q1 augend { get
			{
				return arg;
			}

		}

		public Q1 addend {
			get {
				return arg1;
			}
		}
		public Args(Q1 arg, Q1 arg1) : base(arg, arg1)
		{
		}
	}
}
