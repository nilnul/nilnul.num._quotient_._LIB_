using nilnul.num.integer_;
using nilnul.num.quotient_.denomNonnil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil_
{
	public class Nonneg
		: nilnul.num.quotient_.denomNonnil.vow.ee_.VowDefault<denomNonnil.be_.nonneg.Vow>
		,
		DenomNonnilI
	{
		public Nonneg(in DenomNonnilI val) : base(in val)
		{
		}

		public Nonneg(DenomNonnilI val) : base(val)
		{
		}

		public Nonneg(int x):this(new DenomNonnil(x) )
		{

		}

		public ref Nonnil_vowlessRef denominator => ref eeByRef.denominator;

		public ref BigInteger numerator =>ref eeByRef.numerator;

		static public DenomNonnil operator +(Nonneg a, DenomNonnilI b) {
			return a.eeByRef.ToImpl() + b;
		}
	}
}
