using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
using Q1 = nilnul.num.QuotientI;


namespace nilnul.num.quotient.stream
{
	public class Take
		: nilnul.obj.stream.Take<Q1>
	{
		public Take(nilnul.obj.StreamI<Q1> stream, NumI count) : base(stream, count)
		{
		}
	}
}