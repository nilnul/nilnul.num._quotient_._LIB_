using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be_.nonneg_
{
	/// <summary>
	/// 	 alias: proper
	/// </summary>
	public class LtOne
		: nilnul.num.quotient.BeI4
	{
		public bool be(Quotient1 obj)
		{
			return obj >= 0 && obj <1;
		}

		


		static public LtOne Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<LtOne>.Instance;
			}
		}

	}
}
