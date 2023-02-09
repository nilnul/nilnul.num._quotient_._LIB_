using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix
{
	/*
	 For example, an IEEE 754 single precision (32-bit) NaN would be encoded as

s111 1111 1xxx xxxx xxxx xxxx xxxx xxxx
In practice, the most significant bit from x is used to determine the type of NaN: "quiet NaN" or "signaling NaN" (

	 */
	/*many processors use little-endian storage for all types of data (integer, floating point),*/

	/// <summary>
	/// extended the radix to include inf and -inf; also denormalized the radix to include: -0, NaN 
	/// </summary>
	public interface IIeee
	{
	}
}
