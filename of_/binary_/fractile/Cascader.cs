using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.of_.binary_.fractile
{
	/// <summary>
	/// eg:
	///		for 1,2,3,..., this would convert that to:  1+1/2+1/3+..= 11/6 +...
	///		for 3,2,1, this would be: 3+1/2+1/1 = 9/2
	/// </summary>
	public  class Cascader
		:

		quotient.of_.binary.cascader_.OpDefault<Fractile>
	{


		static public Cascader Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Cascader>.Unison;
			}
		}

	}
}
