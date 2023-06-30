using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream
{
	public class Cumulus<TSlider, TOp, TAccumulator>
		:
		nilnul.obj.stream.Cumulated<nilnul.num.Quotient1, TSlider, TOp, TAccumulator>
		,
		num.quotient.StreamI6
		where TOp: nilnul.num.quotient.op_.BinaryI1
		where TAccumulator: nilnul.num.quotient.op_.binary.Cumulator<TOp>
		where TSlider: nilnul.num.quotient.StreamI6
	{
		public Cumulus(TSlider val, TAccumulator fold) : base(val, fold)
		{

		}
	}
	public class Cumulus<TSlider,  TAccumulator>
		:
		Cumulus< TSlider, quotient.op_.BinaryI1, TAccumulator>

		where TAccumulator: nilnul.num.quotient.op_.binary.Cumulator<quotient.op_.BinaryI1>
		where TSlider: nilnul.num.quotient.StreamI6
	{
		public Cumulus(TSlider val, TAccumulator fold) : base(val, fold)
		{

		}
	}

	public class Cumulus<  TAccumulator>
		:
		Cumulus<nilnul.num.quotient.StreamI6,  TAccumulator>

		where TAccumulator: nilnul.num.quotient.op_.binary.Cumulator<quotient.op_.BinaryI1>
	{
		public Cumulus(nilnul.num.quotient.StreamI6 val, TAccumulator fold) : base(val, fold)
		{

		}
	}


	
}
