using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.border;
using nilnul.num.quotient_;
using Q1 = nilnul.num.Quotient1;
using Qi = nilnul.num.QuotientI;

namespace nilnul.num.quotient
{
	[Obsolete()]
	public interface BoundI
	{
		bool isSingleton { get; }
		Border2 lower { get; }
		nilnul.num.quotient_.Nonneg diameter1 { get; }
		Border2 upper { get; }

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

	[Obsolete()]
	public class Bound :
		nilnul.num.quotient.border.duo.be_.nonempty.En2, BoundI
	{

		public nilnul.num.quotient.Border2 lower { get { return en.lower; } }
		public nilnul.num.quotient.Border2 upper { get { return en.upper; } }

		public Bound(border.Duo1 duo) : base(duo)
		{

		}
		public Bound(Border2 lower, Border2 upper) : this(new border.Duo1(lower, upper))
		{

		}

		public Bound(border.Co co) : this(new border.Duo1(co.lower, co.upper))
		{
		}

		public bool contains(Q1 ext)
		{

			return border.comparer_.lower.Re.Singleton.le(lower, ext)

				&& border.comparer_.upper.Re.Singleton.ge(upper, ext);

		}
		public bool containsZero() { return contains(0); }

		public bool isNil()
		{
			return lower.mark == 0 && upper.mark == 0;
		}

		public bool notContainsZero()
		{
			return !containsZero();
		}


		public bool isSingleton
		{
			get
			{
				return this.lower.mark == this.upper.mark;
			}

		}

		public bool isClosed()
		{
			return lower.openFalseCloseTrue && upper.openFalseCloseTrue;
		}

		public Q1 span
		{
			get
			{
				return upper.mark - lower.mark;
			}
		}

		public Nonneg diameter1 => new Nonneg(diameter);

		public bool spanLessThan(quotient_.Positive1 diameter)
		{
			if (isClosed())
			{
				return (span as Q1) < (Q1)(diameter);

			}
			else
			{
				return span <= (Q1)diameter;
			}

		}
		public bool notSpanLessThan(quotient_.Positive1 diameter)
		{
			return !spanLessThan(diameter);

		}

		public bool capacityLt(Positive1 diameter)
		{
			if (isClosed())
			{
				return (span) < (Q1)(diameter);

			}
			else
			{
				return span <= (Q1)diameter;
			};
		}

		public bool notCapacityLt(Positive1 diameter)
		{
			return !capacityLt(diameter);
		}

		public bool isDiameterLt(quotient_.Positive1 diameter)
		{
			return (span) < (diameter);
		}

		public bool isDiameterLe(quotient_.Positive1 diameter)
		{
			return (this.diameter1.en) <= (diameter);
		}

		public bool notIsDiameterLe(quotient_.Positive1 diameter)
		{
			return !(isDiameterLe(diameter));
		}

		public bool isNotDiameterLt(quotient_.Positive1 diameter)
		{
			return !isDiameterLt(diameter);
		}

		static public Bound CreateClose(Q1 a, Q1 b)
		{
			return new Bound(Border2.CreateClose(a), Border2.CreateClose(b));
		}

		static public Bound CreateClose(Qi a, Qi b)
		{
			return new Bound(Border2.CreateClose(a), Border2.CreateClose(b));
		}

		static public Bound CreateSingleton(Qi a)
		{
			return CreateClose(a, a);
		}
		static public Bound CreateSingleton(Q1 a)
		{
			return CreateClose(a, a);
		}


		public static Bound CreateZero()
		{
			return CreateSingleton(0);
		}


		static public Bound CreateOpen(Q1 a, Q1 b)
		{
			return new Bound(Border2.CreateOpen(a), Border2.CreateOpen(b));
		}
		static public Bound CreateOpen(nilnul.num.QuotientI a, nilnul.num.QuotientI b)
		{
			return new Bound(Border2.CreateOpen(a), Border2.CreateOpen(b));
		}

		static public Bound CreateOpen(nilnul.num.QuotientI a, nilnul.num.Quotient1 b)
		{
			return new Bound(Border2.CreateOpen(a), Border2.CreateOpen(b));
		}

		static public Bound CreateOpen(nilnul.num.QuotientI a, int b)
		{
			return new Bound(Border2.CreateOpen(a), Border2.CreateOpen(b));
		}
		static public Bound CreateOpen(int a, nilnul.num.QuotientI b)
		{
			return new Bound(Border2.CreateOpen(a), Border2.CreateOpen(b));
		}
		static public Bound CreateOpen(int a, nilnul.num.Quotient1 b)
		{
			return new Bound(Border2.CreateOpen(a), Border2.CreateOpen(b));
		}



		static public Bound CreateOpen_orderIfNecessary(Q1 a, Q1 b)
		{
			if (a < b)
			{
				return CreateOpen(a, b);

			}
			return CreateOpen(b, a);
		}

		static public Bound CreateClopen_orderIfNecessary(Q1 a, Q1 b)
		{
			if (a < b)
			{
				return CreateClopen(a, b);

			}
			return CreateClopen(b, a);
		}


		static public Bound CreateClose_orderIfNecessary(Q1 a, Q1 b)
		{
			if (a < b)
			{
				return CreateClose(a, b);

			}
			return CreateClose(b, a);
		}

		static public Bound CreateOpenClose_orderIfNecessary(Q1 a, Q1 b)
		{
			if (a < b)
			{
				return CreateOpenClose(a, b);

			}
			return CreateOpenClose(b, a);
		}


		static public Bound CreateOpen_orderIfNecessary(Qi a, Qi b)
		{
			return CreateOpen_orderIfNecessary(new Q1(a), new Q1(b));
		}

		static public Bound Create_orderIfNecessary(nilnul.num.quotient.Border2 a, nilnul.num.quotient.Border2 b)
		{
			if (a.mark <= b.mark)
			{
				return new Bound(a, b);
			}
			return new Bound(b, a);
		}


		static public Bound CreateClopen(Q1 a, Q1 b)
		{
			return new Bound(Border2.CreateClose(a), Border2.CreateOpen(b));
		}

		static public Bound CreateOpenClose(Q1 a, Q1 b)
		{
			return new Bound(Border2.CreateOpen(a), Border2.CreateClose(b));
		}


		/// <summary>
		/// compile error
		/// </summary>
		/// <param name="duo"></param>
		//static public implicit operator Range( border.duo.be_.Nonempty.En duo) {
		//	return new Range(duo);
		//}

		static public implicit operator Bound(nilnul.num.Range numRange)
		{
			return new Bound(
				(nilnul.num.quotient.Border2)numRange.ed.lower
				,
				(nilnul.num.quotient.Border2)numRange.ed.upper
			);
		}

		static public Bound operator +(Bound a, Bound b)
		{
			return new Bound(a.lower + b.lower, a.upper + b.upper);
		}
		static public Bound Multi(
			Bound x
			,
			Bound y
		)
		{

			return bound.op_.binary_._MultiX.Op(x, y);
		}


		static public Bound operator *(Bound x, Bound y) { return Multi(x, y); }

		static public Bound operator *(Q1 scale, Bound range)
		{
			return nilnul.num.quotient.bound.op_.unary_._ScaleX.Scale(scale, range);
		}
		static public Bound operator *(Bound range, Q1 scale)
		{
			return nilnul.num.quotient.bound.op_.unary_._ScaleX.Scale(scale, range);
		}

		static public Bound operator -(Bound a, Bound b)
		{
			return a + -b;
		}
		static public bool operator ==(Bound a, Bound b)
		{
			return a.lower == b.lower && a.upper == b.upper;
		}
		static public bool operator !=(Bound a, Bound b)
		{
			return !(a == b);
		}

		static public Bound operator -(Bound a)
		{
			return bound.op_.unary_._NegateX.Negate(a);
		}


	}
}