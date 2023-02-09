using nilnul.num.integer_;
using System.Numerics;

namespace nilnul.num.quotient_
{
	public interface DenomNonnilI
		:
		IDenomNonnil
	{
		ref Nonnil_vowlessRef denominator { get; }
		ref BigInteger numerator { get; }
	}
}