using nilnul.num.quotient._bound_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.bound_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// <seealso cref="nameof(Proportion)"/>
	/// seealso:
	///		partial
	///		ratio
	///		ration
	/// </remarks>
	class Portion : Bound1
	{
		

		public Portion() : base(new _bound.lower_.Closed(), new _bound.upper_.Open(1))
		{
		}
	}
}
