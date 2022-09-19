using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.range.op_.binary_
{
	static public class _MultiX
	{
		public static Range1 Op(Range1 x, Range1 y)
		{

			var xSplit = _SplitX.Triplet(x);
			var ySplit = _SplitX.Triplet(y);

			var aa = range_.unisign_.neg.nulable.combine_._MultiX.Range(
				xSplit.Item1,
				ySplit.Item1
			);
			var ab = range_.unisign.nulable.combine_._MultiX._OfOneIsNilNulable(
				xSplit.Item1
				,
				ySplit.Item2
			);
			var ac = range_.unisign.nulable.combine_._MultiX._OfNegPositive(
				xSplit.Item1,
				ySplit.Item3
			);

			var ba = range_.unisign.nulable.combine_._MultiX._OfOneIsNilNulable(xSplit.Item2, ySplit.Item1);
			var bb = range_.unisign.nulable.combine_._MultiX._OfOneIsNilNulable(xSplit.Item2, ySplit.Item2);
			var bc = range_.unisign.nulable.combine_._MultiX._OfOneIsNilNulable(xSplit.Item2, ySplit.Item3);

			var ca = range_.unisign.nulable.combine_._MultiX._OfPositiveNeg(xSplit.Item3, ySplit.Item1);
			var cb = range_.unisign.nulable.combine_._MultiX._OfOneIsNilNulable(xSplit.Item2, ySplit.Item2);
			var cc = range_.unisign_.positive.nulable.combine_._MultiX.Range(xSplit.Item2, ySplit.Item3);

			var nilMarkedNeg = range_.nilMarked_.neg.nulable.combine_._UnionX.Range(ac, ca);
			var nilMarkedNil = range_.nilMarked_.nil.nulable.accumulate_._UnionX.Range(ab, bb, cb, ba, bc);
			var nilMarkedPositive = range_.nilMarked_.neg.nulable.combine_._UnionX.Range(aa, cc);

			return range_.nilMarked.nulable.trio_.joinable._ConcatX.Concat(
				nilMarkedNeg,
				nilMarkedNil,
				nilMarkedPositive);
		}
		static public Range1 Square(nilnul.num.quotient.Range1 x)
		{
			return Op(x, x);
		}

	}
}
