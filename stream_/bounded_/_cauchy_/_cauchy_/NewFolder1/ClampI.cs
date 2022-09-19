using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.bound_._cauchy_
{
	/// <summary>
	/// this class is not needed if we use the general default squeezer: repeating the next() till we get the range we wwwant.
	/// But we can better this process by providing a custom "squeezer"
	/// </summary>
	public interface ClampI
	{
		IEnumerable< Quotient1> clamp(nilnul.num.quotient_.Positive1 diameter);
	}

	public abstract class ClampA:BoundI
		,ClampI
	{
		public abstract Range1 bound { get; }//;//=> throw new NotImplementedException();

		public IEnumerable< Quotient1> clamp( quotient_.Positive1 diameter)
		{
			while (
				bound.notSpanLessThan(diameter)
			)
			{
				yield return next();
			}
		}

		public abstract Quotient1 next();
	}


}
