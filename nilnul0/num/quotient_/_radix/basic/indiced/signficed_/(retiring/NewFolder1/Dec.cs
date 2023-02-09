using nilnul.num.integer._integer;
using nilnul.num.rational.float_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient._radix
{
	public partial class Dec
		:Radix
	{

		public Dec(BigInteger significand, BigInteger index)
			:base(10,significand,index)
		{

		}

		static public Dec FroQ(Q rational,BigInteger digits) {
			var based = FroQ(10, rational, digits);

			return new Dec(based.significand, based.index);

		}

		static public Q ToQ(
			Dec dec
			
			
		) {

			return Radix.ToQ(dec);

		}
		static public Q operator /(Dec x, int y) {
			return x.toQ() /y;
		}

		static public bool operator ==(Dec x, int y) {
			return x.toQ() == y;
		}
		static public bool operator !=(Dec x, int y) {
			return x.toQ() != y;
		}
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
				(?<int>[+-]?[\d]*)
				(\.
					(?<tail>[\d]*)
				)?
			$"
			,
			
			RegexOptions.IgnorePatternWhitespace
			);

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
