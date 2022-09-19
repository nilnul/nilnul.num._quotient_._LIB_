using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.op_;

namespace nilnul.num.quotient.stream_.slider.op_._binary
{
	public abstract class RetA
		:
		nilnul.num.quotient.stream_.slider._calc.ArgArg1A
		,
		nilnul.num.quotient.stream_.SliderI1
	{
		public RetA(SliderI1 arg, SliderI1 arg1) : base(arg,arg1)
		{
		}

		public abstract Quotient1 current { get; }

		public void moveNext() { arg.moveNext(); arg1.moveNext(); }
		public  nilnul.num.Quotient1 next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
		}


	}

	public class Ret_ofOp : RetA
	{
		private nilnul.num.quotient.op_.BinaryI1 _op;

		public nilnul.num.quotient.op_.BinaryI1 op
		{
			get { return _op; }
			set { _op = value; }
		}

		public override Quotient1 current => _op.op(arg.current,arg1.current);

		public Ret_ofOp(
			num.quotient.stream_.SliderI1 arg
			,
			num.quotient.stream_.SliderI1 arg1
			,
			nilnul.num.quotient.op_.BinaryI1 op
		):base(arg,arg1)
		{
			_op = op;
		}

		
	}

	public class Ret_ofOpDefault<T> : Ret_ofOp
		where T: num.quotient.op_.BinaryI1,new()
	{
		public Ret_ofOpDefault(SliderI1 arg, SliderI1 arg1) : base(
			arg,
			arg1,
			nilnul.obj_.singleton_.Lazy<T>.Instance
		)
		{
		}
	}
}
