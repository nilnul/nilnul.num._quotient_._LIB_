using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.collection.op
{
	public partial class SameDenominator
	{
		static public IEnumerable<Fraction140728> Eval(IEnumerable<R> nonEmpty) {

			var lcmOfDenom=		nilnul.num.natural.collection.op.Lcm.Eval(nonEmpty.Select(q => new natural.Natural_bigInteger( q.denominator.val) ));

			foreach (var item in nonEmpty)
			{
				var multi=lcmOfDenom / item.denominator.val;
				yield return item.multiBothDenomAndNumerator(multi);
				
			}
 

		
		}
	}
}
