using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient
{

	

	[Obsolete()]
	public interface StreamI2 : nilnul.collection.recur.type.StreamI<Q> {

	}

	[Obsolete()]

	public interface StreamI1 : nilnul.collection.recur.type.StreamI<Q> , IEnumerable<Q>{

	}

	

	[Obsolete()]
	public interface StreamI :nilnul.num.type.StreamI<Q>
	{
	}
}
