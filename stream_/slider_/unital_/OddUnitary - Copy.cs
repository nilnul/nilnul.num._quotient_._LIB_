using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.slider_.unitary_
{
	public class OddUnitary : SliderI2
		
	{


		private nilnul.num.slider_.Odd1 _odd=new num.slider_.Odd1();

		public nilnul.num.slider_.Odd1 odd
		{
			get { return _odd; }
			set { _odd = value; }
		}

		public Q1 current => Q1.CreateUnit(_odd.current);

		public OddUnitary()
		{

		}

		public void moveNext()
		{
			odd.moveNext();

		}
	}
}
