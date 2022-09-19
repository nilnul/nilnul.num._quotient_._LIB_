using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg
{
	public interface IStream :nilnul.obj.IStream<nilnul.num.quotient_.NonnegI>
	{
	}

	public interface StreamI
		:
		nilnul.obj.StreamI2<nilnul.num.quotient_.NonnegI>
		,
		IStream
	{
	}




}
