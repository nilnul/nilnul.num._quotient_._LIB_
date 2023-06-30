using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_
{
	/// <summary>
	/// simplifed <see cref="IFrac"/>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <seealso cref="num.quotient_.IStd"/>
	public interface IRational
		:nilnul.num.quotient_.IFrac
		//.IQuotient
		,
		quotient_.frac_.IRational
	{
	}
}
