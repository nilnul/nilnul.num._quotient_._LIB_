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
	public  class Dec2
		: Radix3
	{
		public Dec2(integer_.radix_.Dec gits, Num_ofIn mantissa) : base(
			new integer_.Radix(
				new num_.Radix1(
					new num_.Plural(
						gits.abs.basis
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
		public Dec2(integer_.radix_.Dec dec, int length)
			:this(dec, Num_ofIn.Of(length) )
		{
		}
		public Dec2(bool sign, nilnul.num_.radix_.Dec1 gits,  Num_ofIn mantissa) : this(
			new integer_.radix_.Dec(
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

		public Dec2()
			:this(
				 true,
				 new nilnul.num_.radix_.Dec1( new nilnul.Num1[0])
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
					(?<int>[\d]*)
					(\.
						(?<tail>[\d]*)
					)?
				)
			$"
			,

			RegexOptions.IgnorePatternWhitespace
			);

		static public Dec2 Parse(string s)
		{
			var matched = RegexWhole.Match(s);
			if (matched.Success)
			{
				return new Dec2(
					

					nilnul.num.integer_.radix_.Dec.Parse(
matched.Groups["sign"].Value+
						matched.Groups["int"].Value + matched.Groups["tail"].Value
					)

					,
					matched.Groups["tail"].Value.Length

				);

			}
			else
			{
				throw new ArgumentException("given string is of bad format.");
			}


		}


	}
}
