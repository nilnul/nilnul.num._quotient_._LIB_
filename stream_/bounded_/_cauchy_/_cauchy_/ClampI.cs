using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_._cauchy_
{
	/// <summary>
	/// this class is not needed if we use the general default squeezer: repeating the next() till we get the range we wwwant.
	/// But we can better this process by providing a custom "squeezer"
	/// </summary>
	public interface ClampI
	{
		void clamp(nilnul.num.quotient_.Positive1 diameter);
	}

	static public class ClampX
	{
		static public void Clamp(this stream_.BoundI cauchy,  quotient_.Positive1 diameter)
		{
			while (
				cauchy.bound.notSpanLessThan(diameter)
			)
			{
				(cauchy as nilnul.obj._stream_.NextI<nilnul.num.Quotient1>).next();
			}
		}
	}


}
