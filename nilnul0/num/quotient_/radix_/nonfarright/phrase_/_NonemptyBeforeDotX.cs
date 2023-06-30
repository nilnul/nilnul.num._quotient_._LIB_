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

	static public class _NonemptyBeforeDotX

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

		public static string PhraseWithDot(IndicNonpos indicNonpos)
		{
			return _PhraseWithDot_0indicNonpos(indicNonpos);
		}

		static public string _PhraseWithDot_0indicNonpos(
			RadixI radix
		)
		{
			var t = nilnul.num.integer_.radix.phrase_._NoEmptyX.Phrase(
				radix.signific
			);
			t=t.Insert(
				-(int)radix.indic,"."
			);
			return t;

		}
		public static string _PhraseWithDot_1valid(IndicNonpos indicNonpos, char[] chars)
		{
			return _PhraseWithDot_0indicNonpos_1valid(indicNonpos, chars);
		}

		static public string _PhraseWithDot_0indicNonpos_1valid(
			RadixI radix
			,
			char[] _chars
		)
		{
			var t = nilnul.num.integer_.radix.phrase_._NoEmptyX._Phrase_1valid(
				radix.signific, _chars
			);
			t=t.Insert(
				-(int)radix.indic,"."
			);
			return t;

		}

	}
}
