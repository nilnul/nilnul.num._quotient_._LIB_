using nilnul.num.integer._integer;
using nilnul.num.rational.float_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient_.radix_
{
	public  class Hex
		: Radix3
	{
		public Hex(integer_.radix_.Hex gits, Num_ofIn mantissa) : base(
			new integer_.Radix(
				new num_.Radix1(
					new num_.Plural(
						gits.abs.root
					)
					,
					new str_.List(
						gits.abs.digits
					)
				),
				gits.sign
			)
			,
			mantissa
		)
		{
		}
		public Hex(integer_.radix_.Hex dec, int length)
			:this(dec, Num_ofIn.Of(length) )
		{
		}
		public Hex(bool sign, nilnul.num_.radix_.Hex gits,  Num_ofIn mantissa) : this(
			new integer_.radix_.Hex(
				gits
				//new num_.Radix1(
				//	new num_.Plural( gits.basis)
				//	,
				//	new str_.List( gits.digits )
				//)
				,
				sign
			)

			, mantissa

		)
		{
		}

		public Hex()
			:this(
				 true,
				 new nilnul.num_.radix_.Hex( new nilnul.Num1[0])
				 ,
				  Num_ofIn.Of(0)
			)
		{

		}


		//static public string Regex_str = @"(?<int>[\d]*(\.(?<tail>[\d]*))?";
		static public Regex RegexWhole = new Regex(
			@"^
				(?<sign>[-]?)
				(?<nonneg>
					(?<int>([\d]|[A-F])*)
					(\.
						(?<tail>([\d]|[A-F])*)
					)?
				)
			$"
			,

			RegexOptions.IgnorePatternWhitespace
			);

		static public Hex Parse(string s)
		{
			var matched = RegexWhole.Match(s);
			if (matched.Success)
			{
				return new Hex(
					

					nilnul.num.integer_.radix_.Hex.Parse(
matched.Groups["sign"].Value+
						matched.Groups["int"].Value + matched.Groups["tail"].Value
					)

					,
					matched.Groups["tail"].Value.Length // or we can use the "indexOf"

				);

			}
			else
			{
				throw new ArgumentException("given string is of bad format.");
			}


		}


	}
}
