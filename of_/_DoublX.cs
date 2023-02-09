using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.continuedFrac_;
using System.Numerics;
using nilnul.num.natural;
using nilnul.num.rational.cf;
using nilnul._num.bigint.be;

namespace nilnul.num.quotient_
{
	[Obsolete(nameof(_DblX))]
	static public class _DoublX
	{
		
		

		static public nilnul.num.Quotient Constuct(double src, nilnul.num.quotient_.Positive1 precision) {
			 var x= ( recurFrac.fro_.dbl_._PrecisionedX.Quotient(src,precision));

			return new Quotient(x.numerator,x.denominator);
		}


		static public nilnul.num.Quotient Constuct_precisionDenom(double src, nilnul.num_.Positive precision) {
			return Constuct(
				src,
				new Positive1( nilnul.num.Quotient.CreatePositiveUnital(precision))
			);
		}

		static public nilnul.num.Quotient Constuct_precisionDenom(double src, int precision) {
			return Constuct_precisionDenom(
				src,
				new nilnul.num_.Positive(precision)
			);
		}




	}
}
