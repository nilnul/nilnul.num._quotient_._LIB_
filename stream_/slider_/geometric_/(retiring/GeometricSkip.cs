using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider_
{
	[Obsolete()]
	public class GeometricSkip:SliderI,_geometric_.MultiplierI
	{
		private Simplify.Ed1 _multiplier;
		public Simplify.Ed1 multiplier { get { return _multiplier; } }

		public GeometricSkip(Simplify.Ed1 multiplier)
		{
			_multiplier = multiplier;
			_current = multiplier;
		}
		private Simplify.Ed1 _current ;
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
