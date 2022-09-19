using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.border.duo.be_;
using nilnul.obj;

namespace nilnul.num.quotient.bound.be_
{
	public class Nil1 :
		num.quotient.bound.BeI2
		//,
		//nilnul.obj.BeI1< nilnul.num.quotient.border.duo.be_.Nonempty.En>
	{

		public bool be(Bound obj)
		{
			return obj.lower.mark == 0 && obj.upper.mark == 0;
			//throw new NotImplementedException();
		}

		//public bool be(num.quotient.BoundI obj)
		//{
		//	return obj.lower.mark == 0 && obj.upper.mark == 0;

		//}

		static public Nil1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nil1>.Instance;
			}
		}

	}
}
