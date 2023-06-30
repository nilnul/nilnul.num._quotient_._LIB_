using nilnul.obj.stream_._slider._skim_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile._convergent.divisors_.enumer
{

	public class _On2seq
		:
		nilnul.obj._seq_.GetEnumeratorA<BigInteger>
		,
		IEnumerable<BigInteger>

	{
	

		IEnumerable<BigInteger> _adders;	//started;


		 internal _On2seq(IEnumerable< BigInteger> adders_ ) 
		{
			_adders = adders_;
		}



		/// <summary>
		/// we get an enumerator|slider from the underlying seq;
		/// </summary>
		/// <returns></returns>
		public override IEnumerator<BigInteger> GetEnumerator()
		{

			return new divisors_._AsEnumerator(
				_adders.GetEnumerator()
			);

		}

	
	}
}
