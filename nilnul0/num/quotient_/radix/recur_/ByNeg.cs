using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.recur_
{
	public class ByNeg
		: nilnul.obj.Box_ofIn<quotient_.nonneg_.radix.Recur>
		,
		radix.RecurI
		,
		radix.Recur8unsignedI
	{
		private bool _negated;

		public bool negated
		{
			get { return _negated; }
			set { _negated = value; }
		}

		public Radix3 radix => quotient_.radix.to_._RegressionX.ToRadix3(boxed.radix, _negated);

		public Num_ofIn period => boxed.period;

		public nonneg_.radix.RecurI unsigned =>boxed;

		public ByNeg(in nonneg_.radix.Recur val,bool negated_=false) : base(val)
		{
			;_negated = negated_; //symetrically beautiful; if it's not this beautify,there is an error, thus we aligned error with ugliness;
		}

		public ByNeg(nonneg_.radix.Recur x,bool negated_=false) : this(in x,negated_)
		{
		}
		public ByNeg(nonneg_.radix.RecurI x,bool negated_ = false)
			:
			this(
				nonneg_.radix.Recur.Of(x)
				,
				negated_
			)
		{
		}

		public ByNeg(nonneg_.RadixI unsigned1, BigInteger recurSpanAsBigInt, bool negated)
			:this(
			new nonneg_.radix.Recur(unsigned1,recurSpanAsBigInt)
				 ,
			negated
		)
		{
		}

		public override string ToString()
		{
			return recur._PhraseX.Phrase(this);
			//return $"{(_negated?"-":"")}{boxed.ToString()}";
		}
		public  string phrase8noncollapse()
		{
			return recur.phrase_._DwellIntX.Phrase(this);
			//return $"{(_negated?"-":"")}{boxed.ToString()}";
		}


	}
}
