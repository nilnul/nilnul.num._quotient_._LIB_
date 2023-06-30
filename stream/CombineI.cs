using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream
{
	public interface CombineI
		:nilnul.obj.CombineI1<nilnul.num.quotient.StreamI6>
	{
	}

	public class Combine :
		nilnul.obj.Box<nilnul.num.quotient.CombineI2>
		,
		CombineI
	{
		public Combine(CombineI2 val) : base(val)
		{
		}

		public StreamI6 combine(StreamI6 arg, StreamI6 arg1)
		{
			return new _combine.Ret(arg,arg1,boxed);
		}
	}

}
