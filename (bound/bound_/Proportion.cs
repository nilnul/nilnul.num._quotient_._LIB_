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
	public class Proportion : Bound1
	{


		public Proportion() : base(new _bound.lower_.Open(), new _bound.upper_.Closed(1))
		{
		}
	}
}
