using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.of_.binary_
{
	/// <summary>
	/// a+1/b
	/// used in fractile<see cref="quotient_.fractile_"/>;
	/// </summary>
	/// <remarks>
	/// it's not commutable;
	/// it's not associable:
	///		eg:
	///			1 +~ 2 +~ 3 vs 1 +~ (2+~3)
	///			1+1/2 +1/3  vs 1+ 1/(2+1/3) 
	///			11/6		vs 7/4.
	///		so for the latter, the computation is like to reverse the str, and the apply the unconversed operator; <seealso cref="nilnul.obj.op_.binary.converse.cumulator.cumulate_"/>
	///		when used to <see cref="str_.started.scala_"/>, we specifiy this or its converse:<see cref="fractile.converse"/>; generally its interpreted as right associative;
	/// </remarks>
	static public class _FractileX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		/// <exception cref="DivideByZeroException">
		/// if y is 0;
		/// </exception>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public num.quotient_.DenomNonnil Fractile(
			num.quotient_.DenomNonnil x, num.quotient_.DenomNonnil y
		)
		{
			return x + 1 / y;
		}


	}

	public class Fractile : of_.BinaryA
	{
		public override DenomNonnil op(DenomNonnil par, DenomNonnil par1)
		{
			return _FractileX.Fractile(par, par1);
		}

		public override string ToString()
		{
			/// where ~ is the inverse operator:<see cref="of_.unary_.Inverse"/>
			return "+~";
		}


		static public Fractile Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Fractile>.Unison;
			}
		}


		

	}



}
