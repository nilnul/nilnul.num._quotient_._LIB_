using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream.cauchy
{
	/// <summary>
	/// this is pi.
	/// </summary>
	public class Pi_4OddAlterUnit:nilnul.num.quotient.stream.duo.op.call.Multi
	{
		public Pi_4OddAlterUnit()
			:base(
				4
				 ,
				new quotient.stream.op.MakeSeries.CallAsStream_ofStream3(
					new stream.eg.AlterOddUnit()
				) 
			 )
		{

		}
	}
}
