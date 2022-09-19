using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.convergent
{
	/// <summary>
	///  given a convergent, keeping squeeze till a bound spanning lt give positive.
	/// </summary>
	public interface ConvergingI:_converging_.SqueezeI, _converging_.BoundI
	{

	}
}
