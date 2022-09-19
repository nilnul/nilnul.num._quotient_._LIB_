using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.stream.op_._unary
{
	public abstract class RetA1
		:
		nilnul.obj._call_.ArgA<nilnul.num.quotient.StreamI6>
		,
		nilnul.num.quotient.StreamI6
	{
		public RetA1(StreamI6 arg) : base(arg)
		{
		}

		public abstract nilnul.num.Quotient1 next()
		;


	}

	public class Ret_ofOp : RetA1
	{
		private nilnul.num.quotient.op_.UnaryI _op;

		public nilnul.num.quotient.op_.UnaryI op
		{
			get { return _op; }
			set { _op = value; }
		}
		public Ret_ofOp(StreamI6 arg, nilnul.num.quotient.op_.UnaryI op):base(arg)
		{
			_op = op;
		}

		public override Quotient1 next()
		{
			return _op.op(this.arg.next());
		}
	}
}
