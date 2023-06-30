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
	public  class Bin
		: quotient_.Radix3
	{
		public Bin(integer_.radix_.Bin  gits, Num_ofIn mantissa) : base(
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
		public Bin(integer_.radix_.Bin dec, int length)
			:this(dec, Num_ofIn.Of(length) )
		{
		}
		public Bin(bool sign, nilnul.num_.radix_.Binary1 gits,  Num_ofIn mantissa) : this(
			new integer_.radix_.Bin(
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
		public Bin()
			:this(
				
				 new nilnul.num.integer_.radix_.Bin(new num_.radix_.Binary1() )
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
					(?<int>[01]*)
					(\.
						(?<tail>[01]*)
					)?
				)
			$"
			,

			RegexOptions.IgnorePatternWhitespace
			);

		static public Bin Parse(string s)
		{
			var matched = RegexWhole.Match(s);
			if (matched.Success)
			{
				return new Bin(
					nilnul.num.integer_.radix_.Bin.Parse(
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

		static public _radix.basic.indiced.significed_.Bin Parse2significed(string s)
		{
			var matched = RegexWhole.Match(s);
			if (matched.Success)
			{
				return new nilnul.num.quotient_._radix.basic.indiced.significed_.Bin(
					BigInteger.Parse(
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