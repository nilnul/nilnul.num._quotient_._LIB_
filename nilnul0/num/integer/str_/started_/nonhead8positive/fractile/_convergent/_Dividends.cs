using nilnul.obj.stream_._slider._skim_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile._convergent
{

	public class _Dividends
		:
		nilnul.obj._seq_.GetEnumeratorA<BigInteger>
		,
		IEnumerable<BigInteger>

	{
		/// <summary>
		/// the previous adder; initialized as 0;
		/// </summary>
		BigInteger _prev = 0;



		BigInteger _current = 1;

		/// <summary>
		/// the current value of adders; 
		/// </summary>

		IEnumerable<BigInteger> _adders;    //started;


		internal _Dividends(IEnumerable<BigInteger> adders_)
		{
			_adders = adders_;
		}



		/// <summary>
		/// we get an enumerator|slider from the underlying seq;
		/// </summary>
		/// <returns></returns>
		public override IEnumerator<BigInteger> GetEnumerator()
		{

			foreach (var item in _adders)
			{
				yield return _current = _prev + _current * item;		/// initially, this is a0.

				_prev = _current;
			}

		}


	}
}
