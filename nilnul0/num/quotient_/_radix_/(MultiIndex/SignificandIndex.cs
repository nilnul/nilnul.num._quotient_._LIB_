using nilnul.bit;
using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.quotient._radix
{

	/// <summary>
	/// 
	/// </summary>
	public class SignificandIndex
		: _radix_.AmplifierI
	{
		/// <summary>
		/// the -123 in  -123* e ^ -45
		/// </summary>
		/// alias:
		///		gits
		///			
		private BigInteger _significand;

		public BigInteger significand
		{
			get { return _significand; }
			set { _significand = value; }
		}
		private BigInteger _index;

		/// <summary>
		/// the -45 in 123 * e ^-45
		/// </summary>
		public BigInteger index
		{
			get { return _index; }
			set { _index = value; }
		}
		public SignificandIndex(BigInteger s, BigInteger i)
		{
			this._significand = s;
			this._index = i;

		}
		public SignificandIndex(BigInteger significand)
			:this(significand,0)
		{

		}
		public SignificandIndex(
			SignificandIndex si
			)
			: this(si._significand, si._index)
		{

		}

		public int signAsInt
		{
			get { return significand.Sign; }
		}

		public BigInteger amplifier
		{
			get
			{
				return significand;
				throw new NotImplementedException();
			}
		}

		public void negate()
		{
			_significand = -_significand;
		}

		public SignificandIndex toNegate()
		{
			var r = new SignificandIndex(this);
			r.negate();
			return r;

		}

		static public SignificandIndex Square(SignificandIndex a) {
			return new SignificandIndex(a._significand * a._significand, a.index * 2);
		}




		static public SignificandIndex Subtract(
			BigInteger radix_plural,
			SignificandIndex a,

			SignificandIndex b

		)
		{

			return _Add(radix_plural, a, b.toNegate());



		}



	

		static public SignificandIndex _Add(BigInteger radix_plural,

			SignificandIndex a, SignificandIndex b
		)
		{

			if (b.index < a.index)
			{
				return _Add_smallerFirst(radix_plural, b, a);
			}
			return _Add_smallerFirst(radix_plural, a, b);


			throw new NotImplementedException();

		}



		static public SignificandIndex _Add_smallerFirst(BigInteger radix_plural, SignificandIndex _powerSmaller, SignificandIndex powerMax)
		{


			var t = powerMax.index - _powerSmaller.index;

			return new SignificandIndex(


				powerMax.significand * nilnul.num.natural.op.PowX2.Do_basePlural_indexNonNeg(radix_plural, t) + _powerSmaller.significand
				,
				_powerSmaller.index

			);


		}








	}
}