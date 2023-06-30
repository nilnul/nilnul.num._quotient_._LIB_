using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient_;
using System.Numerics;

namespace nilnul.num.quotient.of_.binary_
{
	 public class Divide
	:
		BinaryA,
		BinaryI
	{
	

		public override string ToString()
		{
			return "/";
		}

		public  nilnul.num.Quotient1 op(nilnul.num.Quotient1 a, nilnul.num.Quotient1 b)
		{

			return new Quotient1(a.numerator * b.denominator, a.denominator * b.numerator);


		}

		public  nilnul.num.Quotient1 op(nilnul.NumI1 a, nilnul.num.Quotient1 b)
		{

			return op( a.ToNum(),b );


		}

		public  nilnul.num.Quotient1 op(nilnul.Num1 a, nilnul.num.Quotient1 b)
		{

			return new Quotient1(a * b.denominator,  b.numerator);


		}

		public override DenomNonnil op(DenomNonnil par, DenomNonnil par1)
		{
			return par / par1;
		}
		public  DenomNonnil op(BigInteger par, BigInteger par1)
		{
			return new DenomNonnil(par,par1);
		}


		static public Divide Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Divide>.Unison;
			}
		}

		static public Divide Singleton
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Divide>.Unison;
				//return nilnul.Singleton1<Divide>.Instance;
			}
		}

	}

	
}
