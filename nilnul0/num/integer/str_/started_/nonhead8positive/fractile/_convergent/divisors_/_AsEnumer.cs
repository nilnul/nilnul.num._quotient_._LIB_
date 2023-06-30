using nilnul.obj.stream_._slider._skim_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile._convergent.divisors_
{

	public class _AsEnumerator
		:
		IEnumerator<BigInteger>

	{
		const int PREV = 1;
		const int INIT = 0;

		BigInteger _prev = PREV;
		public BigInteger prev { get { return _prev; } }


		/// <summary>
		/// the previous adder; initialized as 0;
		/// </summary>
		//public BigInteger prev => _prev;
		BigInteger _current = INIT;

		/// <summary>
		/// the current value of adders; initially, this is 1.
		/// </summary>
		//public BigInteger current => _current;

		IEnumerator<BigInteger> _adders;    //started;


		internal _AsEnumerator(IEnumerator<BigInteger> adders_)
		{
			_adders = adders_;
		}

		public BigInteger Current => _current;

		object IEnumerator.Current => Current;

		public void Dispose()
		{
			_adders.Dispose();
			//_adders.dis
		}



		/// <summary>
		/// initial item is 1, the next item is a1, or adder[1]. Note adder[0] is used only in upper, not lower; 
		/// </summary>
		/// <returns></returns>
		public bool MoveNext()
		{
			if (_adders.MoveNext())
			{
				_current =_prev + (_prev=_current) * _adders.Current ;
				return true;
			}
			return false;
		}

		public void Reset()
		{
			_prev = PREV;
			_current =INIT;
			_adders.Reset();

			//throw new NotImplementedException();
		}
	}
}
