using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.range_.nilMarked.nulable.trio_.joinable
{
	static public class _ConcatX
	{

		static public Range1 _WhenNegNul(Range1 nil, Range1 positive) {
			if (nil is null)
			{
				return positive;
			}
			if (positive is null)
			{
				return nil;
			}
			return range_.nilMarked_._NatX._Create(positive.upper);
		}


		static public Range1 Concat(Range1 neg, Range1 nil, Range1 positive) {
			if (neg is null)
			{
				return _WhenNegNul(nil,positive);
			}
			if (nil is null)
			{
				return neg;
			}
			if (positive is null)
			{
				return new Range1(neg.lower, Border2.CreateZeroClose());
			}
			return new Range1(neg.lower, positive.upper);
		}
	}
}
