using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider_._cumulative
{
	/// <summary>
	/// connect stream and slider.
	/// </summary>
	public abstract class RetA
		:
		nilnul.obj._call_.ArgA<nilnul.num.quotient.StreamI5>
		,
		nilnul.num.quotient.SliderI1
	{
		public RetA(StreamI5 arg) : base(arg)
		{
		}
		public RetA(SliderI1 slider):this( new nilnul.num.quotient.stream_.Slider(slider))
		{

		}

		public abstract QuotientI current { get; }

		public abstract void moveNext();
	}
}
