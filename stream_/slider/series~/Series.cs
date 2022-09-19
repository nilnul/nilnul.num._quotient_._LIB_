using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.slider
{
	/// <summary>
	/// the start element of the series is 0.
	/// the runner-up element of the series is the start element of the slider
	/// </summary>
	public class Series1
		:nilnul.obj.Box<nilnul.num.quotient.SliderI2>
		, slider.SeriesI
	{

		private Q1 _current=0;

		public Q1 current
		{
			get
			{
				return _current;
				//throw new NotImplementedException();
			}
		}

		

		public Q1 nextAugend
		{
			get
			{
				return boxed.current;
				//throw new NotImplementedException();
			}
		}

		public Series1(SliderI2 slider):base(slider)
		{

		}

		public void moveNext()
		{
			_current += nextAugend;

			boxed.moveNext();

			//throw new NotImplementedException();
		}
	}
}
