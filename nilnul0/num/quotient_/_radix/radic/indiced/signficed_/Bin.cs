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
	public  class Bin
		: Radix1
	{

		public Bin(BigInteger significand, BigInteger index)
			: base(2, significand, index)
		{

		}



		static public Bin FroQuotient(Q1 rational, BigInteger digits)
		{
			var based = Radix1._FroQuotient(2, rational, digits);

			return new Bin(based.significand, based.index);

		}

		static public Bin OvQuotient(Q1 rational, BigInteger digits)
		{
			var based = Radix1._OvQuotient(2, rational, digits);

			return new Bin(based.significand, based.index);

		}
		static public Bin OvQuotient_throwIfResidue(Q1 rational, BigInteger digits)
		{
			var based = Radix1._OvQuotient_throwIfResidue(2, rational, digits);

			return new Bin(based.significand, based.index);

		}



		static public Q1 ToQ(
			Bin dec


		)
		{

			return Radix1.ToQ(dec);

		}
		static public Q1 operator /(Bin x, int y)
		{
			return x.toQ() / y;
		}

		static public Bin operator *(Bin x, int y)
		{
			return new Bin(
				 x.significand * y, x.exponent
				); ;
		}

		static public Bin operator *(int y, Bin x)
		{
			return new Bin(
				 x.significand * y, x.exponent
				); ;
		}



		static public bool operator ==(Bin x, int y)
		{
			return x.toQ() == y;
		}
		static public bool operator !=(Bin x, int y)
		{
			return x.toQ() != y;
		}

		static public implicit operator Q1(Bin x)
		{
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
				(?<int>[+-]?[01]*)
				(\.
					(?<tail>[01]*)
				)?
			$"
			,

			RegexOptions.IgnorePatternWhitespace
			);


		[Obsolete(nameof(quotient_.radix_.Bin.Parse2significed) + ", which uses floating point whileas this uses such as -3.2e-6;")]
		static public Bin Parse(string s)
		{
			var matched = RegexWhole.Match(s);
			if (matched.Success)
			{
				return new Bin(
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
