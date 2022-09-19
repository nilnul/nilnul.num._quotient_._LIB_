﻿using nilnul.objs_.headed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnilEs_.headed.to_.scalar_
{
	 public class Min
		:
		to_.ScalarI
		,
		denomNonnilEs.to_.ScalarI
	{


		public Quotient_NonnilDenom to(IEnumerable<Quotient_NonnilDenom> src)
		{
			return src.Aggregate(
				nilnul.num.quotient.op_.binary_.Min.Singleton.op
			);
		}

		public Quotient_NonnilDenom to((Quotient_NonnilDenom, IEnumerable<Quotient_NonnilDenom>) src)
		{
			return to(
				src.AsSeq()
			);

		}


		static public Min Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Min>.Instance;
			}
		}


	}
}
