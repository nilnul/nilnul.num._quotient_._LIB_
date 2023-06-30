using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.stream_
{

	/// <summary>
	/// implemented stream using members of slider. stream.next is upon slider members
	/// </summary>
	public abstract class SliderA
		:
		nilnul.obj.stream_.SliderA<DenomNonnil>
		,
		nilnul.num.quotient_.denomNonnil.stream_.SliderI
	{

		//public abstract DenomNonnil current { get; }

		//public abstract void moveNext();

		//public DenomNonnil next()
		//{
		//	return nilnul.obj.stream_._slider.CursorX.Next(this);

		//	//var old = current;
		//	//moveNext();
		//	//return old;
		//}
	}

}
