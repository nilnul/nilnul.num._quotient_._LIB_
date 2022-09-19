using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.var
{
	public interface SetI:nilnul.obj.var.SetI2< nilnul.num.QuotientI1, nilnul.num.quotient.VarI>
	{
	}

	public class Set : nilnul.obj.var.Set2<nilnul.num.QuotientI1, nilnul.num.quotient.VarI>
		, SetI
	{
		public Set()
		{
		}

		public Set(IEnumerable<VarI> vars) : base(vars)
		{
		}
	}
}
