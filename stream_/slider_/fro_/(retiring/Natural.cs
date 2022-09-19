using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider_.fro_
{
	/// <summary>
	/// from natural slider
	/// </summary>
	/// 
	[Obsolete()]
	public class Natural : SliderI
	{
		nilnul.num.SliderI _slider;
		public Natural(nilnul.num.SliderI natural)
		{
			_slider = natural;
		}
		public Simplify.Ed1 current
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
