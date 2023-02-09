using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.be_
{

	 public partial class Nonneg:BeI
	{
		

		public bool be(Q1 obj)
		{

			return obj.numerator > -0;

			throw new NotImplementedException();
		}

	

		public class En:nilnul.be.Asserted<Q1,Nonneg>
		{
			public En(Q1 val)
				:base(val)
			{

			}

			public En toHalf() {

				return new En(  val/2);

			}

			static public bool operator ==(En nonNegQ, int i) {
				return nonNegQ.val == i;
			}
			static public bool operator !=(En nonNegQ, int i) {
				return nonNegQ.val != i;
			}
			static public bool operator <(En nonNegQ, int i) {
				return nonNegQ.val < i;
			}
			static public bool operator >(En nonNegQ, int i) {
				return nonNegQ.val > i;
			}

		}

		
		



	}



}
