using nilnul.bit;
using nilnul.num.natural;
using nilnul.num.quotient_._radix;
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
		,
		ISignific1indic
	{
		/// <summary>
		/// the -123 in  -123* e ^ -45
		/// </summary>
		/// <remarks>
		/// the leading zeros are not significand.
		/// </remarks>
		/// vs:
		///		<see cref="num.quotient_.radix_.IMantissa"/>, which doesnot include the part before the floating point;
		///		for a bicimal, this is in fact a number always start with 1 if it's not empty. (if it is empty, then it's about nil;)
		/// alias:
		///		gits
		///			
		private BigInteger _significand;

		/// <summary>
		/// 
		/// </summary>
		/// alias:
		///		significand
		///			it carries "sign"
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
		public BigInteger indic
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


		[Obsolete("amplifier shall be abs value, not signed;")]
		public BigInteger amplifier
		{
			get
			{
				return significand;
				throw new NotImplementedException();
			}
		}
		public BigInteger amplifier1
		{
			get
			{
				return BigInteger.Abs( significand );
				throw new NotImplementedException();
			}
		}

		public (BigInteger amplific,BigInteger indic) unsigned8duo { get {
				return (BigInteger.Abs(this.significand),this._index);
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

		public override string ToString()
		{
			return $"{this._significand}e{this.index}";
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