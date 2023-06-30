using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using System.Numerics;

namespace nilnul.num.quotient.stream.op_.unary_._alternate
{
	public class Ret :
		op_._unary.RetA1,

		StreamI6
	{

		

		public Ret(StreamI6 stream):base(stream)
		{

		}


		private nilnul.bit.stream.slider_.Alter _alter;

		public nilnul.bit.stream.slider_.Alter alter
		{
			get { return _alter; }
			set { _alter = value; }
		}


		public override Quotient1 next()
		{
			var x= arg.next();
			return _alter.next() ? x : -x;

		}
	}
}
