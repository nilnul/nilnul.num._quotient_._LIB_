using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.quotient.Q;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.stream._instanceS
{
	public class ArithmeticoGeometric : StreamI2
	{

		private ArithmeticI _arithmetic;

		public ArithmeticI arithmetic
		{
			get { return _arithmetic; }
			set { _arithmetic = value; }
		}

		private GeometricI _geometric;

		public GeometricI geometric
		{
			get { return _geometric; }
			set { _geometric = value; }
		}

		public Q next()
		{
			return arithmetic.next() * _geometric.next();

			//throw new NotImplementedException();
		}

		public void reset()
		{
			arithmetic.reset();_geometric.reset();
			return;
			//throw new NotImplementedException();
		}


		/// <summary>
		/// s0=0; s1=a0;
		/// </summary>
		/// <param name="n_exclusive"></param>
		/// <returns></returns>
		public Q partialSum(BigInteger n_exclusive) {

			var a = _arithmetic.head;
			var n = n_exclusive;
			var d = _arithmetic.diff;
			var r = _geometric.rate;
			return
				(a - (a+(n-1)*d)*q.op._PowX.Eval(r,n) ) 
				/
				(1-r)

				+

				d*r*(1- q.op._PowX.Eval(r,n-1)) 
				/
				q.op.SquareX.Square( (1-r))
			;
			/* if head's index is 1.
			return
				(a - (a+(n-1)*d)*q.op._PowX.Eval(r,n) ) 
				/
				(1-r)

				+

				d*r*(1- q.op._PowX.Eval(r,n-1)) 
				/
				q.op.SquareX.Square( (1-r))
			;
			*/


		}
	}

	

	
}
