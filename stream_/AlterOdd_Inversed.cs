using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using System.Numerics;

namespace nilnul.num.quotient.stream_
{
	public class AlterOdd_Inversed : StreamI3
	{

		private nilnul.num.integer.stream.eg.OddAlter _oddAlter=new integer.stream.eg.OddAlter();

		public nilnul.num.integer.stream.eg.OddAlter oddAlter
		{
			get { return _oddAlter; }
			private set { _oddAlter = value; }
		}

		public AlterOdd_Inversed()
		{

		}




		public Simplify.Ed1 next()
		{
			return Simplify.Ed1._CreateUnit(_oddAlter.next());

			//throw new NotImplementedException();
		}
	}
}
