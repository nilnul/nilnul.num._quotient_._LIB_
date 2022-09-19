using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.quotient.stream.fibanacci
{

	/// <summary>
	/// # Fib(n) = (phi**n - psi**n) / (phi - psi)
///        = (a phi + b - a psi - b) / (phi - psi)
///        = a
	/// </summary>

	public class ComputeItemByPoly
	{
		static public BigInteger Eval_bySlope(BigInteger n)
		{

			return (
					(
						Poly.Pow(new Poly(1, 1), n)
						-
						Poly.Pow(new Poly(1, -1), n)
					)

				).slope
				/
				(
					 nilnul.num.op.Pow.Eval_byFolding(2, n)
				);

			throw new NotImplementedException();



		}


		static public BigInteger Eval_byIntercept_notGood(BigInteger n)
		{

			//var goldenRatio_biger__numerator = new Poly(1, 1);
			//var goldenRatio_inverse_numerator = new Poly(1, -1);
			return (
					(
						Poly.Pow(new Poly(1, 1), n)
						-
						Poly.Pow(new Poly(1, -1), n)
					)
					*
					new Poly(0, 1)
				).intercept
				/
				(
					5 * nilnul.num.op.Pow.Eval_byFolding(2, n)
				);

			throw new NotImplementedException();



		}
		/// <summary>
		/// a+b*sqrt(5)
		/// </summary>

		public struct Poly
		{
			public BigInteger intercept;
			public BigInteger slope;

			//public Poly()
			//{
			//	intercept = 0;
			//	slope = 0;
			//}

			public Poly(BigInteger a, BigInteger b)
			{
				this.intercept = a;
				this.slope = b;

			}

			public override string ToString()
			{
				return string.Format("{0}{1}*sqrt(5)", intercept, slope.ToString("+0;-0"));
			}

			static public Poly CreateMultiUnit()
			{
				return new Poly(1, 0);
			}
			static public Poly operator +(Poly a, Poly b)
			{
				return new Poly(a.intercept + b.intercept, a.slope + b.slope);
			}
			static public Poly operator +(Poly a, BigInteger b)
			{
				return new Poly(a.intercept + b, a.slope);
			}
			static public Poly operator +(BigInteger b, Poly a)
			{
				return new Poly(a.intercept + b, a.slope);
			}
			static public Poly operator -(Poly a)
			{
				return new Poly(-a.intercept, -a.slope);
			}

			static public Poly operator -(Poly a, Poly b)
			{
				return new Poly(a.intercept - b.intercept, a.slope - b.slope);
			}
			static public Poly operator *(Poly a, Poly b)
			{
				return new Poly(a.intercept * b.intercept + a.slope * b.slope * 5, a.intercept * b.slope + a.slope * b.intercept);
			}

			static public Poly operator *(Poly a, BigInteger b)
			{
				return new Poly(a.intercept * b, a.slope * b);
			}
			static public Poly operator *(BigInteger b, Poly a)
			{
				return new Poly(a.intercept * b, a.slope * b);
			}

			static public Poly Pow(Poly poly, BigInteger index)
			{
				if (index == 0)
				{
					return new Poly(1, 0);

				}



				BigInteger remainder;
				BigInteger quotient = BigInteger.DivRem(index, 2, out remainder);
				var halfPow = Pow(poly, quotient);
				return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * poly;


			}







		}


	}
}
