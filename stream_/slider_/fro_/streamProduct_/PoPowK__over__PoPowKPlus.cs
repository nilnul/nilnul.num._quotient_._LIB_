using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.slider_.fro_.streamProduct_
{
	public class Square_over_SquarePlus
		: nilnul.num.quotient.SliderI
	{

		public class Term4Product : StreamI3
		{
			nilnul.num.StreamI3 num = nilnul.num.stream.op_.Skip.Eval(
				new nilnul.num.stream_.Squared()
			);

			//nilnul.num.StreamI3 den = nilnul.num.stream.duo.op_.Add.Singleton.eval(
			//	nilnul.num.stream.op_.Skip.Eval(
			//		new nilnul.num.stream_.Squared()
			//	)
			//	,
			//	1
			//);

			public Q1 next()
			{
				var t = num.next();
				return new Q1(t, t + 1);
			}
		}

		Term4Product terms4product = new Term4Product();

		Q1 product = 1;

		public Q1 current
		{
			get
			{
				return product;
			}
		}


		public void moveNext()
		{
			product *= terms4product.next();
		}
	}
}
