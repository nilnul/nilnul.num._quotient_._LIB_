using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;
using nilnul._num.bigint.be;

namespace nilnul.num._quotient._frac
{
	/// <summary>
	/// guratee that denominator is not zero
	/// </summary>
	///
	[Obsolete(nameof(dividing_.Frac))]
	public class DivNonnil
	{
		public const char DividerSign = '/';
		#region fields
		public BigInteger numerator;
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

		public int sign
		{
			get { return numerator.Sign; }
		}

		public DivNonnil(
			BigInteger num
			,
			nilnul.num.integer_.Nonnil denominator
		)
		{
			this.numerator = num;
			this.denominator = denominator;
		}

		public DivNonnil(
			BigInteger num
			,
			BigInteger denominator
		) : this(num, new integer_.Nonnil(denominator))
		{
		}
		public DivNonnil(BigInteger numerator)
			: this(numerator, new integer_.Nonnil(1))
		{ }
		public DivNonnil()
			: this(0)
		{
		}





		public DivNonnil inverse()
		{
			return Inverse(this);
		}





		public override string ToString()
		{
			return numerator.ToString() + "/" + denominator.ToString();
		}



		//public void simplify()
		//{
		//	var gcd = integer.duo._GcdX.Num(numerator, denominator);

		//	numerator = nilnul.num.integer.duo.op.Divide._Eval_floor_divisorPositive(numerator, gcd);


		//	this.denominator = new integer_.Nonnil(
		//		nilnul.num.integer.duo_.divisible.div_._TruncateX.Truncate(
		//			denominator
		//			,
		//			gcd
		//		)
		//	);


		//}

		static public DivNonnil Simplify(DivNonnil f)
		{
			var gcd = nilnul.num.i.op.Gcd.Eval(f.numerator, f.denominator);
			return new DivNonnil(f.numerator / gcd, f.denominator / gcd);




		}




		static public DivNonnil CreateQuarter()
		{
			return new DivNonnil(1, 4);
		}

		static public DivNonnil Divide(BigInteger x, BigInteger y)
		{

			if (y < 0)
			{
				return new DivNonnil(-x, -y);

			}
			return new DivNonnil(x, y);

		}

		static public DivNonnil Multi(DivNonnil a, DivNonnil b)
		{
			return new DivNonnil(a.numerator * b.numerator, a.denominator * b.denominator);
		}
		static public DivNonnil Divide(DivNonnil a, DivNonnil b)
		{
			return Multi(a, Inverse(b));
		}

		static public DivNonnil operator *(DivNonnil a, DivNonnil b)
		{
			return new DivNonnil(a.numerator * b.numerator, a.denominator * b.denominator);
		}

		static public DivNonnil operator *(BigInteger a, DivNonnil b)
		{
			return new DivNonnil(a * b.numerator, b.denominator);
		}

		static public DivNonnil Divide(num.natural.__bigint.be.Positive.Asserted x, BigInteger y)
		{

			if (y < 0)
			{
				return new DivNonnil(-x.val, -y);

			}
			return new DivNonnil(x.val, y);

		}

		static public DivNonnil Inverse(DivNonnil a)
		{

			return Divide(a.denominator, a.numerator);


		}



		static public DivNonnil ToFraction2(long a)
		{
			return new DivNonnil(a, 1);
		}






		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public DivNonnil Parse(string s)
		{

			///first find the /
			///
			/// 
			string[] terms = s.Split(DividerSign);

			switch (terms.Length)
			{
				case 0:
					return new DivNonnil();
				case 1:
					return new DivNonnil(
						BigInteger.Parse(terms[0])
					);
				case 2:
					return new DivNonnil(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));

				default:
					throw new Exception(
						string.Format("There are more than two terms sperated by {0}.", DividerSign)
					);
					break;
			}

		}

		static public bool TryParse(string s, out DivNonnil result)
		{

			try
			{
				result = Parse(s);
				return true;
			}
			catch (Exception)
			{
				result = default(DivNonnil);
				return false;

				throw;
			}

		}



	}
}
