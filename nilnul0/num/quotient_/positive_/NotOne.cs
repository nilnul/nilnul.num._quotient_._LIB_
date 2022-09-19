using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.positive_
{
	public class NeOne : nilnul.num.quotient.be.en_.BeDefaulted<nilnul.num.quotient.be_.positive_.NeOne>
	{
		public NeOne(Quotient1 val) : base(val)
		{
		}

		static public bool operator <(NeOne neOne, int i) { return neOne.ee < i; }

		static public bool operator >(NeOne neOne, int i) { return neOne.ee > i; }

	}
}
