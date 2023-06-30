using nilnul.obj.stream_._slider._skim_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using nilnul.num.quotient_;

namespace nilnul.num.quotient.str_.started.scala_.fractile_._bySeq
{
	///<summary>
	/// 
	/// </summary>
	public class _Lowers
		:
		nilnul.obj._seq_.GetEnumeratorA<DenomNonnil>
		,
		IEnumerable<DenomNonnil>

	{
		/// <summary>
		/// the previous adder; initialized as 0;
		/// </summary>
		DenomNonnil _prev = 1;



		DenomNonnil _current = 0;

		/// <summary>
		/// the current value of adders; 
		/// </summary>

		IEnumerable<DenomNonnil> _adders;    //started;


		internal _Lowers(IEnumerable<DenomNonnil> adders_)
		{
			_adders = adders_;
		}



		/// <summary>
		/// we get an enumerator|slider from the underlying seq;
		/// </summary>
		/// <returns></returns>
		public override IEnumerator<DenomNonnil> GetEnumerator()
		{

			foreach (var item in _adders)
			{
				yield return _current = _prev + _current * item;		/// initially, this is 1.

				_prev = _current;
			}

		}


	}
}
