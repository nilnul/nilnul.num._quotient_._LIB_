using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream_.slider.series
{
	public class Paired : nilnul.obj.Box<num.quotient.stream_.slider.Series>
		,

	{
		public Paired(num.quotient.stream_.slider.Series arg) : base(arg)
		{

		}

		

		
	}

	public class Ret_ofNew<T> :
		Paired
		where T: num.quotient.stream_.SliderI1,new()
	{
		public Ret_ofNew() : base(new T())
		{
		}

	}



}
