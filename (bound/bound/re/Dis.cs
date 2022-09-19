using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.bound.re
{
	public class Dis<T>:nilnul.obj.re.Complement<nilnul.num.quotient.Bound, T>
		where T:nilnul.num.quotient.bound.ReI,new()
	{

		static public Dis<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Dis<T>>.Instance;
			}
		}

	}
}
