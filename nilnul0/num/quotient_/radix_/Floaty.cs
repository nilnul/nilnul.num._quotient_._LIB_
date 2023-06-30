using nilnul.num.quotient_.nonneg_.radix.to_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_
{
	/// <summary>
	/// the indic indicates the floating point's index, which must be within the precision;
	/// </summary>
	public class Floaty
		:
		nilnul.obj.Box_ofIn<quotient_.nonneg_.radix_.Floaty>
		,
		Radix8unsignedI
	{
		private bool _negated;

		public bool negated
		{
			get { return _negated; }
			set { _negated = value; }
		}

		public nonneg_.RadixI unsigned => boxed;
		public quotient_.nonneg_.radix_.Floaty unsigned8floaty => boxed;


		public Floaty(in nonneg_.radix_.Floaty val, bool negated) : base(val)
		{
			_negated = negated;
		}

		public Floaty(nonneg_.radix_.Floaty x,bool negated) : this(in x,negated)
		{
		}

		public DenomNonnil toDenomNonnil()
		{
			var q = unsigned.ToDenomNonnil();

			return negated ? -q : q;

		}

		public override string ToString()
		{
			var t = boxed.ToString();

			return $"{(_negated?"-":"")}{t}";
		}
		public  string phrase8noncollapse()
		{
			var t = boxed.phrase8noncollapse();

			return $"{(_negated?"-":"")}{t}";
		}


	}
}
