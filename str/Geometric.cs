using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.str
{
	public interface GeometricI : StrI1{
		Q head { get; }

		Q rate { get; }
	}
	public class Geometric_givenHead 
	{

		private Q _head;

		public Q head
		{
			get { return _head; }
			set { _head = value; }
		}

		private Q _rate;

		public Q rate
		{
			get { return _rate; }
			set { _rate = value; }
		}

		private nilnul.num.bigint.be.Natural.Asserted _count;

		public nilnul.num.bigint.be.Natural.Asserted  count
		{
			get { return _count; }
			set { _count = value; }
		}






		public Geometric_givenHead(Q head, Q rate, nilnul.num.bigint.be.Natural.Asserted count)
		{
			_head = head;
			_rate = rate;

			_count = count;
		}

		public Geometric_givenHead(Q head, Q rate, int count)
			:this(head,rate,new bigint.be.Natural.Asserted(count))
		{
			
		}



		public IEnumerator<Q> GetEnumerator()
		{
			var ratio = Q.CreateOne();
			for (BigInteger i = 0; i < count; i++)
			{
				yield return _head * ratio;
				ratio *= _rate;
			}
			//throw new NotImplementedException();
		}

		

		

		static public Geometric_givenHead Create_headIsOne( Q d, int count) {

			return new Geometric_givenHead(
				1//
				,
				d
				,
				new bigint.be.Natural.Asserted(count)

			);

		}

		static public Geometric_givenHead CreateHalfHalf(int count) {
			return new Geometric_givenHead(Q.CreateHalf(), Q.CreateHalf(),
				
				count
				
				);
		}








	}

	
}
