using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using F = nilnul.num._quotient.Frac;
using nilnul.num._num.bigint.be;
using nilnul._num.bigint.be_;
using nilnul._num.bigint.be;

namespace nilnul.num._quotient.frac.convert_.standize
{

	public class Ed

	//: F //composition is prefereed to inheritace
	{

		private F _frac;



		public F frac
		{
			get { return _frac; }
			set
			{

				_frac = _StandizeX.Frac(frac);

			}
		}

		public Ed(F fraction)
		{
			this.frac = fraction;
		}

		public Ed(

			BigInteger num
			,
			nilnul.num_.Positive denominator
		) : this(new F(num, denominator))
		{
		}

		public Ed(int num, int denominator) : this(
			new F(num, denominator)
		)
		{

		}

		public Ed(int num, BigInteger denominator) : this(
			new F(num, denominator)
		)
		{

		}
		public Ed(BigInteger num, BigInteger denominator) : this(
			new F(num, denominator)
		)
		{

		}

		public Ed() : this(new F())
		{

		}

		public Ed(BigInteger num)
		: this(
			new F(num)
		 )
		{

		}

		public Ed(long value1, long value2)
			: this((BigInteger)value1, value2)
		{

		}



		public override string ToString()
		{

			return toTxt();
#if DEBUG
				return nilnul.num.quotient.radix.Dec.FroQuotient(this,10).ToString();
#else

			return toTxt();


#endif

		}

		public string toTxt()
		{
			return $"{numerator}/{denominator}";

		}

		public int signInInt { get { return numerator.Sign; } }



		public BigInteger numerator
		{
			get { return _frac.numerator; }
		}

		public nilnul.num_.Positive denominator
		{
			get { return new nilnul.num_.Positive(_frac.denominator); }
		}




		static public implicit operator Ed(BigInteger x)
		{
			return new Ed(x);
		}

		static public implicit operator Ed(Plural.En x)
		{
			return new Ed(x);
		}

		static public implicit operator Ed(nilnul._num.bigint.be.Natural.Asserted x)
		{
			return new Ed(x.val);
		}
	}
}
