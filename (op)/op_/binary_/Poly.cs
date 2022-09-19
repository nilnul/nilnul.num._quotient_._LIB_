using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.op_.binary_
{
	public class Poly
		:
		nilnul.num.quotient.op_.BinaryA,

		nilnul.num.quotient.op_.BinaryI2
	{
		public override Quotient1 op(Quotient1 par, Quotient1 par1)
		{

			return nilnul.num.quotient.op_.unary_.Poly.Op(par, new nilnul.num.quotient_.Natural(par1) );
			;
		}


		static public Poly Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Poly>.Instance;
			}
		}



	}
}
