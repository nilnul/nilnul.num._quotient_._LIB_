using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream_
{
	public class OddUnitary1 : StreamI6
	{


		private nilnul.num.stream_.Odd _odd=new num.stream_.Odd();

		public nilnul.num.stream_.Odd odd
		{
			get { return _odd; }
			set { _odd = value; }
		}


		public OddUnitary1()
		{

		}



		public Q1 next()
		{
			return Q1.CreateUnit(_odd.next());

			//throw new NotImplementedException();
		}


		
	}
}
