using nilnul.obj.stream_._slider._skim_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile.convergents_.plural_._slider
{


	public class Dividends
		:
		
		nilnul.obj.stream_.ISlider
		,
		obj.stream_._slider._skim_.CurrentI<BigInteger>
		//,
		//obj.stream_.slider_.preview_.AheadI
		//<
		//	(BigInteger,BigInteger) // or frac
		//>
		//,
		//nilnul.num.quotient_.denomNonnil.stream_.SliderI

	{
		BigInteger _current;
		public BigInteger current => _current;
		BigInteger _ahead=1;
		public BigInteger ahead => _ahead;


		private Dividends(in BigInteger current_, in BigInteger ahead_) 
		{
			_current =current_;

			_ahead =ahead_;

		}

		static public Dividends OfAdders(BigInteger adder0, BigInteger adder1) {
			return new Dividends(
				adder0
				,
				adder1
				*
				adder0 //also current
				+1 // previous =1
			);
		}






		//public DenomNonnil next()
		//{
		//	return nilnul.obj.stream_._slider.CursorX.Next(this);
		//	//throw new NotImplementedException();
		//}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="adder2">
		/// current adder is adder0, next adder is adder1, this adder2;
		/// </param>
		public void moveNext(
			BigInteger adder2
		)
		{
			var next2 = adder2 * _ahead + _current;
			_current = _ahead;
			_ahead = next2;
		}
	}
}
