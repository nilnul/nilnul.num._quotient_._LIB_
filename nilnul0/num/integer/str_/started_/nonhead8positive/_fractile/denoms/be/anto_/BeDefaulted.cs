using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive._fractile.denoms.be.anto_
{
	public class BeDefaulted<TBe>
		: denoms.be.Anto
		where TBe : denoms.BeI, new()
	{
		public BeDefaulted() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}



		static public BeDefaulted<TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefaulted<TBe>>.Instance;
			}
		}

	}
}
