using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.cauchy.set.be_
{
	public class Any
		:

		BeI
	{
		public bool be(SetI obj)
		{
			return obj.arr.Any();
			//throw new NotImplementedException();
		}

		static public Any Singleton
		{
			get
			{
				return nilnul.Singleton1<Any>.Instance;
			}
		}

	}
}
