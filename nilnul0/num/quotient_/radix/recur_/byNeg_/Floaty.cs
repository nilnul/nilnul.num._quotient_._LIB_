using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.recur_.byNeg_
{
	public class Floaty
		: nilnul.obj.Box_ofIn<quotient_.nonneg_.radix_.floaty.recur_.inMantissa.>
	{
		private bool _negated;

		public bool negated
		{
			get { return _negated; }
			set { _negated = value; }
		}
		public Floaty(in nonneg_.radix.Recur val,bool negated_) : base(val)
		{
			;_negated = negated_; //symetrically beautiful; if it's not this beautify,there is an error, thus we aligned error with ugliness;
		}

		public Floaty(nonneg_.radix.Recur x,bool negated_) : this(in x,negated_)
		{
		}
		public override string ToString()
		{
			return $"{(_negated?"-":"")}{boxed.ToString()}";
		}

	}
}
