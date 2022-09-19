using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.combine_
{
	 public class Add 
	:CombineI1
		,
		num.quotient.CombineI2
	{

		static private readonly Add _Instance = new Add();

		static public Add Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Add()
		{
		}
				

	

		public override string ToString()
		{
			return "*";
		}

		

		public QuotientI eval(QuotientI arg, QuotientI arg1)
		{
			return new nilnul.num.Quotient(
				arg.numerator * arg1.denominator +arg.denominator*arg1.numerator
				,
				new nilnul.num_.Positive(
				arg.denominator*arg1.denominator
				)
			);

			throw new NotImplementedException();
		}

		public Quotient eval(Quotient arg, Quotient arg1)
		{
			return new nilnul.num.Quotient(
				arg.numerator * arg1.denominator +arg.denominator*arg1.numerator
				,
				new nilnul.num_.Positive(
				arg.denominator*arg1.denominator
				)
			);

			throw new NotImplementedException();
		}

		public Quotient1 combine(QuotientI1 arg, Quotient1 arg1)
		{
			return  nilnul.num.Quotient1.CreateByDivide(
				arg.numerator * arg1.denominator1 +arg.denominator1*arg1.numerator
				,
				new nilnul.num_.Positive1(
				arg.denominator1*arg1.denominator1
				)
			);

		}

		public Quotient1 op(Quotient1 arg, Quotient1 arg1)
		{
			return new nilnul.num.Quotient1(
				arg.numerator * arg1.denominator +arg.denominator*arg1.numerator
				,
				new nilnul.num_.Positive(
				arg.denominator*arg1.denominator
				)
			);

		}

		public Quotient1 combine(Quotient1 arg, Quotient1 arg1)
		{
			return  nilnul.num.Quotient1.CreateByDivide(
				arg.numerator * arg1.denominator +arg.denominator*arg1.numerator
				,
				
				arg.denominator*arg1.denominator
				
			);
		}
	}

	
}
