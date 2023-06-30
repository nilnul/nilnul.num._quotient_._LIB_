using nilnul.num.integer._integer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using R3 = nilnul.num.quotient.Radix;

namespace nilnul.num.quotient_.radix_.floaty_.dec
{

	static public class _ParseX
	{

		//static public string Regex_str = @"(?<int>[\d]*(\.(?<tail>[\d]*))?";
		static public Regex RegexWhole = new Regex(
			@"^
				(?<neg>[-])? #+ is regarded as unary of
				(?<int>[\d]*) 
				(\.
					(?<tail>[\d]*)
				)?
			$"
			,

			RegexOptions.IgnorePatternWhitespace
		);


		static public Regex Regex_ = new Regex(
			@"
				(?<neg>[-])? #+ is regarded as unary of
				(?<int>[\d]*) 
				(\.
					(?<tail>[\d]*)
				)?
			"
			,

			RegexOptions.IgnorePatternWhitespace
		);



		static public Floaty Parse(string s)
		{

			var matched = RegexWhole.Match(s);
			if (matched.Success)
			{
				var mantissaGrp = matched.Groups["tail"];

				BigInteger mantissaLen = 0;

				if (mantissaGrp.Success)
				{
					///there is a dot
					///
					mantissaLen = -mantissaGrp.Value.Length;

				}

				return new radix_.Floaty(
					new nonneg_.radix_.Floaty(
						num_.radix_.Dec1.Parse(
							$"{matched.Groups["int"].Value}{matched.Groups["tail"].Value}"
						)
						,

						mantissaLen
					)
					,
					matched.Groups["neg"].Success

				);

			}
			else
			{
				throw new ArgumentException("given string is of bad format.");
			}
		}





	}
}
