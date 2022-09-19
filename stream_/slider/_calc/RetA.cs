using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.stream_.slider._calc
{
	public abstract class ArgA
		:
		nilnul.obj._call_.ArgA<nilnul.num.quotient.stream_.SliderI1>
		,
		quotient.stream_.SliderI1
		
	{
		public ArgA(nilnul.num.quotient.stream_.SliderI1 arg) : base(arg)
		{
		}

		public abstract Quotient1 current { get; }

		public abstract void moveNext();
		public Quotient1 next() { return obj.stream_._slider.CursorX.Next(this); }
	}

	

}
