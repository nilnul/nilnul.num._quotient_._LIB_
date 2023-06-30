using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.fractile.convergent_._seriesly
{

	/// <summary>
	/// the slider for the series;
	/// </summary>
	public class Stream
		:
		nilnul.obj.Box_ofIn<
			nilnul.obj.stream_.slider_.preview_.Peek<BigInteger>
		>
		,
		nilnul.obj.IStream
		//<
		//	(BigInteger,BigInteger) // or frac
		//>
		,
		nilnul.num.quotient_.denomNonnil.StreamI

	{

		nilnul.bit.stream_.slider_.Alter _sign=new bit.stream_.slider_.Alter();


		nilnul.num.quotient_.fractile.to_.quotiently_._cascade._slider.Denominators _denominators;

		/// <summary>
		/// the adders; assume it's plural;
		/// </summary>
		/// <param name="val">
		/// plural;
		/// </param>

		public Stream(nilnul.obj.stream_.slider_.preview_.Peek<BigInteger> val) : base(val)
		{
			_denominators = nilnul.num.quotient_.fractile.to_.quotiently_._cascade._slider.Denominators.OfAdders( val.ahead);

			_current = val.current; //a0
		}


		public Stream(IEnumerable<BigInteger> x) :this(new obj.stream_.slider_.preview_.Peek<BigInteger>(x))
		{
		}

		static public Stream _Of_0started(IEnumerable<int> x) 
		{
			return new Stream(
				x.Select(
					t=>(BigInteger)t
				)
			);
		}

		private DenomNonnil _current;


		/// <summary>
		/// </summary>
		/// <remarks>
		/// </remarks>
		public DenomNonnil current =>_current;

		public DenomNonnil next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
		}

		public void moveNext()
		{
			_sign.moveNext();
			_current =  nilnul.num.quotient_.DenomNonnil.Inverse(
				_sign.current?   boxed.current * boxed.ahead :  -boxed.current * boxed.ahead
			);

			boxed.moveNext();
			_denominators.moveNext(
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
