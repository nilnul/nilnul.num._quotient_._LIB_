using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.stream_.slider
{
	public class Cumulus<TSlider, TAccumulator
		//, TOp
	>
		:
		nilnul.obj.stream_.slider.Cumulus1<nilnul.num.quotient_.DenomNonnil, TSlider, TAccumulator
			//, TOp
		>

		//where TOp: nilnul.num.quotient_.denomNonnil.of_.BinaryI
		where TAccumulator:
		nilnul.obj.of_.binary.CumulatorI<DenomNonnil>
		//nilnul.num.quotient_.denomNonnil.of_.binary.Cumulator<TOp>
		where TSlider: nilnul.num.quotient_.denomNonnil.stream_.SliderI
	{
		public Cumulus(TSlider val, TAccumulator fold) : base(val, fold)
		{

		}
	}

	

	public class Cumulus<  TAccumulator>
		:
		Cumulus<nilnul.num.quotient_.denomNonnil.stream_.SliderI,  TAccumulator>

		where TAccumulator:		nilnul.obj.of_.binary.CumulatorI<DenomNonnil>

	{
		public Cumulus(nilnul.num.quotient_.denomNonnil.stream_.SliderI val, TAccumulator fold) : base(val, fold)
		{

		}
	}

	public class Cumulus
		:
		Cumulus<nilnul.obj.of_.binary.CumulatorI<DenomNonnil>>

	

	{
		public Cumulus(nilnul.num.quotient_.denomNonnil.stream_.SliderI val, nilnul.obj.of_.binary.CumulatorI<DenomNonnil> fold) : base(val, fold)
		{

		}
	}



	
}
