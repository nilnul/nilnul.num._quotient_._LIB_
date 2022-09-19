using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_
{
	public interface SliderI1 :nilnul.num.quotient.StreamI6,
		nilnul.obj.stream_.SliderI<nilnul.num.Quotient1>
		{ }

	/// <summary>
	/// implemented stream using members of slider. stream.next is upon slider members
	/// </summary>
	public abstract class SliderA1
		: nilnul.num.quotient.stream_.SliderI1
	{
		public abstract Quotient1 current { get; }

		public abstract void moveNext();

		public Quotient1 next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);

			//var old = current;
			//moveNext();
			//return old;
		}
	}
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete()]
	public  class Slider1 : nilnul.obj.Box< nilnul.num.quotient.SliderI2>, nilnul.num.quotient.StreamI6
	{
		public Slider1(SliderI2 val) : base(val)
		{
		}

		public Quotient1 next()
		{

			var old = boxed.current;
			boxed.moveNext();
			return old;
		}
	}
}
