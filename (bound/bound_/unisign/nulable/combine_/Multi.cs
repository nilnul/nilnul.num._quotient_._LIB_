using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using B = nilnul.num.quotient.Bound;

namespace nilnul.num.quotient.bound_.unisign.nulable.combine_
{
	static public  class _MultiX
	{

		static public B _OfOneIsNilNulable(B a, B b) {
			if (a is null || b is null)
			{
				return null;
			}
			return unisign.combine_._MultiX.OfOneNil();
		}



		static public B _OfNegPositive(B negNulable, B positiveNulable) {
			if (negNulable is null || positiveNulable is null)
			{
				return null;
			}
			return unisign.combine_._MultiX.OfNegPositive(negNulable, positiveNulable);
		}

		static public B _OfPositiveNeg( B positiveNulable, B negNulable) {
			return _OfNegPositive(negNulable, positiveNulable);
		}


		public static B Range(B a, B b) {
			if (a is null || b is null)
			{
				return null;
			}
			return unisign.combine_._MultiX.Bound(a,b);
		}

	

	}
}
