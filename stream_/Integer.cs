using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using System.Numerics;

namespace nilnul.num.quotient.stream_
{
	public class Integer : 
		nilnul.obj.Box<nilnul.num.integer.StreamI>
		,
		StreamI6
	{


		public Integer(nilnul.num.integer.StreamI integerStream):base(integerStream)
		{

		}



		public Quotient1 next()
		{
			return (boxed.next());

			//throw new NotImplementedException();
		}

		static public Integer OvAltSign( ) {
			return new Integer(
				new nilnul.num.integer.stream_.alterSign.InInt()
			);
	}
	}
}
