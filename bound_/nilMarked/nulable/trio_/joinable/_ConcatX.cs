using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B = nilnul.num.quotient.Bound;


namespace nilnul.num.quotient.bound_.nilMarked.nulable.trio_.joinable
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ConcatX
	{

		static public B _WhenNegNul(B nil, B positive) {
			if (nil is null)
			{
				return positive;
			}
			if (positive is null)
			{
				return nil;
			}
			return bound_.nilMarked_._NatX._Create(positive.upper);
		}


		static public B Concat(B neg, B nil, B positive) {
			if (neg is null)
			{
				return _WhenNegNul(nil,positive);
			}

			///neg is not null
			if (nil is null)
			{
				return neg;
			}

			/// nil is not null
			if (positive is null)
			{
				return new B(neg.lower, Border2.CreateZeroClose());
			}
			return new B(neg.lower, positive.upper);
		}
	}
}
