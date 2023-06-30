using System.Linq;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.of_
{
	static public class _CoerceX
	{
		static public nonneg_.radix_.Floaty _ToFloaty_0nonfloaty (this nonneg_.RadixI radix){
			return new Floaty(
				nonneg_.radix.of_.unary_._ToFloatyX.Duo4floaty(radix)
			);
		}

		public static Floaty ToFloaty(this quotient_.nonneg_.RadixI indicPosible)
		{
			if (indicPosible is Floaty f)
			{
				return f;
			}
			return _ToFloaty_0nonfloaty(indicPosible);

			//if (indicPosible.indic > 0)
			//{
			//	return new Floaty(

			//			new nilnul.num_.Radix2(
			//				indicPosible.precision.radic
			//				,
			//				new str_.List(
			//					indicPosible.precision.gits.Select(x => new Num1(x.eeByRef)).Concat(
			//						Enumerable.Repeat(0, (int)indicPosible.indic).Select(i => new Num1(i)
			//						)
			//					)
			//				)
			//			)

			//		, 0
			//	);
			//}
			//var subtracted = (-indicPosible.indic) - indicPosible.precision.gits.Count();
			//if (subtracted > 0)
			//{

			//	return new Floaty(

			//			new nilnul.num_.Radix2(
			//				indicPosible.precision.radic
			//				,
			//				new str_.List(
			//						Enumerable.Repeat(
			//							0, (int)subtracted
			//						).Select(i => new Num1(i)
			//				)
			//			.Concat(
			//					indicPosible.precision.gits.Select(x => new Num1(x.eeByRef))
			//					)
			//				)
			//			)

			//		, 0
			//	);

			//}
			//return new Floaty(
			//	indicPosible.precision



			//	, Num_ofIn.Of(-indicPosible.indic)
			//);
		}

		static public Floaty ToFloaty(
			this nonneg_.Radix indicPosible
		)
		{
			return ToFloaty((quotient_.nonneg_.RadixI)indicPosible);
		}

		public static FloatyOfMantissa ToFloaty8mantissa(quotient_.nonneg_.RadixI radix_)
		{
			if (radix_ is FloatyOfMantissa f)
			{
				return f;
			}
			var d = nonneg_.radix.of_.unary_._ToFloatyX.Duo4floaty(radix_);
			return new FloatyOfMantissa(
				d.precision, -d.indic
			);




			if (radix_.indic > 0)
			{
				return new FloatyOfMantissa(

						new nilnul.num_.Radix2(
							radix_.precision.radic
							,
							new str_.List(
								radix_.precision.gits.Select(x => new Num1(x.eeByRef)).Concat(
									Enumerable.Repeat(0, (int)radix_.indic).Select(i => new Num1(i)
									)
								)
							)
						)

					, 0
				);
			}
			var subtracted = (-radix_.indic) - radix_.precision.gits.Count();
			if (subtracted > 0)
			{

				return new FloatyOfMantissa(

						new nilnul.num_.Radix2(
							radix_.precision.radic
							,
							new str_.List(
									Enumerable.Repeat(
										0, (int)subtracted
									).Select(i => new Num1(i)
							)
						.Concat(
								radix_.precision.gits.Select(x => new Num1(x.eeByRef))
								)
							)
						)

					, 0
				);

			}
			return new FloatyOfMantissa(
				radix_.precision



				, Num_ofIn.Of(-radix_.indic)
			);
		}

		static public FloatyOfMantissa ToFloaty8mantissa(
				nonneg_.Radix indicPosible
			)
		{
			return ToFloaty8mantissa((quotient_.nonneg_.RadixI)indicPosible);
		}

	}


}
