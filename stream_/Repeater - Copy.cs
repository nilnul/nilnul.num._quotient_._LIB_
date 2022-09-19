using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream.eg
{
	public class Repeater : StreamI3
	{
		private Simplify.Ed1 _q;

		public Simplify.Ed1 q
		{
			get { return _q; }
			set { _q = value; }
		}

		public Repeater(Simplify.Ed1 q)
		{
			_q = q;
		}




		public Simplify.Ed1 next()
		{
			return _q;
			throw new NotImplementedException();
		}
	}
}
