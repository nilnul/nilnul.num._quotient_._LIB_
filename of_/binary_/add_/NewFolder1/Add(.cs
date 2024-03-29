﻿using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient_;

namespace nilnul.num.quotient.op_.binary_
{
	[Obsolete(nameof(of_.binary_.Add))]
	 public class Add 
	:
		BinaryA,
		BinaryI1
		,
		quotient_.denomNonnil.of_.Binary4interfaceI
	{
	

		public override string ToString()
		{
			return "+";
		}

		public override nilnul.num.Quotient1 op(nilnul.num.Quotient1 a, nilnul.num.Quotient1 b)
		{

			return _AddX.Op(a,b);

		}

		public DenomNonnil opAsImpl(DenomNonnilI arg, DenomNonnilI arg1)
		{
			return new nilnul.num.quotient_.DenomNonnil(
				arg.numerator * arg1.denominator + arg.denominator * arg1.numerator
				,
				
				arg.denominator * arg1.denominator
				
			);

		}
		public DenomNonnilI op(DenomNonnilI arg, DenomNonnilI arg1)
		{
			return opAsImpl(arg,arg1);

		}

		static public Add Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Add>.Instance;
			}
		}


	}

	
}
