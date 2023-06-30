using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream.ov_.numStream_
{
	[Obsolete()]
	public class Default<T> : NumStream // Ov<nilnul.num.StreamI4>
		where T: nilnul.num.StreamI4,new()
	{
		public Default() : base( new T())
		{
		}

	
	}


}
