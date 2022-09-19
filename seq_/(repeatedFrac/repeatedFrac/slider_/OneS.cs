using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._stream_;
using nilnul.num.quotient.continuedFrac_;
using Positive1 = nilnul._num.bigint.be.Positive1.Asserted;

namespace nilnul.num.quotient.continuedFrac.slider_
{
	/// <summary>
	/// this is the most "irrational number" in that:
	///		if we truncate a proper, we get a quotient which is an approxmate to the number. To make the truncate bigger, the denominator has to be the smallest, which is one. So with all ones, that means the error in rationalizing is the largest.
	/// </summary>
	public class OneS : SliderI
	{
		private continuedFrac_.ForIrrational _current=new ForIrrational(1);

		
		public ForIrrational current
		{
			get
			{
				return _current;
				throw new NotImplementedException();
			}
		}

		public void moveNext()
		{

			_current= new ForIrrational(
				1
				,
				new Positive1[] {
					new Positive1(
					_current.floor
					)
				}.Concat(
					_current.proper.denominators
				)	
			);
			//throw new NotImplementedException();
		}

		
	}
}
