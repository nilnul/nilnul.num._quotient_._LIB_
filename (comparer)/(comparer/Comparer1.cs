using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;//.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;//.rational.Rational_InheritFraction2;

namespace nilnul.num.quotient
{
	public  class Comparer1
		:
		nilnul.comparer.AsEq_comparerDefault<Q1,Comparer1>
		
		
	
		,
		IComparer<Q1>


	{
		private static Lazy<Comparer1> _lazy;

		public static Comparer1 lazy
		{
			get
			{
				return _lazy.Value;
			}
		}


		[Obsolete("Singleton BeforeFieldInit Complex", false)]

		static public Comparer1 Singleton
		{
			get { return SingletonByDefault<Comparer1>.Instance; }
		}

		//static public Comparer1 Singleton1 {
		//	get {
		//		return Singleton;
		//	}
		//}

		 static Comparer1(){


//Singleton = SingletonByDefault<Comparer1>.Instance;

			_lazy = new Lazy<Comparer1>(
				 	
			);
		}



		static public int Eval(Q1 x, Q1 y

			) {
				return (x - y).signInInt;
		}
		public int Compare(Q1 x, Q1 y)
		{
			return (x - y).signInInt;

			throw new NotImplementedException();
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
		
	}

}
