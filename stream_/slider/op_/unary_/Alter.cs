using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider.op_.unary_
{
	/// <summary>
	/// make the term positive, negative alternatively
	/// </summary>
	public class Alter : UnaryI
	{
		public num.quotient.stream_.SliderI1 op(num.quotient.stream_.SliderI1 par)
		{
			return new _alter.Ret(par);
			//throw new NotImplementedException();
		}

		static public Alter Singleton
		{
			get
			{
				return nilnul.Singleton1<Alter>.Instance;
			}
		}

	}
}
