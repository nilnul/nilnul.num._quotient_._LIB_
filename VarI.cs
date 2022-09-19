using nilnul.obj.var_._handled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient
{
	public interface VarI:nilnul.obj.var_.handled_.typed_.OvObjI<nilnul.num.QuotientI1>
	{

	}
	static public class _VarX
	{
		static public System.Linq.Expressions.ParameterExpression Create() {
			return  System.Linq.Expressions.Expression.Parameter(typeof(nilnul.num.QuotientI1));
		}
	}

	public class Var : nilnul.obj.var_.handled_.typed_.OvObj<nilnul.num.QuotientI1>, VarI
	{
		public Var()
			//:this(new Handle())
		{
		}

		protected Var(Handle val) : base(val)
		{
		}

		static public implicit operator Var(nilnul.num.var_.handled_.Typed typed) {
			return new Var(typed.handle);
		}
	}
}
