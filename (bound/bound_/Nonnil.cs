using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.range.be_.nonnil.vow;

namespace nilnul.num.quotient.range_
{
	public interface NonnilI
	{
		nilnul.num.quotient.range.be_.nonnil.vow.En nonnil { get; }

	}
	public class Nonnil :
		nilnul.num.quotient.range.be_.nonnil.vow.En
		,
		NonnilI
	{
		public Nonnil(Range1 val) : base(val)
		{
		}

		public En nonnil => this;
	}
}
