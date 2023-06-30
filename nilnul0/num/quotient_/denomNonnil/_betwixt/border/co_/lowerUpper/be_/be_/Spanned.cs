using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.border.co_.lowerUpper.be_
{
	public  class Spanned
		:lowerUpper.BeI
	{
	

		public bool be(LowerUpper obj)
		{
			return obj.lower.mark.ToImpl() < obj.upper.mark;
		}


		static public Spanned Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Spanned>.Instance;
			}
		}

	}
}
