using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream_
{
	public class OddUnitary : StreamI3
	{


		private nilnul.num.stream_.Odd _odd=new num.stream_.Odd();

		public nilnul.num.stream_.Odd odd
		{
			get { return _odd; }
			set { _odd = value; }
		}


		public OddUnitary()
		{

		}



		public Simplify.Ed1 next()
		{
			return Simplify.Ed1._CreateUnit(_odd.next());

			//throw new NotImplementedException();
		}
		
	}
}
