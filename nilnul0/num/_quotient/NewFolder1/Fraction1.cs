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
	[Obsolete(nameof(nilnul.num.Quotient_unsimplified))]
	public  class Frac
	{
		public const char DividerSign= '/';
		#region fields

			public BigInteger numerator;

			public nilnul.num_.Positive1 _denominator;

		#endregion

		public nilnul.num_.Positive1 denominator
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
		public Frac(
			BigInteger num
			,
			nilnul.num_.Positive1 denominator
		)
		{
			this.numerator = num;
			this.denominator = denominator;


		}
		public Frac(BigInteger numerator)
			: this(numerator, new num_.Positive1(1))
		{ }

		public Frac()
			:this(0)
		{

		}


		[Obsolete(nameof(CreateByDivide))]
		public Frac(BigInteger numerator, BigInteger denominator)
		{
			if (denominator<0)
			{
				this.numerator = -numerator;
				this.denominator = new nilnul.num_.Positive1(-denominator);
				return;
			}
			this.numerator = numerator;
			this.denominator = new nilnul.num_.Positive1(denominator);
		}

		

		public Frac inverse()
		{
			return Inverse(this);
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

		static public Frac CreateByDivide(BigInteger x, nilnul.num.integer.be_.NonZero.En y)
		{

			if (y.asserted >0)
			{
				return new Frac(x, new Positive.Asserted(y.asserted)  );
			}

			return new Frac(-x, new Positive.Asserted(-y.asserted));

		}

		static public Frac CreateByDivide(BigInteger x, BigInteger y)
		{

			if (y>0)
			{
				return new Frac(x, new num_.Positive1(y)  );
			}

			return new Frac(-x, new num_.Positive1(-y));

		}


		static public Frac CreateQuarter() {
			return new Frac(1, 4);
		}

		static public Frac Divide(BigInteger x, BigInteger y) {

			if (y<0)
			{
				return new Frac(-x, -y);
				
			}
			return new Frac(x, y);
		
		}

		static public Frac Multi(Frac a,Frac b) {
			return new Frac( a.numerator*b.numerator, a.denominator.en*b.denominator.en  );
		}
		static public Frac Divide(Frac a, Frac b) {
			return Multi(a, Inverse(b));
		}

		static public Frac operator *(Frac a, Frac b) {
			return new Frac( a.numerator*b.numerator, a.denominator.en*b.denominator.en  );
		}

		static public Frac operator *(BigInteger a, Frac b) {
			return new Frac( a*b.numerator, b.denominator  );
		}

	static public Frac Divide(num.natural.__bigint.be.Positive.Asserted x, BigInteger y) {

			if (y<0)
			{
				return new Frac(-x.val, -y);
				
			}
			return new Frac(x.val, y);
		
		}	

		static public Frac Inverse(Frac a)
		{

			return Divide(a.denominator,a.numerator);


		}

	

		static public Frac ToFraction2(long a)
		{
			return new Frac(a, 1);
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
			string[] terms = s.Split(DividerSign);

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
						string.Format("There are more than two terms sperated by {0}.", DividerSign)
					);
					break;
			}

		}

		static public bool TryParse(string s, out Frac result )
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

				throw;
			}

		}



	}
}
