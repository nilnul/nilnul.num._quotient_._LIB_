using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be_.positive_
{
	/// <summary>
	/// </summary>
	public class NeOne
		:
		nilnul.num.quotient.BeA
		//nilnul.num.quotient.BeI4
	{
		public override bool be(Quotient1 obj)
		{
			return obj > 0 && obj !=1;
		}

		


		static public NeOne Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NeOne>.Instance;
			}
		}

	}
}
