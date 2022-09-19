using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.QuotientI1;

namespace nilnul.num.quotient
{

	[Obsolete()]
	public interface IExpr
		: nilnul.obj.IExpr<
			nilnul.num.QuotientI1
		>
	{
	}

	/// <summary>
	/// a var, or a call.
	/// </summary>
	public interface IExpr1
		: nilnul.obj.expr_.typed_.IGeneri<
			nilnul.num.QuotientI1
		>
	{
	}


}
