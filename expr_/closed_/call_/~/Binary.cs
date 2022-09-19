using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.op_;
using nilnul.num.quotient.op_.binary_;

namespace nilnul.num.quotient.expr_.call_
{


	public class Binary :
		nilnul.obj.expr_.call_.Binary<nilnul.num.Quotient1, nilnul.num.quotient.ExprI, nilnul.num.quotient.op_.BinaryI1>
		,
		ExprI
	{
		public Binary(BinaryI1 op, ExprI arg,ExprI arg1) : base(op, arg,arg1)
		{
		}


		public Binary(BinaryI1 op, int x, ExprI y):this(op, new nilnul.num.quotient.expr_.call_.Nary(x) ,y)
		{
		}

		static public Binary OvDiv(ExprI x, ExprI y) {
			return new Binary(
				nilnul.num.quotient.op_.binary_.Div1.Singleton
				,
				x,y
			);
		}
		static public Binary OvAdd(ExprI x, ExprI y) {
			return new Binary(
				nilnul.num.quotient.op_.binary_.Add.Singleton
				,
				x,y
			);
		}

		static public Binary OvDiv(int x, ExprI y) {
			return new Binary(
				nilnul.num.quotient.op_.binary_.Div1.Singleton
				,
				x,y
			);
		}
		static public Binary OvAdd(int x, ExprI y) {
			return new Binary(
				nilnul.num.quotient.op_.binary_.Add.Singleton
				,
				x,y
			);
		}

		public static Binary OvDiv(int v, nilnul.num.quotient.expr_.Variable x)
		{
			return OvDiv(
				v, 
				(ExprI)(x)
			);
		}
		public static Binary OvAdd(int v, nilnul.num.quotient.expr_.Variable x)
		{
			return OvAdd(
				v, 
				(ExprI)(x)
			);
		}

		public static Binary OvDiv(int v, Var x)
		{
			return OvDiv(
				v, 
				new nilnul.num.quotient.expr_.Variable(x)
			);
		}
		public static Binary OvAdd(int v, Var x)
		{
			return OvAdd(
				v, 
				new nilnul.num.quotient.expr_.Variable(x)
			);
		}


	}
}
