using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul._num.bigint.be_;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.border.duo.be_
{
	public class Nonempty
		: BeI<Duo>
		, nilnul.bit.BeI<Duo>
		, nilnul.num.quotient.border.duo.BeI
		,nilnul.num.quotient.border.duo.BeI1

	{
		static public bool Eval(Duo x)
		{

			return Singleton.Eval(x) || Spanned.Eval(x);

		}

		static public bool Eval(Duo1 x)
		{

			return Singleton.Be(x) || Spanned.Eval(x);

		}


		public bool be(Duo obj)
		{
			return Eval(obj);

			throw new NotImplementedException();
		}

		public bool be(Duo1 obj)
		{
			return Eval(obj);

			throw new NotImplementedException();
		}
		[Obsolete()]
		public class En :
			nilnul.bit.be.Asserted<Duo, Nonempty>
		{


			public En(Duo x)
				: base(x)
			{

			}

			public En(Border1 border11, Border1 border12)
				: this(new Duo(border11, border12))
			{

			}

			public En(
				bool openFalseCloseTrue
				,
				Q1 mark
				,
				bool openFalseCloseTrue1
				,
				Q1 mark1
				)
				: this(
					new Border1(openFalseCloseTrue, mark)
					 ,
					new Border1(openFalseCloseTrue1, mark1)
					 )
			{

			}

			public Q1 midPoint
			{
				get
				{
					return (lower.mark + upper.mark) / 2;
				}
			}

	

			public Border1 upper
			{
				get
				{
					return val.upper;
				}
			}

			public static En CreateSingleton(Q1 _quotient)
			{
				return CreateClose(_quotient, _quotient);

				throw new NotImplementedException();
			}


			public static En CreateZero() {
				return CreateSingleton(0);
			}

			public Q1 diameter
			{
				get
				{
					return upper.mark - lower.mark;
				}
			}

			public quotient.be_.Nonneg.En diameterNonneg
			{
				get
				{
					return new quotient.be_.Nonneg.En(upper.mark - lower.mark);
				}
			}


			public Border1 lower
			{
				get
				{
					return val.lower;
				}
			}

			public bool contains(Q1 ext)
			{
				return val.contains(ext);
			}

			public bool isSingleton
			{
				get
				{
					return this.lower.mark == this.upper.mark;
				}

			}

			public bool nonSingleton {
				get {
					return !isSingleton;
				}
			}


			public bool containsZero() { return contains(0); }

			public bool notContainsZero()
			{
				return !containsZero();
			}

			public bool isClosed()
			{
				return val.lower.openFalseCloseTrue && val.upper.openFalseCloseTrue;
			}

			public Q1 span
			{
				get
				{
					return upper.mark - lower.mark;
				}
			}



			public bool spanLessThan(quotient.be_.Positive1.En diameter)
			{
				if (isClosed())
				{
					return (span as Q1) < (Q1)(diameter.val);

				}
				else
				{
					return span <= (Q1)diameter.val;
				}

			}

			public bool notSpanLessThan(quotient.be_.Positive1.En diameter)
			{
				return !spanLessThan(diameter);

				throw new NotImplementedException();
			}



			public bool notContains(Q1 ext)
			{
				return !contains(ext);
			}

			public override string ToString()
			{
				return val.ToString();
			}

			static public En operator *(En x, En y) { return Multi(x, y); }

			static public En operator *(Q1 scale, En range) {
				return nilnul.num.quotient.range.op_.Scale.Eval(scale, range);
			}


			static public En operator +(Q1 shift	, En range) {
				return nilnul.num.quotient.range.op_.Shift.Eval(shift, range);
			}

			static public En Multi(
				En x
				,
				En y
			)
			{

				var lowerLower = x.lower * y.lower;

				var lowerUpper = x.lower * y.upper;

				var upperLower = x.upper * y.lower;
				var upperUpper = x.upper * y.upper;

				var r = new En(

					quotient.border.comparer_.Lower.Min(lowerLower, lowerUpper, upperLower, upperUpper)
					,
					quotient.border.comparer_.Upper.Max(lowerLower, lowerUpper, upperLower, upperUpper)

				);

				return r;


				throw new NotImplementedException();
			}


			static public En operator +(En x, En y) { return Add(x, y); }


			static public En Add(
				En x
				,
				En y
			)
			{



				return new En(
					x.lower + y.lower
					,
					x.upper + y.upper


				);



				throw new NotImplementedException();
			}

			static public implicit operator border.Duo(En x) {
				return x.val;
			}

			////compile error
			//static public implicit operator Range(En x) {
			//	return new Range( x.val);
			//}


			static public En Minus(En x, En y)
			{
				return Add(x, -y);
			}
			static public En operator -(En x, En y)
			{
				return Minus(x, y);
			}
			static public En operator -(En x)
			{
				return Negate(x);
			}
			static public En Negate(
				En x
			)
			{



				return new En(
					-x.upper, -x.lower



				);



				throw new NotImplementedException();
			}

			static public En CreateClose(Q1 a, Q1 b)
			{
				return new En(Border1.CreateClose(a), Border1.CreateClose(b));
			}
			static public En _CreateCloseNeighbor_assertRadiusNoneg(Q1 _radius_nonNeg)
			{
				return new En(Border1.CreateClose(-_radius_nonNeg), Border1.CreateClose(_radius_nonNeg));
			}

			static public En CreateClose_orderIfNeed(
				Q1 lower
				,
				Q1 upper

			)
			{
				if (lower > upper)
				{
					return CreateClose(upper, lower);

				}

				return CreateClose(lower, upper);
			}

			static public En CreateOpen(Q1 a, Q1 b)
			{
				return new En(Border1.CreateOpen(a), Border1.CreateOpen(b));
			}

			
			static public En CreateOpenClose(Q1 a, Q1 b)
			{
				return new En(Border1.CreateOpen(a), Border1.CreateClose(b));
			}

			static public En CreateClopen(Q1 a, Q1 b)
			{
				return new En(Border1.CreateClose(a), Border1.CreateOpen(b));
			}
			public static En CreateCloseUnit()
			{
				return CreateClose(0, 1);
				//throw new NotImplementedException();
			}
		}



	}
}
