using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Rational_InheritFraction2 = nilnul.num.quotient.Q;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.op
{
	[Obsolete()]
	public  class _PowX
	{

		static public Q Eval(Q r,BigInteger index) {
			return Q.Divide(
				Eval(r.numerator,index)
				,
				Eval(r.denominatorAsBigInt,index)
			);
		}
		

		static public Q Eval(
		BigInteger base_,
		BigInteger index
		)
		{
			if (index >= 0)
			{
				return new Q(nilnul.num.int_.op.Pow.Eval(base_, index));

			}
			return  Q.Inverse( nilnul.num.int_.op.Pow.Eval(base_, -index));




			throw new NotImplementedException();
		}


		static public Q1 _Eval_basePlural_retQ(
	BigInteger base_plural,
	BigInteger index
	)
		{
			if (index >= 0)
			{
				return new Q1(nilnul.num.int_.op.Pow.Eval(base_plural, index));

			}
			return new Q1(1, nilnul.num.int_.op.Pow.Eval(base_plural, -index));




			throw new NotImplementedException();
		}

	

		static public Rational_InheritFraction2 _Eval_basePlural2(
BigInteger base_plural,
BigInteger index
)
		{
			if (index >= 0)
			{
				return new Rational_InheritFraction2(nilnul.num.int_.op.Pow.Eval(base_plural, index));

			}
			return Rational_InheritFraction2.Inverse( nilnul.num.int_.op.Pow.Eval(base_plural, -index));




			throw new NotImplementedException();
		}


		static public Q Eval_Zero_Zero_retOne(
	)
		{
			return 1;

			throw new NotImplementedException();
		}

		static public Q Eval_Zero_Zero_exception(
)
		{
			throw new DivideByZeroException();

			throw new NotImplementedException();
		}


	}

	[Obsolete()]
	public  class PowX
	{

		static public Q Do(Q r,BigInteger index) {
			return Q.Divide(
				Do(r.numerator,index)
				,
				Do(r.denominatorAsBigInt,index)
			);
		}
		

		static public Q Do(
		BigInteger base_,
		BigInteger index
		)
		{
			if (index >= 0)
			{
				return new Q(nilnul.num.int_.op.Pow.Eval(base_, index));

			}
			return  Q.Inverse( nilnul.num.int_.op.Pow.Eval(base_, -index));




			throw new NotImplementedException();
		}


		static public quotient.Q Eval_basePlural_retQ(
	BigInteger base_plural,
	BigInteger index
	)
		{
			if (index >= 0)
			{
				return new quotient.Q(nilnul.num.int_.op.Pow.Eval(base_plural, index));

			}
			return new quotient.Q(1, nilnul.num.int_.op.Pow.Eval(base_plural, -index));




			throw new NotImplementedException();
		}

		static public Q1 _Eval_basePlural(
	BigInteger base_plural,
	BigInteger index
	)
		{
			if (index >= 0)
			{
				return new Q1(nilnul.num.int_.op.Pow.Eval(base_plural, index));

			}
			return new Q1(1, nilnul.num.int_.op.Pow.Eval(base_plural, -index));




			throw new NotImplementedException();
		}
	

		static public Rational_InheritFraction2 Eval_basePlural2(
BigInteger base_plural,
BigInteger index
)
		{
			if (index >= 0)
			{
				return new Rational_InheritFraction2(nilnul.num.int_.op.Pow.Eval(base_plural, index));

			}
			return Rational_InheritFraction2.Inverse( nilnul.num.int_.op.Pow.Eval(base_plural, -index));




			throw new NotImplementedException();
		}


		static public Q Eval_Zero_Zero_retOne(
	)
		{
			return 1;

			throw new NotImplementedException();
		}

		static public Q Eval_Zero_Zero_exception(
)
		{
			throw new DivideByZeroException();

			throw new NotImplementedException();
		}


	}
}

namespace nilnul.num.rational.op
{
	public partial class PowX
	{

		static public Rational_InheritFraction2 Do(Rational_InheritFraction2 r,BigInteger index) {
			return Rational_InheritFraction2.Divide(
				Do(r.numerator,index)
				,
				Do(r.denominatorAsBigInt,index)
			);
		}
		static public Rational_InheritFraction Eval(
			BigInteger base_,
			BigInteger index
			) {
				if (index>=0)
				{
					return new Rational_InheritFraction( nilnul.num.int_.op.Pow.Eval(base_, index));
					
				}
				return new Rational_InheritFraction(1, nilnul.num.int_.op.Pow.Eval(base_, -index));

				


			throw new NotImplementedException();
		}

		static public Rational_InheritFraction2 Do(
		BigInteger base_,
		BigInteger index
		)
		{
			if (index >= 0)
			{
				return new Rational_InheritFraction2(nilnul.num.int_.op.Pow.Eval(base_, index));

			}
			return  Rational_InheritFraction2.Create(1, nilnul.num.int_.op.Pow.Eval(base_, -index));




			throw new NotImplementedException();
		}


		static public quotient.Q Eval_basePlural_retQ(
	BigInteger base_plural,
	BigInteger index
	)
		{
			if (index >= 0)
			{
				return new quotient.Q(nilnul.num.int_.op.Pow.Eval(base_plural, index));

			}
			return new quotient.Q(1, nilnul.num.int_.op.Pow.Eval(base_plural, -index));




			throw new NotImplementedException();
		}

		static public Rational_InheritFraction Eval_basePlural(
	BigInteger base_plural,
	BigInteger index
	)
		{
			if (index >= 0)
			{
				return new Rational_InheritFraction(nilnul.num.int_.op.Pow.Eval(base_plural, index));

			}
			return new Rational_InheritFraction(1, nilnul.num.int_.op.Pow.Eval(base_plural, -index));




			throw new NotImplementedException();
		}

		static public Rational_InheritFraction2 Eval_basePlural2(
BigInteger base_plural,
BigInteger index
)
		{
			if (index >= 0)
			{
				return new Rational_InheritFraction2(nilnul.num.int_.op.Pow.Eval(base_plural, index));

			}
			return Rational_InheritFraction2.Create(1, nilnul.num.int_.op.Pow.Eval(base_plural, -index));




			throw new NotImplementedException();
		}


		static public Rational_InheritFraction Eval_Zero_Zero_retOne(
	)
		{
			return 1;

			throw new NotImplementedException();
		}

		static public Rational_InheritFraction Eval_Zero_Zero_exception(
)
		{
			throw new DivideByZeroException();

			throw new NotImplementedException();
		}


	}
}
