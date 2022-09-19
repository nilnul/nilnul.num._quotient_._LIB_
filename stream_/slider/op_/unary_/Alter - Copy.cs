using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.slider.op_.unary_
{
	/// <summary>
	/// make the term positive, negative alternatively
	/// </summary>
	public class Alter : UnaryI
	{
		public SliderI2 op(SliderI2 par)
		{
			return new _alter.Ret(par);
			throw new NotImplementedException();
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
