using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.bound_

{
	/// <summary>
	/// you can get the bound to predict that next(), in other words, next() will fall in the bound
	/// </summary>
	/// 
	public interface CauchyI:
		nilnul.num.quotient.stream_.BoundI
		,
		_cauchy_.ClampI
	{

	}

	public abstract class CauchyA: _cauchy_.ClampA
		,CauchyI
	{
		
	}

}
