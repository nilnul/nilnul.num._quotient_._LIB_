using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.quotient.slider_._properGeneralContinuedFrac;

namespace nilnul.num.quotient.slider_
{
	public class ProperGeneralContinuedFrac : SliderI
	{
		private _properGeneralContinuedFrac.ConvergentNumerators _converegentNumerators;

		public ConvergentNumerators converegentNumerators
		{
			get { return _converegentNumerators; }
			set { _converegentNumerators = value; }
		}

		private ConvergentDenominators _convergentDenominators;

		public ConvergentDenominators convergentDenominators
		{
			get { return _convergentDenominators; }
			set { _convergentDenominators = value; }
		}

		public Q1 current
		{
			get
			{
				return _converegentNumerators.current / _convergentDenominators.current;

			}
		}

		private SliderI _numerators;

		public SliderI numerators
		{
			get { return _numerators; }
			set { _numerators = value; }
		}

		private SliderI _denominators;

		public SliderI denominators
		{
			get { return _denominators; }
			set { _denominators = value; }
		}



		public ProperGeneralContinuedFrac(
			SliderI denominators
			,
			SliderI numerators
		)
		{
			_numerators = numerators;
			_denominators = denominators;

			_converegentNumerators = new _properGeneralContinuedFrac.ConvergentNumerators(denominators, numerators);
			_convergentDenominators = new _properGeneralContinuedFrac.ConvergentDenominators(denominators, numerators);
		}

		public void moveNext()
		{

			_converegentNumerators.moveNext();
			_convergentDenominators.moveNext();

			_numerators.moveNext();
			_denominators.moveNext();

			//throw new NotImplementedException();
		}
	}
}
