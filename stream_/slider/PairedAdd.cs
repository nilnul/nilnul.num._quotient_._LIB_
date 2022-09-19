using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.obj.stream_._slider._cursor_;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream_.slider.op_.unary_.batch_._pair
{
	public class PairedByAdd :
		nilnul.obj.Box<num.quotient.stream_.slider.MemPrev>

		,
		num.quotient.stream_.SliderI1

	{
		public PairedByAdd(MemPrev val) : base(val)
		{
		}
		public PairedByAdd(num.quotient.stream_.SliderI1 arg) : this(new MemPrev(arg))
		{


		}


		public  Q0 current => boxed.prev+boxed.current;

	

		public  void moveNext()
		{
			boxed.moveNext();
		}

		public Q0 next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
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
