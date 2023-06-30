using System;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_._recurFrac.denoms.be_
{

	public class Nonproper : denoms.Be
	{
		public Nonproper() : base(_NonproperX.Be)
		{
		}


		static public Nonproper Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonproper>.Instance;
			}
		}

	}
}
