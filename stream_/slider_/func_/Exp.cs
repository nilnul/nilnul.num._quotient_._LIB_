using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.obj.stream_._slider._cursor_;
using N = nilnul._num.bigint.be.Natural.Asserted;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.stream_.slider_.func_
{
	/// <summary>
	/// (1+1/n)^n, where n = 1,2,...
	///  n is the nearer, the term is bigger.
	/// 
	/// </summary>
	public class ExpTerm :
		nilnul.num.quotient.stream_.SliderA1,
		
		nilnul.num.quotient.stream_.SliderI1
	{

		static public Quotient1 Func_oneBased(nilnul.num_.Positive1 index) => nilnul.num.quotient.op_.unary_.Poly.Eval(
			Quotient1.CreateOne() + nilnul.num.Quotient1.CreateUnit(index)
				,
				index
		);

		static public Quotient1 _Func_oneBased(nilnul.Num1 _index_oneBased) => nilnul.num.quotient.op_.unary_.Poly.Eval(
			Quotient1.CreateOne() + nilnul.num.Quotient1.CreateUnit(_index_oneBased)
				,
				_index_oneBased
		);


		private N _index;

		public N index
		{
			get { return _index; }
			//set { _index = value; }
		}

		public override Quotient1 current => _Func_oneBased(indexes.current);

		nilnul.num.stream_.slider_.Nat indexes=new num.stream_.slider_.Nat();
		public ExpTerm()
		{
			_index = 1;
			indexes.moveNext();
		}


	

		
		public override void moveNext()
		{
			indexes.moveNext();
		}
	}
}
