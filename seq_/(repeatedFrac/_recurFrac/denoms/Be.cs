using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_._recurFrac.denoms
{
	public interface BeI:nilnul.obj.BeI1< num.quotient_._recurFrac.Denoms>
	{
	}

	public class Be :
		nilnul.obj.Be1<num.quotient_._recurFrac.Denoms>
		,
		BeI
	{
		public Be(Func<Denoms, bool> func) : base(func)
		{
		}
	}
}
