using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;//.rational.Rational_InheritFraction2;

namespace nilnul.num.quotient
{
	public  class Comparer2
		:
		nilnul.comparer.AsEq_comparerDefault<Q1,Comparer2>
	
		,
		IComparer<Q1>
		,
		IComparer<nilnul.num.QuotientI>
		,
		IComparer<nilnul.num.QuotientI1>



	{
		private static Lazy<Comparer2> _lazy;

		public static Comparer2 lazy
		{
			get
			{
				return _lazy.Value;
			}
		}


		//[Obsolete("Singleton BeforeFieldInit Complex", false)]

		static public Comparer2 Singleton
		{
			get { return Singleton1<Comparer2>.Instance; }
		}

		//static public Comparer1 Singleton1 {
		//	get {
		//		return Singleton;
		//	}
		//}

		 static Comparer2(){


//Singleton = SingletonByDefault<Comparer1>.Instance;

			_lazy = new Lazy<Comparer2>(
				 	
			);
		}



		static public int Eval(Q1 x, Q1 y

			) {
				return (x - y).signInInt;
		}
		public int Compare(Q1 x, Q1 y)
		{
			return (x - y).signInInt;

			;
		}

		public int sign(Q1 x)
		{
			return Compare(x,0);

			throw new NotImplementedException();
		}



		[Obsolete("Singleton BeforeFieldInit Complex",true)]
		static public int Sign(Q1 x) {
			return lazy.Compare(x, 0);
		}

		public int Compare(QuotientI x, QuotientI y)
		{
			return nilnul.num.integer._SignX.Int( nilnul.num.quotient.combine_.Minus.Singleton.eval(x,y).numerator);
		}
		public int Compare(Quotient1 x, QuotientI y)
		{
			return nilnul.num.integer._SignX.Int( nilnul.num.quotient.combine_.Minus.Singleton.eval(x,y).numerator);
		}

		public int Compare(QuotientI1 x, QuotientI1 y)
		{
			return nilnul.num.integer._SignX.Int( nilnul.num.quotient.op_.binary_.Minus.Singleton.op(x,y).numerator);

		}
	}

}
