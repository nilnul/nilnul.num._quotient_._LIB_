using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.stream._op
{
	[Obsolete()]
	public abstract class Ret:nilnul.Box1<StreamI3>
		,StreamI3
	{
		public Ret(StreamI3 stream)
			:base(stream)
		{

		}

		public abstract Simplify.Ed1 next()
		;
	}
}
