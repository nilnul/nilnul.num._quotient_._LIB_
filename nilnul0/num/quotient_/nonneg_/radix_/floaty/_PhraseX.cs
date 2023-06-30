using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty
{

	/// <summary>
	/// </summary>
	static public class _PhraseX
	{
		//public const char Point = _phrase._RadixPointX.CHAR;
	
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
			var t = string.Join("",
				_phrase._Little1stX._Phrase_0floaty(radix).Reverse()
			);

			return _Heavy1st2Dwelt(t);
		}

		static public string _Phrase_1valid(
			nonneg_.radix_.FloatyI radix
			,
			char[] _chars
		)
		{
			return _Phrase_0floaty_1valid(radix,_chars);
		}
		static public string _Heavy1st2Dwelt(string t)
		{
			t = t.TrimEnd(_phrase._RadixPointX.CHAR);
			/// how aoubt .3?
			/// let's allow . at the beginning;
			if (t == string.Empty)
			{
				return "0";
			}
			return t;
		}

		static public string _Phrase_0floaty_1valid(
			RadixI radix
			,
			char[] _chars
		)
		{
			var t = string.Join("",
				_phrase._Little1stX._Phrase_0floaty_1valid(radix,_chars).Reverse()
			);
	
			
			return  _Heavy1st2Dwelt(t);
		}




	}
}
