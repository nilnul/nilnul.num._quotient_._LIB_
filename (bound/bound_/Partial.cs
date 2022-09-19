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
	///		per
	/// </remarks>
	public class Partial : Bound1
	{
		

		public Partial() : base(new _bound.lower_.Open(), new _bound.upper_.Open(1))
		{
		}
	}
}
