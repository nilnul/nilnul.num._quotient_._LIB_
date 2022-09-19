using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.convert_
{

	

	public class Negate : ConvertI
	{
		public QuotientI eval(QuotientI arg)
		{

			return new nilnul.num.Quotient(
				-arg.numerator
				,
				arg.denominator
			);
			throw new NotImplementedException();
		}

		public Quotient eval(Quotient arg)
		{

			return new nilnul.num.Quotient(
				-arg.numerator
				,
				(arg as nilnul.num.QuotientI).denominator
			);
			throw new NotImplementedException();
		}

		public Quotient1 op(Quotient1 arg)
		{

			return new nilnul.num.Quotient1(
				-arg.numerator
				,
				arg .denominator
			);
			throw new NotImplementedException();
		}


		static public readonly Negate Singleton = SingletonByDefault<Negate>.Instance;

		public Quotient1 convert(QuotientI1 arg)
		{
			return new nilnul.num.Quotient1(
				-arg.numerator
				,
				arg .denominator1
			);

		}
	}
}
