﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.quotient_.DenomNonnilI;


namespace nilnul.num.quotient.vow.ee_
{
	public class VowDefault_nonnilDenom<TVow>
		:
		quotient.vow.Ee_nonnilDenom< TVow>
		where TVow : nilnul.obj.VowI_ofIn<Q1>, new()
	{
		public VowDefault_nonnilDenom(Q1 val)
			:
			base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
