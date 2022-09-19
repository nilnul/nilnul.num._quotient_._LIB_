using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient._bound.lower_;
using nilnul.num.quotient._bound.upper_;
using nilnul.num.quotient.bound.be_.closed.vow;
using nilnul.num.quotient_;
using Q1 = nilnul.num.Quotient1;


namespace nilnul.num.quotient.bound_
{
	public class Closed :
		nilnul.obj.Box<nilnul.num.quotient.bound.be_.closed.vow.En>
		,
		nilnul.num.quotient.BoundI
		,ClosedI
	{
		public Closed(En val) : base(val)
		{
		}

		public Closed(Bound bound):this(new En(bound))
		{
		}


		public Closed(Q1 border21, Q1 border22):this(
			new Bound(
				Border2.CreateClose( border21)
				,
				Border2.CreateClose(
					border22
				)
			)
		)
		{
		}

		public Closed(Q1 singleton):this(singleton,singleton)
		{

		}

		public num.Quotient1 midPoint {
			get {
				return (lower.mark +upper.mark)/ 2;
			}
		}

		public num.Quotient1 mid{
			get {
				return (lower.mark +upper.mark)/ 2;
			}
		}

		public Closed():this(0)
		{

		}

		public bool isSingleton =>boxed.en.isSingleton;


		public Nonneg diameter1 => boxed.en.diameter1;
		public Nonneg diameter => boxed.en.diameter1;

		//public Border2 upper => boxed.en.upper;
		//public Border2 lower => boxed.en.lower;

		public _bound.lower_.Closed lower => new _bound.lower_.Closed( boxed.en.lower.mark);

		public _bound.upper_.Closed upper =>  new _bound.upper_.Closed( boxed.en.upper.mark);

		Border2 BoundI.lower => lower;

		Border2 BoundI.upper => upper;

		public bool capacityLt(Positive1 diameter)
		{
			return boxed.en.capacityLt(diameter);
		}

		public bool contains(Q1 ext)
		{
			return boxed.en.contains(ext);
		}

		public bool containsZero()
		{
			return boxed.en.containsZero();
		}

		public bool isClosed()
		{
			return true;
		}

		public bool isDiameterLt(Positive1 diameter)
		{
			return boxed.en.isDiameterLt(diameter);
		}

		public bool isDiameterLe(Positive1 diameter)
		{
			return boxed.en.isDiameterLe(diameter);
		}

		public bool diameterLe(Positive1 diameter)
		{
			return boxed.en.isDiameterLe(diameter);
		}

		public bool isDiameterGt(Positive1 diameter)
		{
			return !isDiameterLe(diameter);
		}
		public bool diameterGt(Positive1 diameter)
		{
			return !diameterLe(diameter);
		}

		public bool notIsDiameterLe(Positive1 diameter)
		{
			return !isDiameterLe(diameter);
		}

		public bool isNil()
		{
			return boxed.en.isNil();
		}

		public bool isNotDiameterLt(Positive1 diameter)
		{
			return boxed.en.isNotDiameterLt(diameter);
		}

		public bool notCapacityLt(Positive1 diameter)
		{
			return boxed.en.notCapacityLt(diameter);
		}

		public bool notContainsZero()
		{
			return boxed.en.notContainsZero();
		}
		static public implicit operator Bound1( Closed range)
		{
			return new Bound1(range.lower,range.upper);
		}
		static public Closed operator *(Q1 scale, Closed range)
		{
			return nilnul.num.quotient.bound_.closed.op_.unary_._ScaleX.Scale(scale, range);
		}

		static public Closed operator *(Closed x, Closed y) { return nilnul.num.quotient.bound_.closed.op_.binary_._MultiX.Op(x, y); }


		static public Closed operator +(Closed a, Closed b)
		{
			return new Closed(a.lower.mark + b.lower.mark, a.upper.mark + b.upper.mark);
		}

		static public Closed operator -(Closed a)
		{
			return bound_.closed.op_.unary_._NegateX.Negate(a);
		}

		static public Closed Create_orderIfNecessary(Q1 a, Q1 b)
		{
			if (a <= b)
			{
				return new Closed(a, b);

			}
			return new Closed(b, a);
		}

		static public Closed Create_byMergeBorder(quotient.Bound bound)
		{
			return new Closed(bound.lower.mark, bound.upper.mark);
		}


	}


}
