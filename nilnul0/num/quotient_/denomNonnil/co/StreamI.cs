using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.co
{
	public interface IStream
		:nilnul.obj.IStream<(IQuotient,IQuotient)>
	{
	}

	public interface StreamI
		:nilnul.obj.StreamI2<(DenomNonnil,DenomNonnil)>
		,IStream
	{
	}


}
