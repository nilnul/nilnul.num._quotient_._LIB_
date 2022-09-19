using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;

namespace nilnul.num._quotient
{
	/// <summary>
	/// guratee that denominator is positive.
	/// </summary>
	/// 
	[Obsolete()]
	public partial class Fraction
	{
		#region fields

			public BigInteger numerator;
			public num.natural.__bigint.be.Positive.Asserted _denominator;

		#endregion



		public num.natural.__bigint.be.Positive.Asserted denominator
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

		public int sign {
			get { return numerator.Sign; } }
		public Fraction()
			:this(0)
		{

		}

		public Fraction(BigInteger numerator)
			: this(numerator, 1)
		{ }

		public Fraction(
			BigInteger num
			,
			num.natural.__bigint.be.Positive.Asserted denominator
		)
		{
			this.numerator = num;
			this.denominator = denominator;


		}


		public Fraction(BigInteger numerator, BigInteger denominator)
			
		
		{

			if (denominator<0)
			{
				this.numerator = -numerator;
				this.denominator = new natural.__bigint.be.Positive.Asserted(-denominator);
				return;

			}
				this.numerator = numerator;
				this.denominator = new natural.__bigint.be.Positive.Asserted(denominator);



		}

		public Fraction inverse()
		{
			return Inverse(this);
		}



		public override string ToString()
		{
			return numerator.ToString() + "/" + denominator.ToString();
		}



		public void simplify()
		{
			var gcd = nilnul.num.i.op.Gcd.Eval(numerator, denominator);

			numerator = nilnul.num.i.op.Divide.Eval(  numerator, gcd);


			this.denominator =nilnul.num.i.op.Divide.Eval(  denominator, gcd) ;


		}

		static public Fraction Simplify(Fraction f)
		{
			var gcd = nilnul.num.i.op.Gcd.Eval(f.numerator, f.denominator);
			return new Fraction(f.numerator / gcd, f.denominator / gcd);

			


		}

		static public Fraction Divide(BigInteger x, BigInteger y) {

			if (y<0)
			{
				return new Fraction(-x, -y);
				
			}
			return new Fraction(x, y);
		
		}

		static public Fraction Multi(Fraction a,Fraction b) {
			return new Fraction( a.numerator*b.numerator, a.denominator*b.denominator  );
		}
		static public Fraction Divide(Fraction a,Fraction b) {
			return Multi(a, Inverse(b));
		}

		static public Fraction operator *(Fraction a,Fraction b) {
			return new Fraction( a.numerator*b.numerator, a.denominator*b.denominator  );
		}
	static public Fraction Divide(num.natural.__bigint.be.Positive.Asserted x, BigInteger y) {

			if (y<0)
			{
				return new Fraction(-x.val, -y);
				
			}
			return new Fraction(x.val, y);
		
		}	

		static public Fraction Inverse(Fraction a)
		{

			return Divide(a.denominator,a.numerator);


		}

	

		static public Fraction ToFraction2(long a)
		{
			return new Fraction(a, 1);
		}

		



	
		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Fraction Parse(string s)
		{

			///first find the /
			///
			/// 
			string[] terms = s.Split(rational.op.Divide.Sign);
			if (terms.Length != 2)
			{
				throw new Exception(string.Format("There are more than two terms sperated by {0}.", rational.op.Divide.Sign));

			}

			return new Fraction(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));


			/// 
			///first is it an integer?
			///




		}

	}
}
