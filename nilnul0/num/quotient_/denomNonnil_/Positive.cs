using nilnul.num.integer_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil_
{
	public class Positive
		: nilnul.num.quotient_.denomNonnil.vow.ee_.VowDefault<denomNonnil.be_.positive.Vow>
		,
		DenomNonnilI
	{
		public Positive(in DenomNonnilI val) : base(in val)
		{
		}

		public Positive(DenomNonnil val) : base(val)
		{
		}

		public ref Nonnil_vowlessRef denominator => ref eeByRef.denominator;

		public ref BigInteger numerator =>ref eeByRef.numerator;
	}
}
