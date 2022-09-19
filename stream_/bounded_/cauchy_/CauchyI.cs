using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.bound_.cauchy_

{
	

	public abstract class Slider:CauchyA
	{
		private quotient.SliderI2 _slider;

		public quotient.SliderI2 slider
		{
			get { return _slider; }
			set { _slider = value; }
		}

		public Slider(quotient.SliderI2 slider)
		{
			_slider = slider;
		}

		public override Quotient1 next()
		{
			 _slider.moveNext();
			return _slider.current;
		}
	}
}
