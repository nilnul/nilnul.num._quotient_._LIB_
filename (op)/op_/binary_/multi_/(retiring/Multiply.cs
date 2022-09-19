using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.combine_
{
	[Obsolete(nameof(op_.binary_.Multi))]
	 public class Multiply 
	:CombineI
	{

		static private readonly Multiply _Instance = new Multiply();

		static public Multiply Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Multiply()
		{
		}
				

	

		public override string ToString()
		{
			return "*";
		}

		public Simplify.Ed1 eval(Simplify.Ed1 arg, Simplify.Ed1 arg1)
		{

			return arg * arg1;
		}
	}

	
}
