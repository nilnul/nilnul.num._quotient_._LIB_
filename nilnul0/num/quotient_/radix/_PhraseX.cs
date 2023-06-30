namespace nilnul.num.quotient_.radix
{
	static public class _PhraseX {
		static public string Phrase(
			this Radix8unsignedI byNeg
		) {
			return $"{(byNeg.negated?"-":"")}{byNeg.unsigned}";
		}
	}


}
