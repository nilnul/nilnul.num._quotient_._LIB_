using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient_
{
	/// <summary>
	/// an integerer, an invisible plus, and a proper fraction. The integer may be negative in, for example -1+½.
	/// Note intuitively  -1½ =-(1½)=-(1+½) for invisible plus sign is precedent; it can be constructed by a minus sign and a MixedFrac.
	/// </summary>
	public class Floored
	{

		private BigInteger _floor;

		public BigInteger floor
		{
			get { return _floor; }
			set { _floor = value; }
		}

		private quotient.be_.proper.vow.En _proper;

		public quotient.be_.proper.vow.En proper
		{
			get { return _proper; }
			set { _proper = value; }
		}

		public Floored(
			BigInteger floor,
			quotient.be_.proper.vow.En proper
			
			)
		{
			_floor = floor;
			_proper = proper;
		}

		public Floored(Tuple<BigInteger,quotient.be_.proper.vow.En> tuple )
			:this(tuple.Item1, tuple.Item2)
		{

		}

		static public implicit operator Floored(Q1 x)
		{
			var t = nilnul.num.integer.op.Divide._Eval_floor_divisorPositive__retTuple(x.numerator, x.denominator.val);

			return new Floored(


				t.Item1,
				new quotient.be_.proper.vow.En(t.Item2, x.denominator.val)
			);

		}

		static public Floored Ov(nilnul.num.QuotientI1 x)
		{
			var t = nilnul.num.integer.op.Divide._Eval_floor_divisorPositive__retTuple(x.numerator, x.denominator1);

			return new Floored(


				t.Item1,
				new quotient.be_.proper.vow.En(t.Item2, x.denominator1)
			);

		}


		public BigInteger round()
		{
			return _floor + _proper.round();
		}

		public BigInteger ceil()
		{
			return _floor + _proper.ceil();
		}



	}
}
