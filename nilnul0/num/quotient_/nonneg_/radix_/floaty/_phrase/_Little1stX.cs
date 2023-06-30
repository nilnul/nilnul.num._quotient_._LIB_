using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty._phrase
{

	/// <summary>
	/// most significant bit last;
	/// no 0 is prepended if it's empty before dot;
	/// </summary>
	static public class _Little1stX
	{
	
		static public string _Phrase_1valid(
			nonneg_.radix_.Floaty radix
			,
			char[] _chars
		)
		{
			return _Phrase_0floaty_1valid(radix,_chars);
		}
	
	
		static public string Phrase(
			nonneg_. radix_.FloatyI radix
		)
		{
			return _Phrase_0floaty(radix);
		}

		static public string _Phrase_0floaty(
			RadixI radix
		)
		{
			var t = nilnul.num_.radix._phrase._Insignificant1stX.Phrase(
				radix.precision
			);
			return t.Insert(
				-(int)radix.indic,"."
			);
		}

		static public string _Phrase_1valid(
			nonneg_.radix_.FloatyI radix
			,
			char[] _chars
		)
		{
			return _Phrase_0floaty_1valid(radix,_chars);
		}
		static public string _Phrase_0floaty_1valid(
			RadixI radix
			,
			char[] _chars
		)
		{
			var t = nilnul.num_.radix._phrase._Insignificant1stX._Phrase_1valid(
				radix.precision, _chars
			);
			return t.Insert(
				-(int)radix.indic,"."
			);
		}





	}
}
