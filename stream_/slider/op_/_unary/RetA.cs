using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.stream_.slider.op_._unary
{
	public abstract class RetA
		:
		nilnul.obj._call_.ArgA<nilnul.num.quotient.stream_.SliderI1>
		,
		nilnul.num.quotient.stream_.SliderI1
	{
		public RetA(SliderI1 arg) : base(arg)
		{
		}

		public abstract Quotient1 current { get; }

		public void moveNext() { arg.moveNext(); }
		public  nilnul.num.Quotient1 next()
		{
			return nilnul.obj.stream_._slider_.NextX.Next(this);
		}


	}

	public class Ret_ofOp : RetA
	{
		private nilnul.num.quotient.op_.UnaryI _op;

		public nilnul.num.quotient.op_.UnaryI op
		{
			get { return _op; }
			set { _op = value; }
		}

		public override Quotient1 current => _op.op(arg.current);

		public Ret_ofOp(num.quotient.stream_.SliderI1 arg, nilnul.num.quotient.op_.UnaryI op):base(arg)
		{
			_op = op;
		}

		
	}
}
