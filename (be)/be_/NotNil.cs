using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.be_
{
	public class NotNil
		:nilnul.num.quotient.BeI2
	{
		public bool be(Q1 obj)
		{
			return obj.numerator != 0;
			//throw new NotImplementedException();
		}

		static public NotNil Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NotNil>.Instance;
			}
		}

	}
}
