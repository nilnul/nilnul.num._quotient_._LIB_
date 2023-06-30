using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.stream_.slider_
{

	/// <summary>
	/// </summary>
	public abstract class PeekA
		:
		nilnul.num.quotient_.denomNonnil.stream_.SliderA
		,

		nilnul.obj.stream_.slider_.PeekI<DenomNonnil>
	{
		public abstract DenomNonnil ahead { get; }
	}

}
