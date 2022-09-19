using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider_.func_.exp.proven_
{
	/// <summary>
	/// it is proven that this stream is increasing strictly.
	///
	///
	/// 
	/// </summary>
	interface IArise
	{
	}

	public class Arise
	{
		
		//static public nilnul.num.quotient.Var nVar = new Var();



		//static public nilnul.num.quotient.expr_.closed_.Variable n = new expr_.closed_.Variable(nVar);

		//static public System.Linq.Expressions.ParameterExpression nVar1 = System.Linq.Expressions.Expression.Parameter(typeof(nilnul.num.QuotientI1));


		public static void MethodName()
		{
			var n2 = Expr_linq.Par();
			var div = 1 / n2;

			var plus = 1 + div;

			var one = new nilnul.num.Quotient1(1);

			Expression< Func<nilnul.Num1, Quotient1>> t = (nilnul.Num1 n) =>
			 n == 0 ?
				1 // lim (1+1/n)^n when n-->0, is 1. this can be proven by ln( ( 1 + 1/n ) ^n) and observe its derivative

				:

				(1 + one / n) ^ n;
			;

			var e = t.Body;

			///when n>1
			Expression< Func<nilnul.Num1, Quotient1>> t1 = (nilnul.Num1 n) =>
			 nilnul.num.quotient.op_.binary_.add.Cumulator.Singleton.accumulate(
					nilnul.num.str_._UpTo._Bigints(n.en).Select(x => new nilnul.Num1(x)).Select(
						j => nilnul.num.co_.ge._CombinateX._assumeNumGe(n, j) * nilnul.num.quotient.op_.unary_.Inverse.Singleton.op( n ) ^ j
					)
				);



			;

			var e1 = t1.Body;

			/// sum of product. count of summands is growing. and each old summand is growing.
			Expression<Func<nilnul.Num1, Quotient1>> t2 = (nilnul.Num1 n) =>
		   nilnul.num.quotient.op_.binary_.add.Cumulator.Singleton.accumulate(
				/// as n grows, we have more terms.
				  nilnul.num.str_._UpTo._Bigints(n.en).Select(x => new nilnul.Num1(x)).Select(
					  j =>
					  nilnul.num.quotient.op_.binary_.multi.Cumulator.Singleton.accumulate(
														//given j, each of the following would be bigger
						  new nilnul.nums_.Before(j).Select(
							   k =>		
							   (
								  1
								  -
								nilnul.num.quotient.op_.binary_.Div1.Singleton.op(
									k
									,
									n
								)
							  ) * (nilnul.num.quotient.op_.unary_.Inverse.Singleton.op(
								  nilnul.num.op_.unary_.factorial_.Memoize.Singleton.op(j)
								  )
							  )
						  )
					  )
				  )
			  );



			;

			var e2 = t2.Body;


			//when n >0
			// we have e ==> e1 ==> e2
			/// and the terms



		}


		//var OneOverN=








	}


}
