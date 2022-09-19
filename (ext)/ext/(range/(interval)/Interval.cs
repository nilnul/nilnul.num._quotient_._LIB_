using nilnul.num.quotient._ext;
using nilnul.num.rational.cut;
using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient
{
	public partial class Interval
		: 
		nilnul.num.quotient.ext.interval.be.Bound.En
	//,	nilnul.order.ext.comparer.bounded.Restricted<Rational_InheritFraction2,Comparer>.Expr
	{


		public bool contains(Q q) {
			return val.contains(q);
		}


		public Interval( ext.Bound left,ext.Bound right)
			:this(
				 new ext.Interval(left,right)
				
				 )
		{

		}

		

		public Interval(
			ext.Interval interval
	
		)
			:base(interval)
			
		{


		}

		public ext.bound.be.BasedLower.Expr lower {
			get {
				return new ext.bound.be.BasedLower.Expr( val.val.lower);
			}
		}

			public ext.bound.be.BasedUpper.Expr upper {
			get {
				return new ext.bound.be.BasedUpper.Expr( val.val.upper);
			}
		}



	


		public Interval(bool lowerOpenFalseCloseTrue,Q a, bool upperOpenFalseCloseTrue,  Q b)
			:this(new ext.Bound(lowerOpenFalseCloseTrue,a),new ext.Bound(upperOpenFalseCloseTrue,b))
		{

		}

		public Interval(bool lowerClose, num.quotient._ext.ExtI x, bool upperClose, num.quotient._ext.ExtI y)
			: this(
				new ext.Bound(lowerClose, x)
			,
			new ext.Bound(upperClose, y)
			)
		{

		}



		public nilnul.num.rational.bound.pair.be.Nonempty.Asserted toBasedNoEmpty(
				
		) {
			return new rational.bound.pair.be.Nonempty.Asserted(
				new rational.Bound(
					this.lower.val.eq
					,
					(this.lower.val.pinpoint as _ext.Base).val
					)
				,
				new rational.Bound(
					this.upper.val.eq
					,
					(this.upper.val.pinpoint as _ext.Base).val
					)
			
				
				);
		}






		static public Interval Create(bool lowerOpenFalseCloseTrue,Q a, bool upperOpenFalseCloseTrue,  Q b)
		{


			return new Interval(
				new ext.Bound(lowerOpenFalseCloseTrue, a)
				,
				new ext.Bound(upperOpenFalseCloseTrue, b)
			);

		}

		static public Interval Create(num.quotient._ext.ExtI a, bool lowerOpenFalseCloseTrue, Q b, bool upperOpenFalseCloseTrue)
		{


			return new Interval(
				new ext.Bound(lowerOpenFalseCloseTrue, a)
				,
				new ext.Bound(upperOpenFalseCloseTrue, b)
			);

		}

		static public Interval Create(bool lowerOpenFalseCloseTrue, num.quotient._ext.ExtI a, bool upperOpenFalseCloseTrue,  Q b)
		{


			return new Interval(
				new ext.Bound(lowerOpenFalseCloseTrue, a)
				,
				new ext.Bound(upperOpenFalseCloseTrue, b)
			);

		}


		

	

		static public Interval CreateOpen(Q a, Q b)
		{
			return Create(false,a, false, b);
		}
		static public Interval CreateOpen_aftOrdered(Q a, Q b)
		{
			if (a<b)
			{
				return CreateOpen(a, b);
				
			}
			return CreateOpen(b, a);
			//return Create(a, false, b, false);
		}

		static public Interval CreateOpen(num.quotient._ext.ExtI a, Q b)
		{
			return Create(a, false, b, false);
		}
	
	

		static public Interval CreateClopen(Q a, Q b

)
		{


			return new Interval(true, a,false,b);

		}
		static public Interval CreateSingleton(Q x)
		{
			return new Interval(true,x, true,  x);
		}

		
		

		static public Interval CreateClose(Q a, Q b)
		{
			return Create(true,a, true, b);
		}

		static public Interval CreateCloseUnit() {
			return CreateClose(0,1);
		}

		static public Interval CreateOpenClose(Q a, Q b)
		{
			return new Interval(
				true,
				a
				,
				true,
				b
			);


		}

		static public Interval CreateZero() {
			return new Interval(true,0, true,0);
		
		}


		

		
					
	}
}
