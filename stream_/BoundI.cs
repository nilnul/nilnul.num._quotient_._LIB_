using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_

{
	/// <summary>
	/// you can get the bound to predict that next(), in other words, next() will fall in the bound
	/// </summary>
	/// 
	public interface BoundedI:
		nilnul.num.quotient.StreamI6, 
		nilnul.num.quotient.stream_._bounded_.BoundI
	{

	}
}
