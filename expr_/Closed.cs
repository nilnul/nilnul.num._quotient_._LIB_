using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.expr_
{
	/// <summary>
	/// all the involved exprs are of the same type paramemter-Quotient
	/// </summary>
	public interface IClosed
		:nilnul.obj.expr_.IClosed< nilnul.num.QuotientI1>
	{

	}

	[Obsolete(nameof(ClosedI) + " is the topmost type to use, and is a fixed point type. Types defined here heriting that type are for convenience only")]
	public interface ClosedI_ovTypes
		:nilnul.obj.expr_.ClosedI<
			nilnul.num.QuotientI1,
			nilnul.num.quotient.VarI,
			nilnul.num.quotient.var.SetI,
			ClosedI_ovTypes
		>
		,
		IClosed
	{

	}

	public interface ClosedI
		:nilnul.obj.expr_.ClosedI<
			nilnul.num.QuotientI1
		>
		,
		IClosed
	{

	}

	public class Closed :
		nilnul.obj.expr_.Closed< nilnul.num.QuotientI1>
		,
		ClosedI
	{
		public Closed(ClosedI arg) : base(arg)
		{
		}

		public Closed(obj.expr_.ClosedI<QuotientI1> val) : base(val)
		{
		}

		static public Closed operator +(Closed x, Closed y) {
			return new closed_.call_.Binary(
				nilnul.num.quotient.op_.binary_.Add.Singleton
				,
				x
				,
				y
			);
		}

		static public Closed operator /(Closed x, Closed y) {
			return new closed_.call_.Binary(
				nilnul.num.quotient.op_.binary_.Div1.Singleton
				,
				x
				,
				y
			);
		}


		static public Closed operator ^(Closed x, Closed y) {
			return new closed_.call_.Binary(
				nilnul.num.quotient.op_.binary_.Div1.Singleton
				,
				x
				,
				y
			);
		}


		static public Closed Ov(ClosedI x) {
			if (x is Closed c)
			{
				return c;
			}
			return new Closed(x);
		}

		static public implicit operator Closed(closed_.call_.Binary x) {
			return new Closed(x);
		}
	}

}
