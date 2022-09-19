using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.obj.stream_._slider._cursor_;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream_.slider.headed
{
	public class PairedByAdd :
		num.quotient.stream_.slider.op_.unary_.batch_._pair.PairedByAdd

		,
		num.quotient.stream_.SliderI1

	{
		public PairedByAdd(Prepended val) : base(val)
		{
		}
		public PairedByAdd(num.quotient.stream_.SliderI1 arg) : this(new Prepended(arg))
		{

		}


	
	}

	public class PairedByAdd_ofNew<T> :
		PairedByAdd
		where T : num.quotient.stream_.SliderI1, new()
	{
		public PairedByAdd_ofNew() : base(new T())
		{
		}

	}



}
