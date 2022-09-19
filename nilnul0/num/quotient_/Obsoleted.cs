using nilnul.num;
//using nilnul.num._quotient.fraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_
{
	static public class _ObsoletedX
	{
		static public nilnul.num.Quotient1 ToQuotient(this num._quotient.fraction.op.Simplify.Ed1 ed) {
			return  Quotient1.CreateByDivide(
				ed.numerator,
				ed.denominator
			);
		}



		//static public nilnul.num.Quotient1 Fro(num._quotient.fraction.Simplify. ed) {
		//	return  num.Quotient1.CreateByDivide(
		//		ed.numerator,
		//		ed.denominator
		//	);
		//}

	}
}
