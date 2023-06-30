using nilnul.num.integer.be_.nonpos.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix_._floaty.xpn_
{
	/// <summary>
	/// <see cref="radix.be_._FarleftX"/>
	/// </summary>
	[Serializable]
	public class Farleft : Exception
	{
		public Farleft() { }
		public Farleft(string message) : base(message) { }
		public Farleft(string message, Exception inner) : base(message, inner) { }
		protected Farleft(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

		public static void Vow(num_.RadixI radix, Ee indic)
		{
			if (nonneg_.radix.be_._FarleftX.IsFarleftOf0precision1indic(radix,indic))
			{
				throw new Farleft(
					$"{indic}'s abs cannot exceed {radix}.gits.Count;"
				);  
			}
		}
	}
}