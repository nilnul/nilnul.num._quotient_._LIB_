using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider.product_._quarterTau
{
	public class Slider : nilnul.num.quotient.slider_.fro_.FuncWithIndex

	{
		public Slider() : base(
			(k) => {
				var kPlus = k;
				var Four_kPlusSquare = nilnul.num.op_.Square.Eval(kPlus) * 4;


				return nilnul.num.quotient.duo_.dividable.op_._divide.Extensions.Divide(
					Four_kPlusSquare,
					Four_kPlusSquare - 1
				);
			}
			,
			new nilnul.num.slider_.Positive()
		)
		{
		}
	}
}
