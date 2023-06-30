namespace nilnul.num.quotient.stream_.slider
{
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
