using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.slider
{
	/// <summary>
	/// multiply each member
	/// </summary>
	public class Stretched:SliderI
	{
		private Q1 _stretcher;

		public Q1 stretcher
		{
			get { return _stretcher; }
	//		set { _stretcher = value; }
		}

		private SliderI _slider;

		public SliderI slider
		{
			get { return _slider; }
//			set { _geometric = value; }
		}

		public Stretched(Q1 stretcher, SliderI slider )
		{
			_stretcher = stretcher;
			_slider = slider;
		}

		public Q1 current
		{
			get
			{
				return _stretcher * _slider.current;
			}
		}

		public void moveNext()
		{
			_slider.moveNext();

		}
	}
}
