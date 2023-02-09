using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.range_.unisign_.nonnil.combine_
{
	static public  class _MultiX
	{
		public static Range1 _Range(Range1 _nonnil, Range1 _nonnil1) {
			if (_nonnil.lower.mark>=0)
			{
				if (_nonnil1.lower.mark>=0)
				{
					return unisign_.positive.combine_._MultiX.Range(_nonnil, _nonnil1);
					
				}
				else // b.lower.mark<0
				{
					return unisign.combine_._MultiX.OfPositiveNeg(_nonnil, _nonnil1);
				}
			}
			else
			{
				if (_nonnil1.lower.mark>=0)
				{
					return unisign.combine_._MultiX.OfNegPositive(_nonnil, _nonnil1);
				}
				return unisign_.neg.combine_._MultiX.Range(_nonnil, _nonnil1);
			}
			
		}


	}
}
