using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.slider_._properGeneralContinuedFrac
{


	public class ConvergentNumerators 
	{
		private SliderI _denominators;

		public SliderI denominators
		{
			get { return _denominators; }
			set { _denominators = value; }
		}

		private SliderI _numerators;

		public SliderI numerators
		{
			get { return _numerators; }
			set { _numerators = value; }
		}





		private Q1 _prev = 1;

		public Q1 prev
		{
			get { return _prev; }
			set { _prev = value; }
		}




		private Q1 _current=0;


		public Q1 current
		{
			get
			{
				return _current;

			}
		}

		public ConvergentNumerators(
			SliderI denominators,
			SliderI numerators

		)
		{
			_denominators = denominators;
			_numerators = numerators;

			//_current = _floors.current;

		}



		public void moveNext()
		{

			var next = _denominators.current * _current + _numerators.current * _prev;

			_prev = _current;
			_current = next;


		}
	}
}
