using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_
{
	/// <summary>
	/// for standard Geometric, use nilnul.num.quotient.stream_.rigid.cumulus_.Multi
	/// </summary>
	public class Geometric : nilnul.num.quotient.stream._combine.ret_.Multi
	{

		public Geometric(
			nilnul.num.Quotient1 head
			,
			nilnul.num.Quotient1 rate) : base(
			new nilnul.num.quotient.stream_.Rigid(head)
			,
			new nilnul.num.quotient.stream_.rigid.cumulus_.Multi(rate)
		)
		{
		}

		
	}
}
