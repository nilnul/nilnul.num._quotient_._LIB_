using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider_
{
	/// <summary>
	/// the first one is 1.
	/// </summary>
	/// <remarks>
	/// Performance: binary divide and conquer for power expression evaluation.
	/// </remarks>
	public class GeometricStandard:SliderI,_geometric_.MultiplierI
	{
		private Simplify.Ed1 _multiplier;
		public Simplify.Ed1 multiplier { get { return _multiplier; } }

		public GeometricStandard(Simplify.Ed1 multiplier)
		{
			_multiplier = multiplier;
		}
		private Simplify.Ed1 _current = 1;
		public Simplify.Ed1 current
		{
			get
			{
				return _current;
				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			_current *= _multiplier;
			//throw new NotImplementedException();
		}
	}
}
