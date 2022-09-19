using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider
{
	public class Cumulus<TSlider, TOp, TAccumulator>
		:
		nilnul.obj.stream_.slider.Cumulus<nilnul.num.Quotient1, TSlider, TOp, TAccumulator>
		where TOp: nilnul.num.quotient.op_.BinaryI1
		where TAccumulator: nilnul.num.quotient.op_.binary.Cumulator<TOp>
		where TSlider: nilnul.num.quotient.stream_.SliderI1
	{
		public Cumulus(TSlider val, TAccumulator fold) : base(val, fold)
		{

		}
	}
	public class Cumulus<TSlider,  TAccumulator>
		:
		Cumulus< TSlider, quotient.op_.BinaryI1, TAccumulator>

		where TAccumulator: nilnul.num.quotient.op_.binary.Cumulator<quotient.op_.BinaryI1>
		where TSlider: nilnul.num.quotient.stream_.SliderI1
	{
		public Cumulus(TSlider val, TAccumulator fold) : base(val, fold)
		{

		}
	}

	public class Cumulus<  TAccumulator>
		:
		Cumulus<nilnul.num.quotient.stream_.SliderI1,  TAccumulator>

		where TAccumulator: nilnul.num.quotient.op_.binary.Cumulator<quotient.op_.BinaryI1>
	{
		public Cumulus(nilnul.num.quotient.stream_.SliderI1 val, TAccumulator fold) : base(val, fold)
		{

		}
	}


	public class Cumulus_defaulted<  TAccumulator>
		:
		Cumulus<  TAccumulator>

		where TAccumulator: nilnul.num.quotient.op_.binary.Cumulator<quotient.op_.BinaryI1>,new()
	{
		public Cumulus_defaulted(nilnul.num.quotient.stream_.SliderI1 val) : base(val, nilnul.obj_.Singleton<TAccumulator>.Instance)
		{

		}
	}


	
}
