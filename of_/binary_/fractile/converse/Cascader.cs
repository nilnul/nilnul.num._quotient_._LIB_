using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.of_.binary_.fractile.converse
{
	/// <summary>
	/// eg:
	///		for 3,2,1,... this will convert that into:
	///			1/(1/3+2) +1
	///		for 1,2,3..., it will become: 1/(1/1+2)+3 +... = 10/3
	/// We can see fom here that <see cref="integer.str_.started_.nonhead8positive._IFractile"/> is to reverse a str 1st before to apply this.
	/// 
	/// </summary>
	/// <remarks>
	/// this can be written like:
	///		1 +~ 2 +~ 3
	///			where the operator is right associative, and the expr shall not be interpreted as
	///				(1+~1/2) +~1/3   =11/6
	///			but as:
	///				1 +~ (2+~3) =7/4
	///			 the computation is like to reverse the str, and the apply the unconversed operator; <seealso cref="nilnul.obj.op_.binary.converse.cumulator.cumulate_"/>
	///
	///    
	/// </remarks>

	public class Cascader
		:

		quotient.of_.binary.cascader_.OpDefault<fractile.Converse>
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
