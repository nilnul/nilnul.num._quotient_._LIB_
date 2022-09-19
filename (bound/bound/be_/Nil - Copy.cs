using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.border.duo.be_;
using nilnul.obj;

namespace nilnul.num.quotient.bound.be_
{
	public class Nil : BeI1
		,
		nilnul.obj.BeI1< nilnul.num.quotient.border.duo.be_.Nonempty.En>
	{

		public bool be(Range obj)
		{
			return obj.lower.mark == 0 && obj.upper.mark == 0;
			//throw new NotImplementedException();
		}

		public bool be(Nonempty.En obj)
		{
			return obj.lower.mark == 0 && obj.upper.mark == 0;

		}

		static public Nil Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Nil>.Instance;
			}
		}

	}
}
