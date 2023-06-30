using nilnul.num.quotient_;
using nilnul.obj.of_;
using nilnul.obj.of_.binary._cumulator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.of_.binary
{
	public interface CumulatorI<TOp> : obj.of_.binary.CumulatorI<DenomNonnil,TOp>
		where TOp : nilnul.num.quotient_.denomNonnil.of_.BinaryI

	{

	}
	public interface CumulatorI : obj.of_.binary.CumulatorI<DenomNonnil> {

	}

	public class Cumulator<TOp>
		: nilnul.obj.of_.binary.Cumulator<nilnul.num.quotient_.DenomNonnil>
		,
		CumulatorI
		where TOp : nilnul.num.quotient_.denomNonnil.of_.BinaryI
	{
		public Cumulator(DenomNonnil initial, TOp binder) : base(initial, binder)
		{
		}

	}
	public class Cumulator
		: Cumulator<nilnul.num.quotient_.denomNonnil.of_.BinaryI>
		,
		CumulatorI
		//,
		//obj.of_.binary.CumulatorI<DenomNonnil>
	{
		public Cumulator(DenomNonnil initial, nilnul.num.quotient_.denomNonnil.of_.BinaryI binder) : base(initial, binder)
		{
		}

		//BinaryI<DenomNonnil> BinderI<BinaryI<DenomNonnil>>.binder => throw new NotImplementedException();
	}

	



}
