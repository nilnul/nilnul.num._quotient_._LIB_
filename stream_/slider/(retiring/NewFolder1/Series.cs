using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.slider
{
	[Obsolete(nameof(quotient.stream.Series1))]
	public class Series:num.quotient._series_.AccumulatedI, _series_.MoveNextI,num.quotient._series_.NextAugendI

	{
		private SliderI _slider;

		private Q1 _accumulated=0;

		public Simplify.Ed1 accumulated
		{
			get
			{
				return _accumulated;
				//throw new NotImplementedException();
			}
		}

		//public SliderI slider
		//{
		//	get { return _slider; }
		//	//set { _slider = value; }
		//}

		public Q1 nextAugend
		{
			get
			{
				return _slider.current;
				//throw new NotImplementedException();
			}
		}

		public Series(SliderI slider)
		{
			_slider = slider;

		}

		public void moveNext()
		{
			_accumulated += nextAugend;

			_slider.moveNext();

			//throw new NotImplementedException();
		}
	}
}
