using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.range_.unisign.nulable.combine_
{
	static public  class _MultiX
	{

		static public Range1 _OfOneIsNilNulable(Range1 a, Range1 b) {
			if (a is null || b is null)
			{
				return null;
			}
			return unisign.combine_._MultiX.OfOneNil();
		}



		static public Range1 _OfNegPositive(Range1 negNulable, Range1 positiveNulable) {
			if (negNulable is null || positiveNulable is null)
			{
				return null;
			}
			return unisign.combine_._MultiX.OfNegPositive(negNulable, positiveNulable);
		}

		static public Range1 _OfPositiveNeg( Range1 positiveNulable, Range1 negNulable) {
			return _OfNegPositive(negNulable, positiveNulable);
		}


		public static Range1 Range(Range1 a, Range1 b) {
			if (a is null || b is null)
			{
				return null;
			}
			return unisign.combine_._MultiX.Range(a,b);
		}

	

	}
}
