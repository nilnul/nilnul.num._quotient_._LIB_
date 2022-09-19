using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.border.duo.be_.nonempty
{
	public class En2 : nilnul.num.quotient.border.duo.be.En1<Nonempty>

	{
		public En2(Duo1 val) : base(val)
		{
		}

		//public En2(Duo val) : this(new Duo1(val.lower,val.upper))
		//{
		//}

		public nilnul.num.Quotient1 diameter
		{
			get
			{
				return  en.upper.mark - en.lower.mark;
			}
		}

		public nilnul.num.Quotient1 midPoint
		{
			get
			{
				return (en.lower.mark + en.upper.mark) / 2;
			}
		}

	}
}
