using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient._bound;
using nilnul.num.quotient._bound_;
using nilnul.num.quotient.border;
using nilnul.num.quotient_;
using Q1 = nilnul.num.Quotient1;
using Qi = nilnul.num.QuotientI;

namespace nilnul.num.quotient
{
	public class Bound1 : _bound_.lowerUpper.be_.dwelt.vow.Ee
		,_bound_.LowerUpperI
	{
		public Bound1(LowerUpperI val) : base(val)
		{
		}

		public Bound1(_bound.lower_.Closed lower1, _bound.upper_.Closed upper1):this( new LowerUpper(lower1, upper1))
		{
		}

		public Bound1(_bound.LowerI lower1, _bound.UpperI upper1):this( new LowerUpper(lower1, upper1))
		{
		}

		public Lower lower => ee.lower;

		public Upper upper => ee.upper;
	}

	[Obsolete(nameof(Bound1))]
	public interface BoundI1
		:_bound_.LowerI
		,
		_bound_.UpperI
	{
		bool isSingleton { get; }
		nilnul.num.quotient_.Nonneg diameter { get; }

		bool contains(Q1 ext);
		bool containsZero();
		bool isClosed();
		bool isDiameterLt(quotient_.Positive1 diameter);
		bool isNil();
		bool isNotDiameterLt(quotient_.Positive1 diameter);
		bool notContainsZero();
		bool notCapacityLt(quotient_.Positive1 diameter);
		bool capacityLt(quotient_.Positive1 diameter);
	}



}