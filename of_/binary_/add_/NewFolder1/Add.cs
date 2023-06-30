using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.duo.op_
{
	[Obsolete(nameof(num.quotient.of_.binary_.Add))]
	public  class Add:
	OpI
	{

		static private readonly Add _Instance = new Add();
		static public Add Instance
		{
			get
			{
				return _Instance;
			}
		}
		public Add()
		{
		}
				
		

		




		

		public override string ToString()
		{
			return "+";
		}

		public Simplify.Ed1 eval(Simplify.Ed1 a, Simplify.Ed1 b)
		{
			return a + b;
			throw new NotImplementedException();
		}
	}
}
