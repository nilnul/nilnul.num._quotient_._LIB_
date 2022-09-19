using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream_.slider.op_.unary_._inv
{
	public class Ret : nilnul.num.quotient.stream_.slider.op_._unary.Ret_ofOp
		,num.quotient.stream_.SliderI1
	{
		public Ret(num.quotient.stream_.SliderI1 arg) : base(arg, nilnul.num.quotient.op_.unary_.Inverse.Singleton)
		{
		}

	}

	public class Ret_ofNew<T> :
		Ret
		where T: num.quotient.stream_.SliderI1,new()
	{
		public Ret_ofNew() : base(new T())
		{
		}

	}



}
