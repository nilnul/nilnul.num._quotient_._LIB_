using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.border.duo.be_;
using nilnul.obj;

namespace nilnul.num.quotient.bound_.closed.be_
{
	public class Nil :
		num.quotient.bound_.closed.BeI
		//,
		//nilnul.obj.BeI1< nilnul.num.quotient.border.duo.be_.Nonempty.En>
	{

		public bool be(bound_.Closed obj)
		{
			return obj.lower.mark == 0 && obj.upper.mark == 0;
			//throw new NotImplementedException();
		}

		//public bool be(num.quotient.BoundI obj)
		//{
		//	return obj.lower.mark == 0 && obj.upper.mark == 0;

		//}

		static public Nil Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nil>.Instance;
			}
		}

	}
}
