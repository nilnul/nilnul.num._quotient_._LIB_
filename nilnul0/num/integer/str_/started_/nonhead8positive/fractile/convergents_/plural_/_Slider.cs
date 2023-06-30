using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile.convergents_.plural_
{

	/// <summary>
	/// for plural of adders; as the underlying adders are not stream, this is an awkward implementation in comparsion with <see cref="num.quotient_.fractile._convergent._Divisors"/> and <see cref="num.quotient_.fractile.IConvergent"/>;
	/// this might be less awkard for <see cref="quotient.stream_.IFractile"/>
	/// </summary>
	public class _Slider
		:
		nilnul.obj.Box_ofIn<
			nilnul.obj.stream_.slider_.preview_.Peek<BigInteger>
		>
		,
		nilnul.obj.stream_.ISlider
		//<
		//	(BigInteger,BigInteger) // or frac
		//>
		,
		nilnul.num.quotient_.denomNonnil.stream_.SliderI

	{
	

		_slider.Dividends _uppers;

		_slider.Divisors _lowers;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">
		/// plural;
		/// </param>

		public _Slider(nilnul.obj.stream_.slider_.preview_.Peek<BigInteger> val) : base(val)
		{
			_uppers =  _slider.Dividends.OfAdders(val.current, val.ahead);
			_lowers =  _slider.Divisors.OfAdders( val.ahead);
		}


		public _Slider(IEnumerable<BigInteger> x) :this(new obj.stream_.slider_.preview_.Peek<BigInteger>(x))
		{
		}

		static public _Slider _Of_0plural(IEnumerable<int> x) 
		{
			return new _Slider(
				x.Select(
					t=>(BigInteger)t
				)
			);
		}


		/// <summary>
		/// current is: a0,1
		/// </summary>
		/// <remarks>
		/// previouse is 1,0; as 1/0 =+inf, and we know the value is between (+inf, a0/1]
		/// </remarks>
		public DenomNonnil current =>new DenomNonnil( _uppers.current,_lowers.current);
		public DenomNonnil ahead =>new DenomNonnil( _uppers.ahead,_lowers.ahead);

		public DenomNonnil next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
		}

		public void moveNext()
		{
			boxed.moveNext();
			_uppers.moveNext(
				boxed.ahead
			);
			_lowers.moveNext(
				boxed.ahead
			);
		}

		/// <summary>
		/// the current index is 0 initially; we can move to index n-2, where ahead is n-1, the end;
		/// </summary>
		/// <param name="n"></param>
		public void _move_0ltLastIndex(int n) {
			if (n==0)
			{
				return;
			}
			while (n-- >0)
			{
				moveNext();
			}
		}



	}
}
