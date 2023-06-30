using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream.series_
{

	/// <summary>
	/// this converges to Pi/4
	/// </summary>
	public class AlterOdd_Inverse:Series
	{
		public AlterOdd_Inverse():base(new stream_.AlterOdd_Inversed())
		{

		}
	}
}
