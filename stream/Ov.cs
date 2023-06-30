using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream
{
	public abstract class Ov<T> :
		nilnul.obj.Box<T>,
		StreamI6
	{
		public Ov(T val) : base(val)
		{
		}

		public abstract Quotient1 next();
	}
}
