using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;
using Qi = nilnul.num.QuotientI;

namespace nilnul.num.quotient
{



	public class Range1 :
		nilnul.num.quotient.border.duo.be_.nonempty.En2
		, RangeI
	{
		public nilnul.num.quotient.Border2 lower { get { return en.lower; } }
		public nilnul.num.quotient.Border2 upper { get { return en.upper; } }

		public Range1(border.Duo1 duo) : base(duo)
		{

		}
		public Range1(Border2 lower, Border2 upper) : this(new border.Duo1(lower, upper))
		{

		}

		public bool contains(Q1 ext)
		{

			return border.comparer_.lower.Re.Singleton.le(lower, ext)

				&& border.comparer_.upper.Re.Singleton.ge(upper, ext);

		}
		public bool containsZero() { return contains(0); }

		public bool isNil() {
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



		static public Range1 CreateClose(Q1 a, Q1 b)
		{
			return new Range1(Border2.CreateClose(a), Border2.CreateClose(b));
		}

		static public Range1 CreateClose(Qi a, Qi b)
		{
			return new Range1(Border2.CreateClose(a), Border2.CreateClose(b));
		}

		static public Range1 CreateSingleton(Qi a)
		{
			return CreateClose(a, a);
		}
		static public Range1 CreateSingleton(Q1 a)
		{
			return CreateClose(a, a);
		}


		public static Range1 CreateZero()
		{
			return CreateSingleton(0);
		}


		static public Range1 CreateOpen(Q1 a, Q1 b)
		{
			return new Range1(Border2.CreateOpen(a), Border2.CreateOpen(b));
		}
		static public Range1 CreateOpen_orderIfNecessary(Q1 a, Q1 b)
		{
			if (a < b)
			{
				return CreateOpen(a, b);

			}
			return CreateOpen(b, a);
		}

		static public Range1 CreateOpen_orderIfNecessary(Qi a, Qi b)
		{
			return CreateOpen_orderIfNecessary(new Q1(a), new Q1(b));
		}



		static public Range1 CreateClopen(Q1 a, Q1 b)
		{
			return new Range1(Border2.CreateClose(a), Border2.CreateOpen(b));
		}

		static public Range1 CreateOpenClose(Q1 a, Q1 b)
		{
			return new Range1(Border2.CreateOpen(a), Border2.CreateClose(b));
		}


		/// <summary>
		/// compile error
		/// </summary>
		/// <param name="duo"></param>
		//static public implicit operator Range( border.duo.be_.Nonempty.En duo) {
		//	return new Range(duo);
		//}

		static public implicit operator Range1(nilnul.num.Range numRange)
		{
			return new Range1(
				(nilnul.num.quotient.Border2)numRange.ed.lower
				,
				(nilnul.num.quotient.Border2)numRange.ed.upper
			);
		}

		static public Range1 operator +(Range1 a, Range1 b)
		{
			return new Range1(a.lower + b.lower, a.upper + b.upper);
		}
		static public Range1 Multi(
			Range1 x
			,
			Range1 y
		)
		{

			return range.op_.binary_._MultiX.Op(x,y);
		}

		static public Range1 operator *(Range1 x, Range1 y) { return Multi(x, y); }

		static public Range1 operator *(Q1 scale, Range1 range)
		{
			return nilnul.num.quotient.range.op_.unary_._ScaleX.Scale(scale, range);
		}
		static public Range1 operator *( Range1 range, Q1 scale)
		{
			return nilnul.num.quotient.range.op_.unary_._ScaleX.Scale(scale, range);
		}

		static public Range1 operator -(Range1 a, Range1 b)
		{
			return a + -b;
		}

		static public Range1 operator -(Range1 a)
		{
			return range.op_.unary_._NegateX.Negate(a);
		}
	}
}