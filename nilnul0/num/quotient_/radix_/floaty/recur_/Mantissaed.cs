using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_.floaty.recur_
{
	/// <summary>
	/// </summary>
	/// alias:
	///		mantissaed
	///		mantis
	///		properly
	///			which is already taken by, <see cref="quotient_.IProper"/>
	public class Mantissaed
		:
		nilnul.obj.Box_ofIn<quotient_.nonneg_.radix_.floaty.recur_.Mantissaed>
		,
		quotient_.radix.Recur8unsignedI
	{
		private bool _negated;

		public bool negated
		{
			get { return _negated; }
			set { _negated = value; }
		}
		public quotient_.nonneg_.radix_.floaty.recur_.Mantissaed nonnegRecurMantissaed => boxed;

		public nonneg_.radix.RecurI unsigned => boxed;

		public quotient_.nonneg_.radix_.floaty.recur_.Mantissaed unsigned8mantissaed => boxed;

		public Mantissaed(in nonneg_.radix_.floaty.recur_.Mantissaed val, bool negated=false) : base(val)
		{
			_negated = negated;
		}

		public Mantissaed(nonneg_.radix_.floaty.recur_.Mantissaed x,bool negated=false) : this(in x,negated)
		{
		}

		public Mantissaed(nonneg_.radix_.floaty.recur_.Mantissaed x) : this(x,false)
		{
		}

		public override string ToString()
		{
			var t = boxed.ToString();

			return $"{(_negated?"-":"")}{t}";
		}
		public string phrase8decollapse()
		{
			var t = boxed.phrase8decollapse();

			return $"{(_negated?"-":"")}{t}";
		}

	}
}
