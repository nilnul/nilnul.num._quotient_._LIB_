using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._slider_;
using nilnul.obj.stream_._slider._cursor_;
using Q1 = nilnul.num.QuotientI;


namespace nilnul.num.quotient
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// In comparison with Stream, the current of slider has no side-effect when invoked. that is, current, with respect to "next()" is idempotent.
	/// </remarks>
	///
	[Obsolete()]
	public interface SliderI2
		:nilnul.obj.SliderI< nilnul.num.Quotient1>
	{

	}

	[Obsolete()]

	public abstract class SliderA : SliderI2
		,SliderI1
	{

		public abstract Quotient1 current { get; }

		Q1 obj.stream_._slider._cursor_.CurrentI<Q1>.current => current;

		public abstract void moveNext();
	}

	static public class SliderX
	{
		static public nilnul.num.quotient.StreamI6 AsStream(this SliderI2 slider) {
			return new nilnul.num.quotient.slider.Stream1(slider);
		}
	}


}
