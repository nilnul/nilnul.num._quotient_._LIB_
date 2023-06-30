using nilnul.num.quotient_;
using nilnul.obj.stream_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile.convergents_._seriesly.terms
{
	public class Series
		:
		obj.SeqA<DenomNonnil>
	{

		Terms8seq _terms;
		public Series(Terms8seq val)
		{
			_terms = val;
		}

		public Series(IEnumerable<BigInteger> adders):this(new Terms8seq(adders) )
		{
		}

		public override IEnumerator<DenomNonnil> GetEnumerator()
		{
			var r = DenomNonnil.Nil;
			foreach (var item in _terms)
			{
				r += item;
				yield return r;
			}

		}

	}
}
