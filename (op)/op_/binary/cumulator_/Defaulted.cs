using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.op_.binary.cumulator_
{
	public class Defaulted<TOp> : Cumulator
		where TOp : nilnul.num.quotient.op_.BinaryI1, new()
	{
		public Defaulted(Quotient1 initial) : base(initial, nilnul.obj_.Singleton<TOp>.Instance)
		{
		}
	}


}
