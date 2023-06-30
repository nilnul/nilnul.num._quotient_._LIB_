using nilnul.num.integer._integer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using R3 = nilnul.num.quotient.Radix;

namespace nilnul.num.quotient_.radix_
{

	static public class DecX
	{

		static public Regex Regex_ = new Regex(
			@"
				(?<int>[\d]*)
				(\.
					(?<tail>[\d]*)
				)?
			"
			,

			RegexOptions.IgnorePatternWhitespace
		);
		//static public string Regex_str = @"(?<int>[\d]*(\.(?<tail>[\d]*))?";
		static public Regex RegexWhole = new Regex(
			@"^
				(?<int>[-]?[\d]*) #+ is regarded as unary of
				(\.
					(?<tail>[\d]*)
				)?
			$"
			,

			RegexOptions.IgnorePatternWhitespace
		);


		static public R3 ToDec(
			this

			nilnul.num._quotient.fraction.op.Simplify.Ed1 q
			, uint x

		)
		{

			return R3._FroQ(10, q, x);

		}
		static public R3 _ToDec(
			this

			nilnul.num._quotient.fraction.op.Simplify.Ed1 q
			, int _precision_natural

		)
		{

			return ToDec(q, (uint)_precision_natural);

		}


		static public _radix.basic.indiced.significed_.Dec Parse2significed(string s)
		{
			var matched = RegexWhole.Match(s);
			if (matched.Success)
			{
				return new _radix.basic.indiced.significed_.Dec(
					BigIntX.Parse(
						matched.Groups["int"].Value + matched.Groups["tail"].Value
					)

					,
					-matched.Groups["tail"].Value.Length

				);

			}
			else
			{
				throw new ArgumentException("given string is of bad format.");
			}
		}

		[Obsolete(nameof(Parse2significed))]
		static public Dec Parse(string s)
		{
			var matched = RegexWhole.Match(s);
			if (matched.Success)
			{
				return new Dec(
					BigIntX.Parse(
						matched.Groups["int"].Value + matched.Groups["tail"].Value
					)

					,
					-matched.Groups["tail"].Value.Length

				);

			}
			else
			{
				throw new ArgumentException("given string is of bad format.");
			}
		}



	}
}
