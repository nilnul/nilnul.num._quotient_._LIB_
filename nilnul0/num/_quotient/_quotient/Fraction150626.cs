using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;

namespace nilnul.num.quotient
{
	/// <summary>
	/// guratee that denominator is positive.
	/// </summary>
	public partial class Fraction150626
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
		public Fraction150626()
			:this(0)
		{

		}

		public Fraction150626(BigInteger numerator)
			: this(numerator, 1)
		{ }

		public Fraction150626(
			BigInteger num
			,
			num.natural.__bigint.be.Positive.Asserted denominator
		)
		{
			this.numerator = num;
			this.denominator = denominator;


		}


		public Fraction150626(BigInteger numerator, BigInteger denominator)
			
		
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

		public Fraction150626 inverse()
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

		static public Fraction150626 Simplify(Fraction150626 f)
		{
			var gcd = nilnul.num.i.op.Gcd.Eval(f.numerator, f.denominator);
			return new Fraction150626(f.numerator / gcd, f.denominator / gcd);

			


		}

		static public Fraction150626 Divide(BigInteger x, BigInteger y) {

			if (y<0)
			{
				return new Fraction150626(-x, -y);
				
			}
			return new Fraction150626(x, y);
		
		}

		static public Fraction150626 Multi(Fraction150626 a,Fraction150626 b) {
			return new Fraction150626( a.numerator*b.numerator, a.denominator*b.denominator  );
		}
		static public Fraction150626 Divide(Fraction150626 a,Fraction150626 b) {
			return Multi(a, Inverse(b));
		}

		static public Fraction150626 operator *(Fraction150626 a,Fraction150626 b) {
			return new Fraction150626( a.numerator*b.numerator, a.denominator*b.denominator  );
		}
	static public Fraction150626 Divide(num.natural.__bigint.be.Positive.Asserted x, BigInteger y) {

			if (y<0)
			{
				return new Fraction150626(-x.val, -y);
				
			}
			return new Fraction150626(x.val, y);
		
		}	

		static public Fraction150626 Inverse(Fraction150626 a)
		{

			return Divide(a.denominator,a.numerator);


		}

	

		static public Fraction150626 ToFraction2(long a)
		{
			return new Fraction150626(a, 1);
		}

		



	
		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Fraction150626 Parse(string s)
		{

			///first find the /
			///
			/// 
			string[] terms = s.Split(rational.op.Divide.Sign);
			if (terms.Length != 2)
			{
				throw new Exception(string.Format("There are more than two terms sperated by {0}.", rational.op.Divide.Sign));

			}

			return new Fraction150626(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));


			/// 
			///first is it an integer?
			///




		}

	}
}
