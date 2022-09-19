using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient
{
	/// <summary>
	/// an integerer, an invisible plus, and a proper fraction. The integer may be negative in, for example -1+½.
	/// Note intuitively  -1½ =-(1½)=-(1+½) for invisible plus sign is precedent; it can be constructed by a minus sign and a MixedFrac.
	/// </summary>
	///
	[Obsolete()]
	public class MixedFrac
	{

		private BigInteger _floor;

		public BigInteger floor
		{
			get { return _floor; }
			set { _floor = value; }
		}

		private be.Proper.En _proper;

		public be.Proper.En proper
		{
			get { return _proper; }
			set { _proper = value; }
		}

		public MixedFrac(
			BigInteger floor,
			be.Proper.En proper
			
			)
		{
			_floor = floor;
			_proper = proper;
		}

		public MixedFrac(Tuple<BigInteger,be.Proper.En> tuple )
			:this(tuple.Item1, tuple.Item2)
		{

		}

		static public implicit operator MixedFrac(Q1 x)
		{
			var t = nilnul.num.integer.op.Divide._Eval_floor_divisorPositive__retTuple(x.numerator, x.denominator.val);

			return new MixedFrac(


				t.Item1,
				new be.Proper.En(t.Item2, x.denominator.val)
			);

		}






	}
}
