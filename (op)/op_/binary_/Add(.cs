using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.op_.binary_
{
	 public class Add 
	:
		BinaryA,
		BinaryI1
	{
	

		public override string ToString()
		{
			return "+";
		}

		public override nilnul.num.Quotient1 op(nilnul.num.Quotient1 a, nilnul.num.Quotient1 b)
		{

			return _AddX.Op(a,b);

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
