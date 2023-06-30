using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.be
{
	public partial class Bounded
		:nilnul.bit.Be<Accuracy>
		

	{
		static public bool Be(Accuracy accuracy) {

			return!( accuracy.lower     is null )  &&!( accuracy.upper     is null ) ;

			throw new NotImplementedException();
		}
		public Bounded()
			:base(Be)
		{


		}




	}
}
