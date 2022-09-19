using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.be_
{
	[Obsolete()]

	public  class GtOne
			: nilnul.be.Be_froFunc<Q1>
		,
		nilnul.num.quotient.BeI3
		,
		nilnul.num.quotient.BeI4

	{
		static public bool Be(
			Q1 x
		)
		{
			return x > 1;

		}

		public bool be(QuotientI obj)
		{
			return Be(new Q1(obj));
		}

		public GtOne()
			: base(Be)
		{

		}


		public class En : nilnul.be.Asserted<Q1, GtOne>
		{
			public En(Q1 val)
				: base(val)
			{

			}

			public En(En x)
				: base(x.val)
			{


			}

			public void half()
			{
				val /= 2;
			}


			public En toHalf()
			{

				var r = new En(
					this
				);
				r.half();

				return r;

			}
			static public En Half(En x)
			{

				return new En(
					x.val / 2
				);

			}

			public override string ToString()
			{
				return val.ToString();
			}

			static public implicit operator Q1(En x)
			{
				return x.val;
			}

			static public Q1 operator -(Q1 x, En y)
			{
				return x - (Q1)y;
			}

			static public Q1 operator -(En x, Q1 y)
			{
				return (Q1)x - y;
			}

			static public Q1 operator +(Q1 x, En y)
			{
				return x + (Q1)y;
			}

			static public Q1 operator +(En y, Q1 x)
			{
				return x + (Q1)y;
			}




		}












	}



}
