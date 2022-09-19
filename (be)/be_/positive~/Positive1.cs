using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.be_
{
	[Obsolete()]
	public  class Positive1
			: nilnul.bit.Be<Q1>
		,
		nilnul.num.quotient.BeI1

	{
		static public bool Eval(
			Q1 x
		)
		{
			return x > 0;
			
		}

		public bool be(QuotientI obj)
		{
			return obj.numerator > 0;
		//	throw new NotImplementedException();
		}

		public Positive1()
				:base(Eval)
			{

			}
		
		[Obsolete()]
		public class En:nilnul.bit.be.Asserted<Q1,Positive1>
		{
			public En(Q1 val)
				:base(val)
			{

			}

			public En(En x)
				:base(x.val)
			{


			}

			

			public void half() {
				val /= 2;
			}


			public En toHalf() {

				var r= new En(
					this
				);
				r.half();

				return r;
			
			}


			static public En Half(En x) {

				return new En(
					x.val /2	
				);
			
			}

			public override string ToString()
			{
				return val.ToString();
			}

			static public   implicit operator Q1(En x) {
				return x.val;
			}

			static public Q1 operator -(Q1 x, En y) {
				return x - (Q1)y;
			}

			static public Q1 operator -( En x , Q1 y) {
				return  (Q1)x-y;
			}

			static public En operator /( En x , nilnul._num.bigint.be.Positive.Asserted y) {
				return  new En(
					x.val / y
					
				);
			}
			static public En operator *( En x , En y) {
				return  new En(
						x.val*y.val
					);
			}

			static public Q1 operator +(Q1 x, En y) {
				return x + (Q1)y;
			}

			static public Q1 operator +( En y, Q1 x) {
				return x + (Q1)y;
			}

			


		}

		
	
		

	






	}



}
