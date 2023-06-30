using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Positive1 = nilnul._num.bigint.be.Positive1.Asserted;

namespace nilnul.num.integer.str_.started_.nonhead8positive
{

	/// <summary>
	/// this allows the proper =1. This is useful in a stream of continued frac to express an irrational number.
	/// </summary>

	public class Fractile : FractileI
	{
		private BigInteger _ground;

		public BigInteger ground
		{
			get { return _ground; }
			set { _ground = value; }
		}

		private _fractile.Denoms _probal;

		public _fractile.Denoms probal
		{
			get { return _probal; }
			set { _probal = value; }
		}
		public Fractile(BigInteger floor, _fractile.Denoms proper)
		{
			_ground = floor;
			_probal = proper;
		}


		public Fractile(BigInteger floor, IEnumerable<nilnul.num_.Positive1> denominators)
			: this(
				 floor

				 ,
				 new _fractile.Denoms(denominators)
				 )
		{
		}

		public Fractile(int v) : this(v, new _fractile.Denoms())
		{
		}

		public Fractile(BigInteger floor, List<num_.Positive1> list) : this(floor, (IEnumerable<num_.Positive1>)list)
		{
		}

		public Fractile(BigInteger item1, IEnumerable<BigInteger> enumerable) : this(
			item1, new _fractile.Denoms(enumerable)
		)
		{
		}

		public override string ToString()
		{
			return $"[{_ground};{_probal.ToString()}]";
		}

		static public explicit operator nilnul.num.Quotient1(nilnul.num.integer.str_.started_.nonhead8positive.Fractile src)
		{
			return src.ground + _fractile.denoms.to_.cast_._ToQuotientX.ToQuotient(src.probal);
		}

		[Obsolete(nameof(fractile.of_.coerce_._OfQuotientX.ToRecurFrac))]

		static public explicit operator Fractile(nilnul.num.Quotient1 src)
		{
			var tailed = nilnul.num.quotient_.FlooredX.ToFloored(src);
			return new Fractile(
				tailed.floor
				,
				_fractile.denoms.of_.quotient_._OfProbalX._Positives_0prob(tailed.proper)
			);
			;
		}

	}
}
