using nilnul.num.quotient.ext.border.duo.be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

using q = nilnul.num.quotient;
using nilnul.num.quotient.be;

namespace nilnul.num.quotient.ext.border.duo.be
{

	public partial class Bound
	{
		static public  bool Eval(Duo duo) {

			return  Have.Eval(duo) &&  (duo.lower.mark is _ext.Base) && (duo.upper.mark is _ext.Base) ;
		
		}




		public class Be:
			nilnul.bit.Be<Duo>
		{
			public Be()
				:base(Eval)
			{

			}
			
		}

		public class Asserted: nilnul.bit.be.Asserted<Duo,Be>
		{

			public Asserted(Duo val):base(val)
			{



			}
			public Asserted(Border lower, Border upper) : base(new Duo(lower, upper))
			{



			}

			public Q1 lowerMark {
				get {
					return (Q1) (  ((_ext.Base)(val.lower.mark)).val );
				}
			}


			public Q1 upperMark {
				get {
					return (Q1) (  ((_ext.Base)(val.upper.mark)).val );
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
					return (span as Q1) < (Q1)(diameter.val );

				}
				else
				{
					return span <= (Q1)diameter.val;
				}

			}



			public q.Border lower {
				get {
					return (q.Border)(val.lower);
				}
			}

			public q.Border upper {
				get {
					return (q.Border)(val.upper);
				}
			}

			public Q midpoint
			{
				get
				{
					return (lower.mark + upper.mark) / 2;
				}
			}

			public Q diameter
			{
				get
				{
					return upper.mark - lower.mark;
				}
			}







			static public Asserted CreateSingleton(
	Q singleton

	)
			{

				return new Asserted(
					Duo.CreateClose(
						singleton,singleton
						
					)
					
				);

				
			}

			public bool notSpanLessThan(Positive.Asserted diameter)
			{
				return !spanLessThan(diameter);

				throw new NotImplementedException();
			}

			static public Asserted CreateSingleton(
				nilnul.num._quotient.fraction.op.Simplify.Ed1 singleton

	)
			{

				return new Asserted(
					Duo.CreateClose(

						singleton,singleton
						
					)
					
				);

				
			}


			static public Asserted CreateOpen(
				Q lower
				,
				Q upper

			)
			{

				return new Asserted(
					new Border(false, lower)
					, new Border(false, upper)
				);
			}


	

			static public Asserted CreateOpen(
				Q1 lower
				,
				Q1 upper

			)
			{

				return new Asserted(
					new Border(false, lower)
					, new Border(false, upper)
				);
			}


			static public Asserted CreateOpen(
				int lower
				,
				int upper

			)
			{

				return CreateOpen( (Q1) lower, (Q1) upper);
			}


		}






	}
}
