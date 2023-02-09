using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using B = nilnul.num.quotient_.denomNonnil.BorderI;

namespace nilnul.num.quotient_.denomNonnil.border_.lower
{
	public  class Comp
		:
		nilnul.obj.border_.lower.comp_.ObjCompDefault<quotient_.DenomNonnilI
			,
			nilnul.obj.BorderI<nilnul.num.quotient_.DenomNonnilI>
			//_bound.BorderI_nonnilDenom
			,
			num.quotient_.denomNonnil.Comp
		>
		,
		IComparer<BorderI>
		,
		IComparer<
			nilnul.obj.BorderI< nilnul.num.quotient_.DenomNonnilI>
		>

	{

		public int Compare(B x, B y)
		{
			return base.Compare(x, y);
		}

		static public Comp Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comp>.Instance;
			}
		}

	}
}
