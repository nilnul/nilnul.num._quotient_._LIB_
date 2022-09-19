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

	public class ComputeItemByPoly_ofPhiPsi
	{

		/// <summary>
		/// # Fib(n) = (phi**n - psi**n) / (phi - psi)
		/// #        = (a phi + b - a psi - b) / (phi - psi)
		/// #        = a
		/// # where Poly(a,b) = a phi + b = phi ** n = Poly(1,0) ** n
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		static public BigInteger Eval(BigInteger n)
		{

			return Poly.Pow(new Poly(0, 1), n).slope;


			throw new NotImplementedException();



		}



		/// <summary>
		/// a+b*(phi|psi), where phi|psi are the conjugate roots of x^2=x+1
		/// </summary>
		/// <remarks>
		/// </remarks>

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
				return string.Format("{0}{1}*p", intercept, slope.ToString("+0;-0"));
			}

			static public Poly CreateMultiZeroElement()
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

			///    (a1 x + b1) (a2 x + b2) 
			/// = a1 a2 x^2 + (a1 b2 + a2 b1) x + b1 b2
			/// 
			/// ##due to x^2=x+1##
			/// 
			/// = (a1 a2 + a1 b2 + a2 b1) x + a1 a2 + b1 b2

			static public Poly operator *(Poly a, Poly b)
			{
				var slopeProduct = a.slope * b.slope;
				return new Poly(a.intercept * b.intercept + slopeProduct, a.intercept * b.slope + a.slope * b.intercept + slopeProduct);
			}

			/// <summary>
			/// 
			/// </summary>
			/// <param name="a"></param>
			/// <returns></returns>
			/// <remarks>
			/// intercept*intercept + slope*slope,   
			/// 2*intercept*slope+slope*slope
			/// 
			/// so, extrapolately, the intercept and slope of the Poly^n are the same for Poly=(a * p + b) 
			/// </remarks>
			static public Poly Square(Poly a)
			{
				return a * a;
			}

			static public Poly operator *(Poly a, BigInteger b)
			{
				return new Poly(a.intercept * b, a.slope * b);
			}
			static public Poly operator *(BigInteger b, Poly a)
			{
				return new Poly(a.intercept * b, a.slope * b);
			}

			/// <summary>
			/// note here the intercept and slope are calculated the same way no matter the it's phi or psi. So the intercept and slope will be the same if the base's slope and intercept are the same no matter it's phi or psi.
			/// </summary>
			/// <param name="poly"></param>
			/// <param name="index"></param>
			/// <returns></returns>

			static public Poly Pow(Poly poly, BigInteger index)
			{
				if (index == 0)
				{
					return new Poly(1, 0);

				}

				//TODO make this loop instead of recur. in refence of newsmth.net user "milksea" 's python code:

				/*

				发信人: milksea (肥了，又肥了 >>>_<<<), 信区: ITExpress
标  题: Re: 为什么这种奇葩代码风格能成为一种标准？？
发信站: 水木社区 (Sat Jul 11 16:50:54 2015), 站内

这种练习性质的代码谁留着啊？重写了一个，就这么看吧。为了清楚写了个类，其实整理一下也可以写在一个函数里。

#!python3

class Poly:
    # a x + b, where x^2 = x + 1
    def __init__(self, a=0, b=0):
        self.a, self.b = a, b

    #   (a1 x + b1) (a2 x + b2) 
    # = a1 a2 x^2 + (a1 b2 + a2 b1) x + b1 b2
    # = (a1 a2 + a1 b2 + a2 b1) x + a1 a2 + b1 b2
    def __mul__(self, other):
        square = self.a * other.a
        cross = self.a * other.b + self.b * other.a
        const = self.b * other.b
        return Poly(square + cross, square + const)

    def __pow__(self, n):
        p = Poly(self.a, self.b)
        res = Poly(0, 1)
        while n != 0:
            if n % 2:
                res = res * p
            p = p * p
            n = n // 2
        return res

    def __str__(self):
        return '({}phi + {})'.format(self.a, self.b)

    def __repr__(self):
        return '({}, {})'.format(self.a, self.b)

# Fib(n) = (phi**n - psi**n) / (phi - psi)
#        = (a phi + b - a psi - b) / (phi - psi)
#        = a
# where Poly(a,b) = a phi + b = phi ** n = Poly(1,0) ** n
def fib(n):
    phi_n = Poly(1, 0) ** n
    return phi_n.a

for n in range(10):
    print('  Fib({:3d}) = {}'.format(n, fib(n)))
for n in range(10, 1000, 100):
    print('  Fib({:3d}) = {}'.format(n, fib(n)))

【 在 ottffsse (nothing) 的大作中提到: 】
: 强烈要求贴，我要学习。跪求。


--
世界上有 10 种人：懂 10 进制的和不懂 10 进制的。



				*/

				BigInteger remainder;
				BigInteger quotient = BigInteger.DivRem(index, 2, out remainder);
				var halfPow = Pow(poly, quotient);
				return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * poly;


			}







		}


	}
}
