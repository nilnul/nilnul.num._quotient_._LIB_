using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.bound_
{

	/// <summary>
	/// <seealso cref="nameof(Portion)"/>
	/// </summary>
	public class Prob : Bound1
	{


		public Prob() : base(new _bound.lower_.Closed(), new _bound.upper_.Closed(1))
		{
		}
	}
}
