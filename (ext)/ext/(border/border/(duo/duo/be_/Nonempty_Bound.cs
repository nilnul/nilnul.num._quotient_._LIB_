using nilnul.num.quotient.ext.border.duo.be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

using q = nilnul.num.quotient;
using nilnul.num.quotient.be;

namespace nilnul.num.quotient.ext.border.duo.be_
{

	public partial class Nonempty_Bound
			:
			bit.Be<Duo1>

	{
		static public bool Eval(Duo1 duo)
		{

			return Nonempty.Eval(duo) && (duo.lower.mark is ext_.Bare) && (duo.upper.mark is ext_.Bare);

		}


		public Nonempty_Bound()
				:base(Eval)
			{

		}



		public class En : nilnul.bit.be.Asserted<Duo1, Nonempty_Bound>
		{

			public En(Duo1 val) : base(val)
			{



			}
			public En(Border1 lower, Border1 upper) : base(new Duo1(lower, upper))
			{



			}

			public Q1 lowerMark
			{
				get
				{
					return (Q1)(((ext_.Bare)(val.lower.mark)).q);
				}
			}


			public Q1 upperMark
			{
				get
				{
					return (Q1)(((ext_.Bare)(val.upper.mark)).q);
				}
			}


			public bool isClosed()
			{
				return val.lower.openFalseCloseTrue && val.upper.openFalseCloseTrue;
			}

			public Q1 span
			{
				get
				{
					return upperMark - lowerMark;
				}
			}






			public bool spanLessThan(quotient.be.Positive.Asserted diameter)
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



			public q.Border1 lower
			{
				get
				{
					return new q.Border1(val.lower.openFalseCloseTrue, val.lower.mark as Q1);
				}
			}

			public q.Border1 upper
			{
				get
				{
					return new q.Border1(val.upper.openFalseCloseTrue, val.upper.mark as Q1);
				}
			}

			public Q1 midpoint
			{
				get
				{
					return (lower.mark + upper.mark) / 2;
				}
			}

			public Q1 diameter
			{
				get
				{
					return upper.mark - lower.mark;
				}
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




			static public En CreateSingleton(
		Q1 singleton

		)
			{

				return new En(
					Duo1.CreateSingleton(
						singleton

					)

				);


			}

			public bool notSpanLessThan(Positive.Asserted diameter)
			{
				return !spanLessThan(diameter);

				throw new NotImplementedException();
			}




			static public En CreateOpen(
				Q1 lower
				,
				Q1 upper

			)
			{

				return new En(
					new Border1(false, lower)
					, new Border1(false, upper)
				);
			}







			static public En CreateOpen(
				int lower
				,
				int upper

			)
			{

				return CreateOpen((Q1)lower, (Q1)upper);
			}



		}




	}
}
