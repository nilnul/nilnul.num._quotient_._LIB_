using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.op_;
using nilnul.num.quotient.op_.binary_;

namespace nilnul.num.quotient.expr_.closed_.call_
{


	public class Binary :
		nilnul.obj.expr_.closed_.call_.Binary<nilnul.num.QuotientI1>
		,
		CallI
	{
		public Binary(BinaryI2 op, ClosedI arg,ClosedI arg1) : base(op, arg,arg1)
		{
		}


		public Binary(BinaryI2 op, int x, ClosedI y):this(op, new nilnul.num.quotient.expr_.closed_.call_.Nary(x) ,y)
		{
		}

		public Binary(obj.op_.BinaryI<QuotientI1> op, obj.expr_.ClosedI<QuotientI1> arg, obj.expr_.ClosedI<QuotientI1> arg1) : base(op, arg, arg1)
		{
		}

		static public Binary OvDiv(ClosedI x, ClosedI y) {
			return new Binary(
				nilnul.num.quotient.op_.binary_.Div1.Singleton
				,
				x,y
			);
		}
		static public Binary OvAdd(ClosedI x, ClosedI y) {
			return new Binary(
				nilnul.num.quotient.op_.binary_.Add.Singleton
				,
				x,y
			);
		}

		static public Binary OvDiv(int x, ClosedI y) {
			return new Binary(
				nilnul.num.quotient.op_.binary_.Div1.Singleton
				,
				x,y
			);
		}
		static public Binary OvAdd(int x, ClosedI y) {
			return new Binary(
				nilnul.num.quotient.op_.binary_.Add.Singleton
				,
				x,y
			);
		}

		public static Binary OvDiv(int v, nilnul.num.quotient.expr_.closed_.Variable x)
		{
			return OvDiv(
				v, 
				(ClosedI)(x)
			);
		}
		public static Binary OvAdd(int v, nilnul.num.quotient.expr_.closed_.Variable x)
		{
			return OvAdd(
				v, 
				(ClosedI)(x)
			);
		}

		public static Binary OvDiv(int v, Var x)
		{
			return OvDiv(
				v, 
				new nilnul.num.quotient.expr_.closed_.Variable(x)
			);
		}
		public static Binary OvAdd(int v, Var x)
		{
			return OvAdd(
				v, 
				new nilnul.num.quotient.expr_.closed_.Variable(x)
			);
		}


	}
}
