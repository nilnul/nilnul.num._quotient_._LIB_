using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.border.be_
{
	public class Closed : nilnul.num.quotient.border.BeI1
	{

		public bool be(Border2 obj)
		{
			return obj.openFalseCloseTrue;
		}


		static public Closed Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Closed>.Instance;
			}
		}



	}
}
