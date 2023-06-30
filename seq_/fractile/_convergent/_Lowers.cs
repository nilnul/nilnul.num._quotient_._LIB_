﻿using nilnul.obj.stream_._slider._skim_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace nilnul.num.quotient.seq_.fractile._convergent
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="quotient_.fractile._convergent._Divisors"/>
	public class _Divisors
		:
		nilnul.obj._seq_.GetEnumeratorA<BigInteger>
		,
		IEnumerable<BigInteger>

	{
		/// <summary>
		/// the previous adder; initialized as 0;
		/// </summary>
		BigInteger _prev = 1;



		BigInteger _current = 0;

		/// <summary>
		/// the current value of adders; 
		/// </summary>

		IEnumerable<BigInteger> _adders;    //started;


		internal _Divisors(IEnumerable<BigInteger> adders_)
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
				yield return _current = _prev + (_prev= _current) * item;		/// initially, this is 1.

			}

		}


	}
}