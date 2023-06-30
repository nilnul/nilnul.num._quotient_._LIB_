namespace nilnul.num.quotient.stream
{
	public class Cumulus_defaulted<  TAccumulator>
		:
		Cumulus<  TAccumulator>

		where TAccumulator: nilnul.num.quotient.op_.binary.Cumulator<quotient.op_.BinaryI1>,new()
	{
		public Cumulus_defaulted(nilnul.num.quotient.StreamI6 val) : base(val, nilnul.obj_.Singleton<TAccumulator>.Instance)
		{

		}
	}


	
}
