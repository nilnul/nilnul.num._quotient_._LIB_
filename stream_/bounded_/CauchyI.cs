using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.bounded_

{
	/// <summary>
	/// you can get the bound to predict that next(), in other words, next() will fall in the bound
	/// </summary>
	/// <remarks>
	///	if the bound is closed, we can make it open by squeeze half the diameter, but if one side is closed, and the halved bound is still closed there, we cannot make that border open.
	///	if the bound is open, we can make it closed by merging border; and proceed to squeeze it to infinitesimal.
	///
	/// make the bound.diameter to be strictly LessThan given positive para to simplify
	/// optinally make the bound closed to simplify; and when it comes to realNumber, make the bound closed as must. We will leave the bound open or close to demostrate later in real number that limit can fall on border.
	///
	///leave the bound possibility of being not closed such that it will participate in operation of streams other than defining real number.
	///for example, we can define a stream which is the inversion of (1/n); and this stream approaches infinity, and is useful in some case.
	/// </remarks>
	/// 
	public interface CauchyI :
		nilnul.num.quotient.stream_.bounded_._cauchy_.SqueezeI_boundDiameterLt
		,
		nilnul.num.quotient.stream_.BoundedI
	{

	}

	public abstract class CauchyA : CauchyI
	{
		static public void Squeeze(CauchyI cauchy, quotient_.Positive1 diameter)
		{
			while (
				cauchy.bound.isNotDiameterLt(diameter)
			)
			{
				cauchy.next();
			}

		}
		public abstract num.quotient.Bound bound { get; }//;//=> throw new NotImplementedException();

		public void makeBoundDiameterLt(quotient_.Positive1 diameter)
		{
			Squeeze(this, diameter);
		}

		public abstract Quotient1 next();
	}


}
