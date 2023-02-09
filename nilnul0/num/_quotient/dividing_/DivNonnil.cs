using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;
using nilnul._num.bigint.be;

namespace nilnul.num._quotient.dividing_
{
	/// <summary>
	/// guratee that denominator is not zero
	/// </summary>
	/// alias:
	///		divisorNonnil
	///		Frac
	///			the numerator and denominator must be integer, not float, not mantissa
	///			the denominator must be nonnil.
	///

	[Obsolete(nameof(num.quotient_.DenomNonnil))]
	public class Frac
	{
		/// <summary>
		/// note this is different from <see cref="nilnul.num._quotient.Dividing.DividerSign"/>
		/// </summary>
		public const char DividerSign = '/';

		#region fields
		public BigInteger numerator;


		/// <summary>
		/// </summary>
		/// making this a class, not an interface for performance.
		/// 
		public nilnul.num.integer_.Nonnil _denominator;
		#endregion

		public nilnul.num.integer_.Nonnil denominator
		{
			get
			{
				return _denominator;
			}
			set
			{
				_denominator = value;
			}
		}

		

		public Frac(
			BigInteger num
			,
			nilnul.num.integer_.Nonnil denominator
		)
		{
			this.numerator = num;
			this.denominator = denominator;
		}

		public Frac(
			BigInteger num
			,
			BigInteger denominator
		) : this(num, new integer_.Nonnil(denominator))
		{
		}
		public Frac(BigInteger numerator)
			: this(numerator, new integer_.Nonnil(1))
		{ }
		public Frac()
			: this(0)
		{
		}









		public override string ToString()
		{
			return numerator.ToString() + "/" + denominator.ToString();
		}




		static public Frac Simplify(Frac f)
		{
			var gcd = nilnul.num.i.op.Gcd.Eval(f.numerator, f.denominator);
			return new Frac(f.numerator / gcd, f.denominator / gcd);


		}



		static public Frac CreateQuarter()
		{
			return new Frac(1, 4);
		}




		public static Frac operator +(Frac x, Frac y)
		{
			return new Frac(
				x.numerator * y._denominator
				+
				y.numerator * x._denominator
				,
				x._denominator * y._denominator
			);
		}


		public static Frac operator -(Frac x)
		{
			return new Frac(
				-x.numerator
				,
				x._denominator
			);
		}
		public static Frac operator -(Frac x, Frac y)
		{
			return x + -y;
		}


		public static bool IsNil(Frac x)
		{
			return (x.numerator == 0);
		}

		public static bool operator ==(Frac x, Frac y)
		{
			return IsNil(x - y);
		}

		public static bool operator !=(Frac x, Frac y)
		{
			return !(x == y);
		}




		static public Frac Multi(Frac a, Frac b)
		{
			return new Frac(a.numerator * b.numerator, a.denominator * b.denominator);
		}
		static public Frac operator *(Frac a, Frac b)
		{
			return Multi(a,b);
		}

		static public Frac operator *(BigInteger a, Frac b)
		{
			return new Frac(a * b.numerator, b.denominator);
		}

		
		public static Frac Inverse(Frac x)
		{
			return new Frac(x._denominator, x.numerator);
		}
		

		static public Frac Divide(Frac a, Frac b)
		{
			return Multi(a, Inverse(b));
		}


			public static Frac operator /(Frac x, Frac y)
		{
			return x * Inverse(y);
		}

		static public implicit operator Dividing(Frac x) {
			return new Dividing(x.numerator,x._denominator);
		}


		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Frac Parse(string s)
		{

			///first find the /
			///
			/// 
			string[] terms = s.Split(Dividing.DividerSign);

			switch (terms.Length)
			{
				case 0:
					return new Frac();
				case 1:
					return new Frac(
						BigInteger.Parse(terms[0])
					);
				case 2:
					return new Frac(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));

				default:
					throw new Exception(
						string.Format("There are more than two terms sperated by {0}.", Dividing.DividerSign)
					);
					break;
			}

		}

		static public bool TryParse(string s, out Frac result)
		{

			try
			{
				result = Parse(s);
				return true;
			}
			catch (Exception)
			{
				result = default(Frac);
				return false;

			}

		}



	}
}
