using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.QuotientI;//.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.aggregate_
{
	static public  class _ProductX1
	{
		
		static public Q1 Product(this IEnumerable<Q1> x) {

			return x.Aggregate((Q1)(nilnul.num.Quotient1)1, 
				nilnul.num.quotient.op_.binary_.Multi.Singleton.op

			);
		
		}
		static public nilnul.num.Quotient1 Product(this IEnumerable<nilnul.num.Quotient1> x) {

			return x.Aggregate(
				(nilnul.num.Quotient1)1, 
				nilnul.num.quotient.combine_.Multi.Singleton.combine

			);
		
		}


	}
}
