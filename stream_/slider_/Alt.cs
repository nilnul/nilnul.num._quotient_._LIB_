using nilnul.bit.stream_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider_
{
	/// <summary>
	/// eg:
	///		0,0,0
	///		1,-1,+0,0,+0,-2,1,-0,+0,-0,1
	/// </summary>
	public interface IAlt
	{

	}

	public class Alt
		:
		nilnul.obj.Box1<nilnul.bit.stream_.slider_.Alter>
		,
		num.quotient.stream_.SliderI1
		,
		IAlt
	{
		private nilnul.num.quotient_.nonneg.stream_.SliderI _nonnegs;

		public nilnul.num.quotient_.nonneg.stream_.SliderI nonnegs
		{
			get { return _nonnegs; }
			set { _nonnegs = value; }
		}

		public Quotient1 current => boxed.current? _nonnegs.current.vowed.en: -_nonnegs.current.vowed.en;

		public Alt(
			nilnul.bit.stream_.slider_.Alter val
			,
			nilnul.num.quotient_.nonneg.stream_.SliderI nonnegs
		) : base(val)
		{
			_nonnegs = nonnegs;
		}


		public Alt(
			nilnul.num.quotient_.nonneg.stream_.SliderI nonnegs
		) : this(new bit.stream_.slider_.Alter(), nonnegs)
		{
		}


		public Quotient1 next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
			//throw new NotImplementedException();
		}

		public void moveNext()
		{
			boxed.moveNext();
			_nonnegs.moveNext();
			//throw new NotImplementedException();
		}
	}
}
