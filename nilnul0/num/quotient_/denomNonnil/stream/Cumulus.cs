using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.stream
{
	public class Cumulus<TSlider, TAccumulator, TOp>
		:
		nilnul.obj.stream.Cumulus<nilnul.num.quotient_.DenomNonnil, TSlider, TOp, TAccumulator>
		,
		num.quotient_.denomNonnil.stream.CumulusI

		where TOp: nilnul.num.quotient_.denomNonnil.of_.BinaryI

		where TAccumulator: nilnul.obj.of_.binary.CumulatorI<DenomNonnil,TOp>

		where TSlider: nilnul.num.quotient_.denomNonnil.StreamI
	{
		public Cumulus(TSlider val, TAccumulator fold) : base(val, fold)
		{

		}

	}
	public class Cumulus<TSlider,  TAccumulator>
		:
		obj.stream.Cumulus< DenomNonnil, TSlider,  TAccumulator>

		where TAccumulator: nilnul.obj.of_.binary.CumulatorI<DenomNonnil>
		where TSlider: nilnul.num.quotient_.denomNonnil.StreamI
	{
		public Cumulus(TSlider val, TAccumulator fold) : base(val, fold)
		{

		}
	}

	public class Cumulus<  TAccumulator>
		:
		Cumulus<nilnul.num.quotient_.denomNonnil.StreamI,  TAccumulator>

		where TAccumulator: nilnul.obj.of_.binary.CumulatorI<DenomNonnil>
	{
		public Cumulus(nilnul.num.quotient_.denomNonnil.StreamI val, TAccumulator fold) : base(val, fold)
		{

		}
	}


	
}
