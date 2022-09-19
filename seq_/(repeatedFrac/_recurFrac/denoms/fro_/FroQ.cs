using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Q1 = nilnul.num.Quotient1;
using System.Numerics;

namespace nilnul.num.quotient_._recurFrac.denoms.fro_
{
	
	static public class _FroNonnegLeOneX
	{

		static public List<BigInteger> _Integers_ofNonnegLeOne(
			Q1 _nonnegLeOne
		)
		{
			var denominants = new List<BigInteger>();
			while (_nonnegLeOne != 0)
			{
				_nonnegLeOne = 1 / _nonnegLeOne;
				var intProper = _nonnegLeOne.ToFloored();
				denominants.Add(intProper.floor);
				_nonnegLeOne = intProper.proper;
			}
			return denominants;
		}

		static public List<nilnul.num_.Positive1> _Positives_ofNonnegLeOne(
			Q1 r__0_til_1
		)
		{
			var denominants = new List<nilnul.num_.Positive1>();
			while (r__0_til_1 != 0)
			{
				r__0_til_1 = 1 / r__0_til_1;
				var intProper = r__0_til_1.ToFloored();
				denominants.Add( new num_.Positive1(  intProper.floor) );
				r__0_til_1 = intProper.proper;
			}
			return denominants;
		}
	}
}
