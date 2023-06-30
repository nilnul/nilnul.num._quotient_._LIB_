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
	[Obsolete(nameof(Dec2))]
	public partial class Dec1
		:Radix1
	{

		public Dec1(BigInteger significand, BigInteger index)
			:base(10,significand,index)
		{

		}

		[Obsolete(nameof(FroQuotient))]
		static public Dec1 FroQ(Q rational,BigInteger digits) {
			var based = FroQ(10, rational, digits);

			return new Dec1(based.significand, based.index);

		}

		static public Dec1 FroQuotient(Q1 rational,BigInteger digits) {
			var based = Radix1._FroQuotient(10, rational, digits);

			return new Dec1(based.significand, based.index);

		}

		static public Dec1 OvQuotient(Q1 rational,BigInteger digits) {
			var based = Radix1._OvQuotient(10, rational, digits);

			return new Dec1(based.significand, based.index);

		}
		static public Dec1 OvQuotient_throwIfResidue(Q1 rational,BigInteger digits) {
			var based = Radix1._OvQuotient_throwIfResidue(10, rational, digits);

			return new Dec1(based.significand, based.index);

		}



		static public Q1 ToQ(
			Dec1 dec
			
			
		) {

			return Radix1.ToQ(dec);

		}
		static public Q1 operator /(Dec1 x, int y) {
			return x.toQ() /y;
		}

		static public Dec1 operator *(Dec1 x, int y) {
			return new Dec1(
				 x.significand*y, x.exponent
				); ;
		}
	
		static public Dec1 operator *( int y,Dec1 x) {
			return new Dec1(
				 x.significand*y, x.exponent
				); ;
		}
	


		static public bool operator ==(Dec1 x, int y) {
			return x.toQ() == y;
		}
		static public bool operator !=(Dec1 x, int y) {
			return x.toQ() != y;
		}

		static public implicit operator Q1(Dec1 x) {
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

		static public Dec1 Parse(string s)
		{
			var matched = RegexWhole.Match(s);
			if (matched.Success)
			{
				return new Dec1(
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
