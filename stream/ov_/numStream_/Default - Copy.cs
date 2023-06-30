using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream.ov_.numStream_
{
	public  class DefaultNew<T> : NumStream1 // Ov<nilnul.num.StreamI4>
		where T: nilnul.num.StreamI6,new()
	{
		public DefaultNew() : base( new T())
		{
		}

	
	}


}
