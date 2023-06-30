using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive._fractile.denoms
{

	public class Be :
		nilnul.obj.Be1<num.integer.str_.started_.nonhead8positive._fractile.Denoms>
		,
		BeI
	{
		public Be(Func<Denoms, bool> func) : base(func)
		{
		}

		public bool be(in Denoms val)
		{
			return base.func(val);
		}
	}
}
