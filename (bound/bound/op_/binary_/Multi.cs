using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using B = nilnul.num.quotient.Bound;


namespace nilnul.num.quotient.bound.op_.binary_
{
	static public class _MultiX
	{
		public static Bound Op(Bound x, Bound y)
		{

			var xSplit = _SplitX.Triplet(x);
			var ySplit = _SplitX.Triplet(y);

			var aa = bound_.unisign_.neg.nulable.combine_._MultiX.Bound(
				xSplit.Item1,
				ySplit.Item1
			);
			var ab = bound_.unisign.nulable.combine_._MultiX._OfOneIsNilNulable(
				xSplit.Item1
				,
				ySplit.Item2
			);
			var ac = bound_.unisign.nulable.combine_._MultiX._OfNegPositive(
				xSplit.Item1,
				ySplit.Item3
			);

			var ba = bound_.unisign.nulable.combine_._MultiX._OfOneIsNilNulable(xSplit.Item2, ySplit.Item1);
			var bb = bound_.unisign.nulable.combine_._MultiX._OfOneIsNilNulable(xSplit.Item2, ySplit.Item2);
			var bc = bound_.unisign.nulable.combine_._MultiX._OfOneIsNilNulable(xSplit.Item2, ySplit.Item3);

			var ca = bound_.unisign.nulable.combine_._MultiX._OfPositiveNeg(xSplit.Item3, ySplit.Item1);
			var cb = bound_.unisign.nulable.combine_._MultiX._OfOneIsNilNulable(xSplit.Item3, ySplit.Item2);
			var cc = bound_.unisign_.positive.nulable.combine_._MultiX.Bound(xSplit.Item3, ySplit.Item3);

			var nilMarkedNeg = bound_.nilMarked_.neg.nulable.combine_._UnionX.Bound(ac, ca);
			var nilMarkedNil = bound_.nilMarked_.nil.nulable.accumulate_._UnionX.Bound(ab, bb, cb, ba, bc);
			var nilMarkedPositive = bound_.nilMarked_.positive.nulable.combine_._UnionX.Bound(aa, cc);

			return bound_.nilMarked.nulable.trio_.joinable._ConcatX.Concat(
				nilMarkedNeg,
				nilMarkedNil,
				nilMarkedPositive);
		}
		static public B Square(B x)
		{
			return Op(x, x);
		}

	}
}
