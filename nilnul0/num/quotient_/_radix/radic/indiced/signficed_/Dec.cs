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
	public  class Dec
		:Radix1
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
			var based = Radix1._FroQuotient(10, rational, digits);

			return new Dec(based.significand, based.index);

		}

		static public Dec OvQuotient(Q1 rational,BigInteger digits) {
			var based = Radix1._OvQuotient(10, rational, digits);

			return new Dec(based.significand, based.index);

		}
		static public Dec OvQuotient_throwIfResidue(Q1 rational,BigInteger digits) {
			var based = Radix1._OvQuotient_throwIfResidue(10, rational, digits);

			return new Dec(based.significand, based.index);

		}



		static public Q1 ToQ(
			Dec dec
			
			
		) {

			return Radix1.ToQ(dec);

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
				(?<radix>	(?<int>[-]?[\d]*)  #plus would be taken as an of_.unary
					(\.
						(?<tail>[\d]*)
					)?
				)
				(
					[Ee]
					(?<indic>[-]?[\d]*)
				)?


			"
			,
			
			RegexOptions.IgnorePatternWhitespace
			);
		//static public string Regex_str = @"(?<int>[\d]*(\.(?<tail>[\d]*))?";
		static public Regex RegexWhole = new Regex(
			@"^
				(?<radix>	(?<int>[-]?[\d]*)  #plus would be taken as an of_.unary
					(\.
						(?<tail>[\d]*)
					)?
				)
				(
					[Ee]
					(?<indic>[-]?[\d]*)
				)?
				
			$"
			,
			
			RegexOptions.IgnorePatternWhitespace
			);

		/// <summary>
		/// cimal, eg: 123.23423
		/// not <see cref="quotient_.radix.IFloaty"/> like 3e1241
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		///
		[Obsolete(nameof(quotient_.radix_.DecX.Parse2significed) + ", which uses floating point whileas this uses such as -3.2e-6;")]
		static public Dec Parse(string s)
		{
			var matched = RegexWhole.Match(s);
			if (matched.Success)
			{
				var d = quotient_.radix_.DecX.Parse2significed(matched.Groups["radix"].Value);
				var i = BigIntX.Parse(
						matched.Groups["indic"].Value
					);
				return new Dec(
					d.significand

					,

					d.indicand+ i
					
				);

			}
			else
			{
				throw new ArgumentException("given string is of bad format.");
			}


		}
					
		
	}
}
