﻿using nilnul.num.quotient_.denomNonnil;
using System.Collections.Generic;

using Q1 = nilnul.num.Quotient_unsimplified;


namespace nilnul.num.quotient
{
	public  class Eq2
		 :
		EqI2
		,
		IEqualityComparer<nilnul.num.QuotientI1>
		,
		IEqualityComparer<nilnul.num.Quotient1>
		,
		IEqualityComparer<nilnul.num.quotient_.DenomNonnil>
		,
		IEqualityComparer<nilnul.num.quotient_.DenomNonnilI>


		
	{

		public bool Equals(Q1 x, Q1 y)
		{
			return (x-y)._numerator==0;
			//return nilnul.num.quotient.be_.Zero.Singleton.be(  
			//	nilnul.num.quotient.combine_.Minus.Singleton.eval(x,y) 
			//);
		}

		public int GetHashCode(Q1 obj)
		{

			return 0;
		}

		public bool Equals(QuotientI1 x, QuotientI1 y)
		{
			return x.numerator == y.numerator && (x.denominator1.en == y.denominator1.en);
		}

		public int GetHashCode(QuotientI1 obj)
		{
			return obj.numerator.GetHashCode() ^ obj.denominator1.en.GetHashCode();

		}

		public bool Equals(Quotient1 x, Quotient1 y)
		{
			return Equals((QuotientI1)x, y);
		}

		public int GetHashCode(Quotient1 obj)
		{
			return GetHashCode((QuotientI1)obj);
			//throw new NotImplementedException();
		}

		public bool Equals(quotient_.DenomNonnil x, quotient_.DenomNonnil y)
		{
			return x == y;
			//throw new System.NotImplementedException();
		}
		public bool Equals(quotient_.DenomNonnilI x, quotient_.DenomNonnilI y)
		{
			return (x.ToImpl()- y).SignAsInt()==0;
			//throw new System.NotImplementedException();
		}


		public int GetHashCode(quotient_.DenomNonnilI obj)
		{
			return 0;

			//throw new System.NotImplementedException();
		}
		public int GetHashCode(quotient_.DenomNonnil obj)
		{
			return obj.GetHashCode();

			//throw new System.NotImplementedException();
		}


		static public Eq2 Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq2>.Instance;
			}
		}


	}

	
}
