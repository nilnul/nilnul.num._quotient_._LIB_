using nilnul.num.integer.str_.started_.nonhead8positive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Positive1 = nilnul._num.bigint.be.Positive1.Asserted;

namespace nilnul.num.quotient_
{

	/// <summary>
	/// this allows the proper =1. This is useful in a stream of continued frac to express an irrational number.
	/// </summary>
	[Obsolete(nameof(Fractile))]
	public class RecurFrac
	{
		private BigInteger _floor;

		public BigInteger floor
		{
			get { return _floor; }
			set { _floor = value; }
		}

		private _recurFrac.Denoms _proper;

		public _recurFrac.Denoms proper
		{
			get { return _proper; }
			set { _proper = value; }
		}
		public RecurFrac( BigInteger floor, _recurFrac.Denoms proper)
		{
			_floor = floor;
			_proper = proper;
		}


		public RecurFrac( BigInteger floor, IEnumerable<nilnul.num_.Positive1> denominators)
			:this(
				 floor

				 ,
				 new _recurFrac.Denoms(denominators)
				 )
		{
		}

		public RecurFrac(int v):this(v,new _recurFrac.Denoms())
		{
		}

		public RecurFrac(BigInteger floor, List<num_.Positive1> list):this(floor, (IEnumerable<num_.Positive1>)list )
		{
		}

		

		public override string ToString()
		{
			return $"[{_floor};{_proper.ToString()}]";
		}

		static public implicit operator nilnul.num.Quotient1(nilnul.num.quotient_.RecurFrac src)
		{
			return src.floor + _recurFrac.denoms.to_._ToQuotientX.ToQuotient(src.proper);
		}

		[Obsolete(nameof(integer.str_.started_.nonhead8positive.fractile.of_.coerce_._OfQuotientX.ToRecurFrac))]

		static public implicit operator RecurFrac(nilnul.num.Quotient1 src)
		{
			var tailed = nilnul.num.quotient_.FlooredX.ToFloored(src);
			return new RecurFrac(
				tailed.floor
				,
				_recurFrac.denoms.fro_._FroNonnegLeOneX._Positives_ofNonnegLeOne(tailed.proper)
			);
			;
		}

	}
}
