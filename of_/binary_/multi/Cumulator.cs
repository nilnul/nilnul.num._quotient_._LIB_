using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.op_.binary_.multi
{
	public class Cumulator
		: nilnul.num.quotient.op_.binary.cumulator_.Defaulted<op_.binary_.Multi1>
		
	{
		public Cumulator() : base(1)
		{
		}


		static public Cumulator Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cumulator>.Instance;
			}
		}

	}
}
