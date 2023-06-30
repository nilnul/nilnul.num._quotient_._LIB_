using nilnul.num.quotient_;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be.vow_
{
	/// <summary>
	/// for denom nonnil;
	/// </summary>
	/// <typeparam name="TBe"></typeparam>
	public class BeDefault<TBe>
		: quotient.be.Vow4DenomNonnil
		
		where TBe: nilnul.obj.BeI_ofIn<DenomNonnilI>,new()
	{
		public BeDefault() : base(
			 nilnul._obj.typ_._UnisonX<TBe>.Unison
		)
		{
		}


		static public BeDefault<TBe> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<BeDefault<TBe>>.Unison;
			}
		}


	}

}
