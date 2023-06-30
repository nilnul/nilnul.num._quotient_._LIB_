using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using B = nilnul.num.quotient_.denomNonnil._range.BorderI;

namespace nilnul.num.quotient_.denomNonnil._range.border_.lower
{
	public  class Comp
		:
		nilnul.obj.border_.lower.comp_.ObjCompDefault<quotient_.DenomNonnil
			,
			nilnul.obj.BorderI<nilnul.num.quotient_.DenomNonnil>
			//_bound.BorderI_nonnilDenom
			,
			num.quotient_.denomNonnil.Comp
		>
		,
		IComparer<BorderI>
		,
		IComparer<
			nilnul.obj.BorderI< nilnul.num.quotient_.DenomNonnil>
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
