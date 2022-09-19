using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream_.slider_.unital_
{
	public class Even :
		nilnul.num.quotient.stream_.SliderA1

		//SliderI2
		,
		nilnul.obj.stream_.slider_._FuncI
	{


		private nilnul.num.stream_.slider_.even.Dehead _odd=new num.stream_.slider_.even.Dehead();

		public nilnul.num.stream_.slider_.even.Dehead odd
		{
			get { return _odd; }
			set { _odd = value; }
		}

		public override Q1 current => Q1.CreateUnit(_odd.current);

		public Even()
		{

		}

		public override void moveNext()
		{
			odd.moveNext();

		}

		public void setIndex(Num1 num)
		{
			_odd.setIndex(num);
		//	throw new NotImplementedException();
		}

		public void moveNext(Num1 num)
		{
			_odd.moveNext(num);
		}
	}
}
