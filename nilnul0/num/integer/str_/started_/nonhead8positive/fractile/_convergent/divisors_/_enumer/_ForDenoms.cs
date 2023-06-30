using nilnul.obj.stream_._slider._skim_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile._convergent.divisors_._enumer
{

	/// <summary>
	/// the intial adder:<see cref="_fractile.AddersI"/> is ignored; we only take in <see cref="_fractile._adders_.DenomsI"/>;
	/// as the initial lower is always 1, it's not treated here;
	/// </summary>
	public class _ForDenoms
		:
		IEnumerator<BigInteger>

	{
		const int PREV = 0;
		const int INIT = 1;


		/// <summary>
		/// the previous adder; initialized as 0;
		/// </summary>
		BigInteger _prev = PREV;
		public BigInteger prev { get { return _prev; } }

		/// <summary>
		/// the current value of lowers; initially, this is 1.
		/// </summary>
		BigInteger _current = INIT;


		IEnumerator<BigInteger> _denoms;    //emptible;


		/// <summary>
		/// 
		/// </summary>
		/// <param name="denoms_">
		/// the intial adder is ignored;
		/// </param>
		internal _ForDenoms(IEnumerator<BigInteger> denoms_)
		{
			_denoms = denoms_;
		}

		public BigInteger Current => _current;

		object IEnumerator.Current => Current;

		public void Dispose()
		{
			_denoms.Dispose();
			//_adders.dis
		}



		/// <summary>
		/// the initla lower is always 1, which is not dealt here; 
		/// </summary>
		/// <returns></returns>
		public bool MoveNext()
		{
			if (_denoms.MoveNext())
			{
				_current =_prev + (_prev=_current) * _denoms.Current ;
				return true;
			}
			return false;
		}

		public void Reset()
		{
			_prev =PREV;
			_current = INIT;
			_denoms.Reset();

			//throw new NotImplementedException();
		}
	}
}
