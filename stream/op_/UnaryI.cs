using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.op_;

namespace nilnul.num.quotient.stream.op_
{
	public interface UnaryI:nilnul.obj.op_._unary_.par_.retPar_.ClosedI1<StreamI6>
	{
	}

	public class Unary :
		nilnul.obj.Box<nilnul.num.quotient.op_.UnaryI>
		,
		UnaryI
	{
		public Unary(quotient.op_.UnaryI val) : base(val)
		{
		}

		public StreamI6 op(StreamI6 par)
		{
			return new _unary.Ret_ofOp(par, this.boxed);
		}
	}
}
