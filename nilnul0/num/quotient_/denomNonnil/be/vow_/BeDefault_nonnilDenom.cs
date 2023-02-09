using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be.vow_
{
	public class BeDefault_nonnilDenom<TBe>
		:
		Vow_nonnilDenom
		where TBe : quotient.BeI_nonnilDenom, new()
	{
		public BeDefault_nonnilDenom() : base(
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{
		}


		static public BeDefault_nonnilDenom<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault_nonnilDenom<TBe>>.Instance;
			}
		}


	}
}
