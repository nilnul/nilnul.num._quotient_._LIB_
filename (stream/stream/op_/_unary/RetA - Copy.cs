using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.stream.op_._unary
{
	[Obsolete()]
	public abstract class RetA
		:
		nilnul.obj._call_.ArgA<nilnul.num.quotient.StreamI5>
		,
		nilnul.num.quotient.StreamI5
	{
		public RetA(StreamI5 arg) : base(arg)
		{
		}

		public abstract nilnul.num.QuotientI next()
		;


	}
}
