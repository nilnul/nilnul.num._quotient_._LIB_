using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_
{

	/// <summary>
	/// div by nil exception is a subtype of quotient. We defer the exception inside this.
	/// </summary>
	public interface IDenomNilable
		:nilnul.num.IQuotient
	{
	}
}
