using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.co.be.vow_
{
	public class BeDefault<TBe>
		:
		quotient.co.be.Vow
		where TBe:nilnul.obj.BeOfRefI<(Quotient_unsimplified,Quotient_unsimplified)>,new()
	{
		
		public BeDefault() : base(

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance

		)
		{
		}

		static public BeDefault<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault<TBe>>.Instance;
			}
		}

	}
}
