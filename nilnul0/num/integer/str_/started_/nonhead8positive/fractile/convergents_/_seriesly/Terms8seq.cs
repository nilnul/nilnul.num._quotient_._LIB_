using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile.convergents_._seriesly
{

	/// <summary>
	/// the slider for the series;
	/// the first term is a0, or adder at 0th;
	/// when moving next, the computation is carried out on 
	/// </summary>
	public class Terms8seq
		:
		nilnul.obj.SeqA<DenomNonnil>
	{

		IEnumerable<BigInteger> _adders;
		/// <summary>
		/// the adders; assume it's started;
		/// </summary>
		/// <param name="val">
		/// started;
		/// </param>

		public Terms8seq(IEnumerable<BigInteger> x)
		{
			_adders = x;
		}

	
		public override IEnumerator<DenomNonnil> GetEnumerator()
		{
			return new _terms.Enumer(
				this._adders
			);

		}

		static public Terms8seq _Of_0started(IEnumerable<int> x) 
		{
			return new Terms8seq(
				x.Select(
					t=>(BigInteger)t
				)
			);
		}


	}
}
