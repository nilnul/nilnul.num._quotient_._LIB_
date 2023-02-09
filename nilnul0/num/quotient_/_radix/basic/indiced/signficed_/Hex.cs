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

namespace nilnul.num.quotient_._radix.basic.indiced.significed_
{
	//	[Obsolete(nameof(Bin_padded))]
	public partial class Hex
		:Radix1
	{

		public Hex(BigInteger significand, BigInteger index)
			:base(16,significand,index)
		{

		}



		static public Hex FroQuotient(Q1 rational,BigInteger digits) {
			var based = Radix1._FroQuotient(16, rational, digits);

			return new Hex(based.significand, based.index);

		}

		static public Hex OvQuotient(Q1 rational,BigInteger digits) {
			var based = Radix1._OvQuotient(16, rational, digits);

			return new Hex(based.significand, based.index);

		}
		static public Hex OvQuotient_throwIfResidue(Q1 rational,BigInteger digits) {
			var based = Radix1._OvQuotient_throwIfResidue(16, rational, digits);

			return new Hex(based.significand, based.index);

		}



		static public Q1 ToQ(
			Hex dec
			
			
		) {

			return Radix1.ToQ(dec);

		}
		static public Q1 operator /(Hex x, int y) {
			return x.toQ() /y;
		}

		static public Hex operator *(Hex x, int y) {
			return new Hex(
				 x.significand*y, x.exponent
				); ;
		}
	
		static public Hex operator *( int y,Hex x) {
			return new Hex(
				 x.significand*y, x.exponent
				); ;
		}
	


		static public bool operator ==(Hex x, int y) {
			return x.toQ() == y;
		}
		static public bool operator !=(Hex x, int y) {
			return x.toQ() != y;
		}

		static public implicit operator Q1(Hex x) {
			return x.toQ();
		}
		static public Regex Regex_ = new Regex(
			@"
				(?<int>([\d]|[A-F])*)
				(\.
					(?<tail>([\d]|[A-F])*)
				)?
			"
			,
			
			RegexOptions.IgnorePatternWhitespace
			);
		//static public string Regex_str = @"(?<int>[\d]*(\.(?<tail>[\d]*))?";
		static public Regex RegexWhole = new Regex(
			@"^
				(?<int>[+-]?([\d]|[A-F])*)
				(\.
					(?<tail>([\d]|[A-F])*)
				)?
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
