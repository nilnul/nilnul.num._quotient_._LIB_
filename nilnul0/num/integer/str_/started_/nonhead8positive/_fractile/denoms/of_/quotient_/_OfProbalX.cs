using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Q1 = nilnul.num.Quotient1;
using System.Numerics;
using nilnul.num.quotient_;

namespace nilnul.num.integer.str_.started_.nonhead8positive._fractile.denoms.of_.quotient_
{
	
	static public class _OfProbalX
	{

		static public List<BigInteger> _Integers_0prob(
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

		static public List<nilnul.num_.Positive1> _Positives_0prob(
			Q1 prob
		)
		{
			var denominants = new List<nilnul.num_.Positive1>();
			while (prob != 0)
			{
				prob = 1 / prob;
				var intProper = prob.ToFloored();
				denominants.Add( new num_.Positive1(  intProper.floor) );
				prob = intProper.proper;
			}
			return denominants;
		}
	}
}
