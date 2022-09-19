using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider_.factorial
{
	public class Inverse : nilnul.num.quotient.stream_.slider.op_._unary.Ret_ofOp
	{
		public Inverse() : base(
			new nilnul.num.quotient.stream_.slider_.Factorial()
			,
			nilnul.num.quotient.op_.unary_.Inverse.Singleton
		)
		{
		}
	}
}
