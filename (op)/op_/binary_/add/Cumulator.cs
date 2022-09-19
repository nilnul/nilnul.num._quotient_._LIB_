using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.op_.binary_.add
{
	public class Cumulator
		: nilnul.num.quotient.op_.binary.cumulator_.Defaulted<op_.binary_.Add>
		
	{
		public Cumulator() : base(nilnul.obj_.Singleton<nilnul.num.Quotient1>.Instance)
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
