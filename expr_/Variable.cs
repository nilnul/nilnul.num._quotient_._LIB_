using nilnul.obj._expr_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.expr_
{
	public class Variable1 :
		
		nilnul.num.quotient.IExpr
	{
		private System.Linq.Expressions.ParameterExpression _par;

		public System.Linq.Expressions.ParameterExpression par
		{
			get { return _par; }
			set { _par = value; }
		}

		public Variable1(System.Linq.Expressions.ParameterExpression par)
		{
			if (par.Type == typeof(nilnul.num.QuotientI1))
			{
				_par = par;
			}
			throw new UnexpectedTypeException();
		}

	}
}
