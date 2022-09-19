using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.slider_.fro_
{
	/// <summary>
	/// from natural slider
	/// </summary>
	/// 
	public class Natural1 : SliderI2
	{
		nilnul.num.SliderI2 _slider;
		public Natural1(nilnul.num.SliderI2 natural)
		{
			_slider = natural;
		}
		public Q1 current
		{
			get
			{

				return _slider.current;
				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			_slider.moveNext();

			//throw new NotImplementedException();
		}

//		static public implicit operator Natural(nilnul.num.SliderI slider) {
//			return new Natural(slider);

//}
	}
}
