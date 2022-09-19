using nilnul.num.integer._integer;
using nilnul.num.rational.float_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.radix
{
	[Obsolete()]
	public partial class Dec
		:Radix
	{

		public Dec(BigInteger significand, BigInteger index)
			:base(10,significand,index)
		{

		}

		[Obsolete(nameof(FroQuotient))]
		static public Dec FroQ(Q rational,BigInteger digits) {
			var based = FroQ(10, rational, digits);

			return new Dec(based.significand, based.index);

		}

		static public Dec FroQuotient(Q1 rational,BigInteger digits) {
			var based = Radix._FroQuotient(10, rational, digits);

			return new Dec(based.significand, based.index);

		}


		static public Q1 ToQ(
			Dec dec
			
			
		) {

			return Radix.ToQ(dec);

		}
		static public Q1 operator /(Dec x, int y) {
			return x.toQ() /y;
		}

		static public Dec operator *(Dec x, int y) {
			return new Dec(
				 x.significand*y, x.exponent
				); ;
		}
	
		static public Dec operator *( int y,Dec x) {
			return new Dec(
				 x.significand*y, x.exponent
				); ;
		}
	


		static public bool operator ==(Dec x, int y) {
			return x.toQ() == y;
		}
		static public bool operator !=(Dec x, int y) {
			return x.toQ() != y;
		}

		static public implicit operator Q1(Dec x) {
			return x.toQ();
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
