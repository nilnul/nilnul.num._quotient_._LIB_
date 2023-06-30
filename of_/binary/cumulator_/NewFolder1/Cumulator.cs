using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.op_.binary
{
	[Obsolete(nameof(of_.binary.ICumulator))]
	public class Cumulator<TOp>
		: nilnul.obj.op_.binary.Accumulator<nilnul.num.Quotient1, TOp>
		where TOp : nilnul.num.quotient.op_.BinaryI1
	{
		public Cumulator(Quotient1 initial, TOp binder) : base(initial, binder)
		{
		}
	}

	[Obsolete(nameof(of_.binary.ICumulator))]
	public class Cumulator_defaulted<TOp> : Cumulator<TOp>
		where TOp : nilnul.num.quotient.op_.BinaryI1, new()
	{
		public Cumulator_defaulted(Quotient1 initial) : base(initial, nilnul.obj_.Singleton<TOp>.Instance)
		{
		}
	}
	[Obsolete(nameof(of_.binary.ICumulator))]
	public class Cumulator
		: Cumulator<nilnul.num.quotient.op_.BinaryI1>
	{
		public Cumulator(Quotient1 initial, nilnul.num.quotient.op_.BinaryI1 binder) : base(initial, binder)
		{
		}
	}

	



}
