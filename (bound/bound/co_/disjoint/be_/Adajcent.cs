using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.bound.co_.disjoint.be_
{
	/// <summary>
	/// given two disjoint bound , they do not share the same mark
	/// </summary>
	static public class _AdajcentX
	{
		static public bool Be_assumeDisjointAndLeftLower(num.quotient.Bound left, num.quotient.Bound y) {

			return left.upper.mark == y.lower.mark;
		}

		static public bool Be_assumeDisjointAndLeftUpper(num.quotient.Bound left, num.quotient.Bound y) {

			return Be_assumeDisjointAndLeftLower(y, left);
		}

		static public bool Be_assumeDisjoint(num.quotient.Bound bound, num.quotient.Bound right) {
			return Be_assumeDisjointAndLeftLower(bound, right)
				|| Be_assumeDisjointAndLeftUpper(bound, right);
		}


	}
}
