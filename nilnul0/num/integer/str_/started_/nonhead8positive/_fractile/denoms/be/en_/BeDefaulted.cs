using nilnul.obj;
using nilnul.obj.be.vow_.xpN_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_._fractile.denoms.be.en_
{
	public class BeDefaulted<TBe>
		: denoms.be.En
		where TBe : denoms.BeI, new()
	{

		public BeDefaulted(Denoms obj) : base(obj, nilnul.obj_.Singleton<TBe>.Instance)
		{
		}
	}
}
