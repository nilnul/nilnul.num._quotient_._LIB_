using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.obj.stream_._slider._cursor_;
using N = nilnul._num.bigint.be.Natural.Asserted;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.slider_
{
	/// <summary>
	/// 1+1/n)^n
	/// </summary>
	public class EByExp :

		SliderI
		,
		nilnul.num.quotient.stream_.SliderI1
	{

		static public Quotient1 Func_oneBased(nilnul.num_.Positive1 index) => nilnul.num.quotient.op_.unary_.Poly.Eval(
			Quotient1.CreateOne() + nilnul.num.Quotient1.CreateUnit(index)
				,
				index
		);

		private N _index;

		public N index
		{
			get { return _index; }
			//set { _index = value; }
		}
		public EByExp()
		{
			_index = 1;
		}


		public Simplify.Ed1 current
		{
			get
			{
				return nilnul.num.quotient.op_.Poly.Eval(
					Q1.CreateOne() +nilnul.num.quotient.fro_.UnitFrac.Eval(  _index.val)
					,
					_index
				);
				//throw new NotImplementedException();
			}
		}

		

		public void moveNext()
		{
			_index++;
			//throw new NotImplementedException();
		}

		public Quotient1 next()
		{
			throw new NotImplementedException();
		}
	}
}
