using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider_
{
	public class WallisProduct4HalfPi:SliderI
	{
		private SliderI _form;

		public SliderI form
		{
			get { return _form; }
			set { _form = value; }
		}

		public Simplify.Ed1 current
		{
			get
			{
				return _form.current;
				//throw new NotImplementedException();
			}
		}

		public WallisProduct4HalfPi()
		{

			_form =new fro_.Func(
				(k)=> {
					var kPlus = k;
					var Four_kPlusSquare = nilnul.num.op_.Square.Eval(kPlus) *4;

					
					return  nilnul.num.quotient.duo_.dividable.op_._divide. Extensions.Divide( 
						Four_kPlusSquare,		
						Four_kPlusSquare-1
					);
				}	
			);


		}

		public void moveNext()
		{
			_form.moveNext();
		//	throw new NotImplementedException();
		}
	}
}
