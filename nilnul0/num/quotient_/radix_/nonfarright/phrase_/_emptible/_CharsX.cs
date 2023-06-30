using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_.indicNonpos.phrase_._emptible
{

	/// <summary>
	/// </summary>
	static public class _CharsX
	{
		static public IEnumerable<char> __Chars_0indicNonpos_1valid(
			RadixI radix
			,
			char[] _chars
		)
		{


			if (!radix.signific.sign)
			{
				yield return '-';
			}
			var enumerator = radix.signific.abs.digits.Select(x => _chars[(int)(x.en)]).GetEnumerator();

			for (int i = 0; i < -radix.indic; i++)
			{
				enumerator.MoveNext();
				yield return enumerator.Current;

			}
			yield return '.';

			while (enumerator.MoveNext())
			{
				yield return enumerator.Current;
			}
		}













	}
}
