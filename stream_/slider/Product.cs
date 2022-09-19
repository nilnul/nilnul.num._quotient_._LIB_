using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.slider
{
	[Obsolete(nameof(quotient.stream_.slider.cumulus_.Multi))]
	public class Product
		:_series_.AllI
		
	{
		private SliderI _slider;



		public Product(SliderI slider)
		{
			_slider = slider;
		}

		private Q1 _accumulated = 1;

		public Q1 current
		{
			get
			{
				return _accumulated;
				//throw new NotImplementedException();
			}
		}

		public Q1 nextAccumulant
		{
			get
			{
				return _slider.current;
				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			_accumulated *= _slider.current;
			_slider.moveNext();

			//throw new NotImplementedException();
		}
	}
}
