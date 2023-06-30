using nilnul.obj.stream_._slider._skim_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile.convergents_.plural_._slider
{

	public class Divisors
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


		 private Divisors(in BigInteger current_, in BigInteger ahead_) 
		{
			_current =current_;
			_ahead =ahead_;
		}

		static public Divisors OfAdders( BigInteger adder1) {
			return new Divisors(
				1 /// current
				,
				adder1 // adder1 * current+previous ,where prev= 0
				
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
