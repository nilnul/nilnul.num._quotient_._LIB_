using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.bound_.cauchy_._slider_
{

	public abstract class Generic<T>:CauchyA
		where T:quotient.SliderI2
	{
		private T _slider;

		public T slider
		{
			get { return _slider; }
			set { _slider = value; }
		}

		public Generic(T slider)
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
