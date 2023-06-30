using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_.indicNonpos.phrase_
{

	/// <summary>
	/// no 0 is prepended if it's empty before dot;
	/// </summary>
	static public class _EmptibleX
	{
	
		static public string Phrase(
			radix_.IndicNonpos radix
		)
		{
			return _Phrase_0indicNonpos(radix);

		}


		static public string _Phrase_1valid(
			radix_.IndicNonpos radix
			,
			char[] _chars
		)
		{
			return _Phrase_0indicNonpos_1valid(radix,_chars);

		}
	
		static public string _Phrase_0indicNonpos(
			RadixI radix
		)
		{
			
			return _PhraseWithDot_0indicNonpos(radix).TrimEnd('.');
		}

		static public string _Phrase_0indicNonpos_1valid(
			RadixI radix
			,
			char[] _chars
		)
		{
			
			return _PhraseWithDot_0indicNonpos_1valid(radix,_chars).TrimEnd('.');
		}

		static public string PhraseWithDot(
			radix_.IndicNonpos radix
		)
		{
			return _PhraseWithDot_0indicNonpos(radix);
		}
		static public string _PhraseWithDot_0indicNonpos(
			RadixI radix
		)
		{
			var t = nilnul.num.integer_.radix.phrase_._EmptibleX.Phrase(
				radix.signific
			);
			return t.Insert(
				-(int)radix.indic,"."
			);
		}

		static public string _PhraseWithDot_1valid(
			radix_.IndicNonpos radix
			,
			char[] _chars
		)
		{
			return _PhraseWithDot_0indicNonpos_1valid(radix,_chars);
		}
		static public string _PhraseWithDot_0indicNonpos_1valid(
			RadixI radix
			,
			char[] _chars
		)
		{
			var t = nilnul.num.integer_.radix.phrase_._EmptibleX._Phrase_1valid(
				radix.signific, _chars
			);
			return t.Insert(
				-(int)radix.indic,"."
			);
		}




	}
}
