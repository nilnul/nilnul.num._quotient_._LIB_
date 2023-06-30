using nilnul.num.quotient_.nonneg_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_.floaty
{
	/// <summary>
	/// by nonneg recur;
	/// </summary>
	public class Recur
		:
		nilnul.obj.Box_ofIn<quotient_.nonneg_.radix_.floaty.Recur>
		,
		quotient_.radix.Recur8unsignedI
	{
		private bool _negated;

		public bool negated
		{
			get { return _negated; }
			set { _negated = value; }
		}

		public quotient_.nonneg_.radix_.floaty.Recur unsignedFloatyRecur => boxed;

		public RecurI unsigned => boxed;

		public Recur(in nonneg_.radix_.floaty.Recur val, bool negated=false) : base(val)
		{
			_negated = negated;
		}

		public Recur(nonneg_.radix_.floaty.Recur x,bool negated=false) : this(in x,negated)
		{
		}
		public Recur(nonneg_.radix_.Floaty unsigned1, BigInteger cycle, bool negated=false):this(
			new nonneg_.radix_.floaty.Recur(unsigned1,cycle)
			,
			negated
		)
		{
		}

		public Recur(Floaty floaty, BigInteger cycle)
			:this(
				floaty.unsigned8floaty
				 ,cycle
				 ,floaty.negated
			)
		{
		}

		public Recur(nonneg_.radix_.floaty.Recur x) : this(x,false)
		{
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
