using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Positive1 = nilnul._num.bigint.be.Positive1.Asserted;

namespace nilnul.num.quotient.continuedFrac_
{

	/// <summary>
	/// this allows the proper =1. This is useful in a stream of continued frac to express an irrational number.
	/// </summary>

		[Obsolete(nameof( num.quotient_.RecurFrac))]
	public class ForIrrational
	{
		private BigInteger _floor;

		public BigInteger floor
		{
			get { return _floor; }
			set { _floor = value; }
		}

		private _continuedFrac.simpleProper_.ForIrrational _proper;

		public _continuedFrac.simpleProper_.ForIrrational proper
		{
			get { return _proper; }
			set { _proper = value; }
		}
		public ForIrrational( BigInteger floor, _continuedFrac.simpleProper_.ForIrrational proper)
		{
			_floor = floor;
			_proper = proper;
		}


		public ForIrrational( BigInteger floor, IEnumerable<Positive1> denominators)
			:this(
				 floor

				 ,
				 new _continuedFrac.simpleProper_.ForIrrational(denominators)
				 )
		{

		}

		public ForIrrational(int v):this(v,new _continuedFrac.simpleProper_.ForIrrational())
		{
			
		}

		public override string ToString()
		{
			return $"[{_floor};{_proper.ToString()}]";
		}

	}
}
