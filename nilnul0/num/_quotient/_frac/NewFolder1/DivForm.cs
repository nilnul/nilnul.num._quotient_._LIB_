using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._quotient
{
	/// <summary>
	/// the underneath cannot be zero.
	/// </summary>
	///
	[Obsolete(nameof(Dividing))]
	public class DivForm
	{
		private BigInteger _numerator;

		public BigInteger numerator
		{
			get { return _numerator; }
			set { _numerator = value; }
		}

		private num.integer.be_.NonZero.En _denominator;

		public num.integer.be_.NonZero.En denominator
		{
			get { return _denominator; }
			set { _denominator = value; }
		}

		public DivForm(BigInteger numerator, num.integer.be_.NonZero.En denominator)
		{
			_numerator = numerator;
			_denominator = denominator;

		}
		public void simplify() {
			var gcd = nilnul.num.integer.duo.op.Gcd.Eval_retN1(numerator, denominator);
			_numerator /= gcd;
			_denominator = new integer.be_.NonZero.En( _denominator/  gcd.val);

		}

		public override string ToString()
		{
			return $"{_numerator}/{_denominator}";
		}



	}
}
