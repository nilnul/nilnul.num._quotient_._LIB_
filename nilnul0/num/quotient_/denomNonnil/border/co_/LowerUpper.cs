using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.quotient_.DenomNonnilI;//._quotient.fraction.op.Simplify.Ed1;
using Qi = nilnul.num.quotient_.DenomNonnil;//._quotient.fraction.op.Simplify.Ed1;
using nilnul.obj.comp;
using nilnul.num.quotient_.denomNonnil.border_;
using nilnul.obj.border.co_;

namespace nilnul.num.quotient_.denomNonnil.border.co_
{
	public class LowerUpper
		:
		nilnul.obj.border.co_.LowerUpperA<nilnul.num.quotient_.DenomNonnilI, border_.LowerI, border_.UpperI>
		,
		nilnul.obj._collection_.HasI<Q1>
		,
		nilnul.obj._collection_.HasI<int>
		,
		LowerUpperI

	{

		public LowerUpper(border_.Lower lower, border_.Upper upper) : base(lower, upper)
		{
		}

		public LowerUpper(bool left, Q1 leftMark, bool right, Q1 rightMark)
			:this(
				 new border_.Lower(left,leftMark)
				 ,
				 new border_.Upper(right,rightMark)
			)
		{

		}
		
		

		public LowerUpper(BorderI lower, BorderI upper):this(
			 border_.Lower.Of(
				lower
			),
			 border_.Upper.Of(
				upper
			)
		)
		{

		}


		public bool has(Q1 ext) {
			return
				nilnul.obj.border.comp._ReX.Le(
					border_.lower.Comp.Singleton
					,
					lower
					,
					ext
				)
				&&
				nilnul.obj.border.comp._ReX.Ge(
					border_.upper.Comp.Singleton
					,
					upper
					,
					ext
				)
			;
		}

		public override string ToString()
		{
			return nilnul.obj.border.co.phrase_._LowerUpperX.Phrase(lower,upper);
		}


		static public LowerUpper CreateClose(Q1 leftMark,  Q1 rightMark) {
			return new LowerUpper(true,leftMark,true, rightMark);
		}

		static public LowerUpper CreateSingleton(Q1 leftMark) {
			return new LowerUpper(true,leftMark,true, leftMark);
		}

		public bool has(int element)
		{
			return has(new quotient_.DenomNonnil(element));
		}
	}
}