using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.floaty_.dec.to_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// alias:
	///		finite
	///		
	static public class _RationableX
	//:quotient_.radix.ext.errable_.ieee_.IBin
	{
		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		/// alias:
		///		significAndIndic
		static public _radix.basic.indiced.significed_.Dec _ToSignificed_assumeValid(decimal x)
		{

			var bits = _DecX.BitsAsInts(x);

			var uints = bits.Select(
				x1 =>
				BitConverter.ToUInt32(
					BitConverter.GetBytes(
						x1
					), 0
				)
			//Convert.ToUInt32(x)
			);

			var toed = nilnul.obj.str_.started._Main1toeX.Main1toe(uints);

			BigInteger precision = 0;
			foreach (var item in toed.Item1.Reverse())
			{
				precision += precision * uint.MaxValue + item;
			}

			var ponent =( toed.Item2 & 0x00ff_0000u )>> 16;


			return new _radix.basic.indiced.significed_.Dec(
				
				toed.Item2 > int.MaxValue? -precision:precision
				,
				-ponent
			);

		}




	}
}
