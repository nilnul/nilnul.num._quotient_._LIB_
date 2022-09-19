using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.border.be_
{
	public class Invertible1 : nilnul.num.quotient.border.BeI1
	{

		public bool be(Border2 obj)
		{
			return obj.mark != 0;
		}


		static public Invertible1 Singleton
		{
			get
			{
				return nilnul.Singleton1<Invertible1>.Instance;
			}
		}



	}
}
