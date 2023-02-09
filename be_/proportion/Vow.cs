using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be_.proportion
{
	public class Vow
		:be.Vow3< Proportion>
	{

		static public Vow Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow>.Instance;
			}
		}

	}
}
