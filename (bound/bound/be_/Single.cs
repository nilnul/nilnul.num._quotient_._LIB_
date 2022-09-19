using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.border.duo.be_;
using nilnul.obj;

namespace nilnul.num.quotient.bound.be_
{
	public class Single : BeI2
	{

		

		public bool be(Bound obj)
		{
			return obj.lower.mark ==  obj.upper.mark ;

		}

		static public Single Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Single>.Instance;
			}
		}

	}
}
