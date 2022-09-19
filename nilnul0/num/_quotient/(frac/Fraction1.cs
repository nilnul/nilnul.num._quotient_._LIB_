using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;
using nilnul._num.bigint.be;

namespace nilnul.num._quotient
{
	/// <summary>
	/// guratee that denominator is positive.
	/// </summary>
	///
	[Obsolete(nameof(_quotient.Frac))]
	public  class Fraction1
	{
		public const char DividerSign= '/';
		#region fields

			public BigInteger numerator;
			public nilnul._num.bigint.be.Positive.Asserted _denominator;

		#endregion



		public nilnul._num.bigint.be.Positive.Asserted denominator
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
		public Fraction1()
			:this(0)
		{

		}

		public Fraction1(BigInteger numerator)
			: this(numerator, 1)
		{ }

		public Fraction1(
			BigInteger num
			,
			Positive.Asserted denominator
		)
		{
			this.numerator = num;
			this.denominator = denominator;


		}

		[Obsolete()]
		public Fraction1(BigInteger numerator, BigInteger denominator)
			
		
		{

			if (denominator<0)
			{
				this.numerator = -numerator;
				this.denominator = new Positive.Asserted(-denominator);
				return;

			}
				this.numerator = numerator;
				this.denominator = new Positive.Asserted(denominator);



		}

		

		public Fraction1 inverse()
		{
			return Inverse(this);
		}

		



		public override string ToString()
		{
			return numerator.ToString() + "/" + denominator.ToString();
		}



		public void simplify()
		{
			var gcd = integer.duo.op.Gcd.Eval(numerator, denominator);

			numerator = nilnul.num.integer.duo.op.Divide._Eval_floor_divisorPositive(  numerator, gcd);


			this.denominator =nilnul.num.integer.duo.op.Divide.Eval(  denominator, gcd) ;


		}

		static public Fraction1 Simplify(Fraction1 f)
		{
			var gcd = nilnul.num.i.op.Gcd.Eval(f.numerator, f.denominator);
			return new Fraction1(f.numerator / gcd, f.denominator / gcd);

			


		}

		static public Fraction1 Create(BigInteger x, nilnul.num.integer.be_.NonZero.En y)
		{

			if (y.asserted >0)
			{
				return new Fraction1(x, new Positive.Asserted(y.asserted)  );
			}

			return new Fraction1(-x, new Positive.Asserted(-y.asserted));

		}

		static public Fraction1 Create(BigInteger x, BigInteger y)
		{

			return Create(x, new integer.be_.NonZero.En(y));
		}


		static public Fraction1 CreateQuarter() {
			return new Fraction1(1, 4);
		}

		static public Fraction1 Divide(BigInteger x, BigInteger y) {

			if (y<0)
			{
				return new Fraction1(-x, -y);
				
			}
			return new Fraction1(x, y);
		
		}

		static public Fraction1 Multi(Fraction1 a,Fraction1 b) {
			return new Fraction1( a.numerator*b.numerator, a.denominator*b.denominator  );
		}
		static public Fraction1 Divide(Fraction1 a, Fraction1 b) {
			return Multi(a, Inverse(b));
		}

		static public Fraction1 operator *(Fraction1 a, Fraction1 b) {
			return new Fraction1( a.numerator*b.numerator, a.denominator*b.denominator  );
		}

		static public Fraction1 operator *(BigInteger a, Fraction1 b) {
			return new Fraction1( a*b.numerator, b.denominator  );
		}

	static public Fraction1 Divide(num.natural.__bigint.be.Positive.Asserted x, BigInteger y) {

			if (y<0)
			{
				return new Fraction1(-x.val, -y);
				
			}
			return new Fraction1(x.val, y);
		
		}	

		static public Fraction1 Inverse(Fraction1 a)
		{

			return Divide(a.denominator,a.numerator);


		}

	

		static public Fraction1 ToFraction2(long a)
		{
			return new Fraction1(a, 1);
		}

		



	
		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Fraction1 Parse(string s)
		{

			///first find the /
			///
			/// 
			string[] terms = s.Split(DividerSign);

			switch (terms.Length)
			{
				case 0:
					return new Fraction1();
				case 1:
					return new Fraction1(
						BigInteger.Parse(terms[0])
					);
				case 2:
					return new Fraction1(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));

				default:
					throw new Exception(
						string.Format("There are more than two terms sperated by {0}.", DividerSign)
					);
					break;
			}

		}

		static public bool TryParse(string s, out Fraction1 result )
		{

			try
			{
				result = Parse(s);
				return true;
			}
			catch (Exception)
			{
				result = default(Fraction1);
				return false;

				throw;
			}

		}



	}
}
