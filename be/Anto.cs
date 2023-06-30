using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be
{
	public class Anto<T>:nilnul.obj.be.Anto<nilnul.num.Quotient1,T>
		where T: nilnul.num.quotient.BeI4,new()
	{

		static public Anto<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Anto<T>>.Instance;
			}
		}

	}
}
