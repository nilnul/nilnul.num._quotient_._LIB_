using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.stream_
{
	/// <summary>
	/// r, r*r, r*r*r,...
	/// note: start is r, not 1
	/// </summary>
	public class GeometricStandard:StreamI3
	{
		private Simplify.Ed1 _multiplier;

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

		

		public Simplify.Ed1 next()
		{
			return _current *= _multiplier;
			//throw new NotImplementedException();
		}
	}
}
