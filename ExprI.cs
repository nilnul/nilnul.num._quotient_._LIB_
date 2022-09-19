using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.QuotientI1;

namespace nilnul.num.quotient
{


	public interface ExprI1 : nilnul.obj.ExprI3<nilnul.num.QuotientI1>

	{

	}

	public interface ExprI_linq
		: IExpr
	{

	}

	[Obsolete()]
	public interface ExprI : nilnul.obj.ExprI3<nilnul.num.Quotient1>

	{

	}





	public class Expr :
		nilnul.obj.Box1<ExprI1>
		,
		ExprI1
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="val"></param>
		/// <remarks>
		/// private to avoid too much layers of wrapment
		/// </remarks>
		private Expr(ExprI1 val) : base(val)
		{
		}

		static public Expr Ov(ExprI1 x)
		{
			if (x is Expr y)
			{
				return y;
			}
			return new Expr(x);
		}

	}

	public class Expr_linq

	{
		private System.Linq.Expressions.Expression _expr;

		public System.Linq.Expressions.Expression expr
		{
			get { return _expr; }
			set
			{
				nilnul.bit.vow_.True1.Vow(
					value.Type == typeof(nilnul.num.QuotientI1)
				);

				_expr = value;

			}
		}

		static public MethodCallExpression MethodCall(
			Expression<Func<Q1,Q1,Q1>> func
		) {
			return func.Body as MethodCallExpression;
		}

		static public Expression<Func<Q1 ,Q1 , Q1 > > LambdaBinary(
			nilnul.num.quotient.op_.BinaryI2 binary
			
		) {
			return (nilnul.num.QuotientI1 a, nilnul.num.QuotientI1 b) =>binary.op(a,b);
		}

		static public MethodCallExpression MethodCall(
				nilnul.num.quotient.op_.BinaryI2 binary
		) {
			return MethodCall(
				LambdaBinary(binary)
			);
		}

		static public Expr_linq Int(int x) {
			return new Expr_linq(
				Expression.Constant(
					new nilnul.num.Quotient1(x) as Q1
				)
			);
		}
		static public Expr_linq operator /(int x, Expr_linq y) {
			return Int(x) / y;
		}

		static public Expr_linq operator +(int x, Expr_linq y) {
			return Int(x) + y;
		}


		static public Expr_linq operator /(Expr_linq x, Expr_linq y) {


			return new Expr_linq( Expression.Call(
				Expression.Constant(nilnul.num.quotient.op_.binary_.Div1.Singleton
				)
				
				,
typeof(nilnul.num.quotient.op_.binary_.Div1).GetMethod("op", new Type[] { typeof(Q1), typeof(Q1) }),
				
				x.expr
				,
				y.expr
			));
		}

		static public Expr_linq operator +(Expr_linq x, Expr_linq y) {


			return new Expr_linq( Expression.Call(
				Expression.Constant(nilnul.num.quotient.op_.binary_.Add.Singleton
				)
				
				,
typeof(nilnul.num.quotient.op_.binary_.Add).GetMethod("op", new Type[] { typeof(Q1), typeof(Q1) }),
				
				x.expr
				,
				y.expr
			));
		}

		public Expr_linq(
			System.Linq.Expressions.Expression expr
		)
		{
			this.expr = expr;
		}

		static public Expr_linq Par(

		) {
			return new Expr_linq(
				System.Linq.Expressions.Expression.Parameter(typeof(Q1))
			);
		}


	}
}
