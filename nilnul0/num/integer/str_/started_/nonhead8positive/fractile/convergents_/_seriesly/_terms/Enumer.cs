using nilnul.num.quotient_;
using nilnul.num.quotient_._recurFrac;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile.convergents_._seriesly._terms
{

	/// <summary>
	/// the slider for the series;
	/// the first term is a0, or adder at 0th;
	/// when moving next, the computation is carried out on 
	/// </summary>
	public class Enumer
		:
		IEnumerator<DenomNonnil>
	{
		nilnul.bit.stream_.slider_.Alter _sign = new bit.stream_.slider_.Alter();
		nilnul.num.integer.str_.started_.nonhead8positive.fractile._convergent.divisors_._AsEnumerator _lowers;

		/// <summary>
		/// the adders; assume it's started;
		/// </summary>
		/// <param name="val">
		/// plural;
		/// </param>
		private Enumer(nilnul.num.integer.str_.started_.nonhead8positive.fractile._convergent.divisors_._AsEnumerator x)
		{
			_lowers = x;
		}

		BigInteger _adder0;
		private Enumer(IEnumerator<BigInteger> x) : this(new nilnul.num.integer.str_.started_.nonhead8positive.fractile._convergent.divisors_._AsEnumerator(x))
		{

		}

		public Enumer(IEnumerable<BigInteger> x):this(x.GetEnumerator())
		{
			_adder0=x.First();
		}

		private DenomNonnil _current;
		/// <summary>
		/// </summary>
		/// <remarks>
		/// </remarks>
		public DenomNonnil Current => _current;
		object IEnumerator.Current => Current;

		public void Dispose()
		{
			_lowers.Dispose();
		}

		//bool _ini;
		bool _nonini = false;
		public bool MoveNext()
		{
			if (_lowers.MoveNext())
			{
				if (_nonini)
				{
					_current = nilnul.num.quotient_.DenomNonnil.Inverse(
						_sign.current ? _lowers.Current * _lowers.prev : -_lowers.Current * _lowers.prev
					);
				}
				else // index at 0;
				{
					_current = _adder0; /// note: here for the series, the initial is adder0=a0, not lower0=1=d0;
					_nonini = true;
				}
				_sign.moveNext();
				return true;
			}
			return false;
		}

		public void Reset()
		{
			_lowers.Reset();
		}
	}
}
