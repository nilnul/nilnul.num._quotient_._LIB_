using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient.radix
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>recurring, cyclic, repeating, recurring...</remarks>
	public partial class Recur
		: _radix_.AmplifierI
	{

		private Radix _radix;

		public Radix radix
		{
			get { return _radix; }
			set { _radix = value; }
		}

		private nilnul.num.natural.Natural_bigInteger _recurSpan;
		public nilnul.num.natural.Natural_bigInteger recurSpan
		{
			get { return _recurSpan; }
			set { _recurSpan = value; }
		}


		public BigInteger significand
		{
			get
			{

				return _radix.significand;

			}
		}

		public BigInteger radixAsBigInt
		{
			get
			{
				return _radix.baseAsBigInt;
			}
		}

		public BigInteger indexAsBigInt
		{
			get
			{
				return _radix.index;
			}
		}
		public int indexAsInt
		{
			get
			{
				return _radix.indexAsInt;
			}
		}



		public int sign
		{
			get
			{
				return significand.Sign;
			}
		}

		public BigInteger magnitudeAsBigInt
		{
			get
			{
				return BigInteger.Abs(significand);
			}
		}


		public BigInteger recurSpanAsBigInt
		{
			get { return _recurSpan.val; }
			set
			{
				this._recurSpan = new natural.Natural_bigInteger(value);
			}
		}
		[Obsolete()]
		public int recurSpanAsInt
		{
			get { return (int)_recurSpan.val; }
			set
			{
				this._recurSpan = new natural.Natural_bigInteger(value);
			}
		}


		public BigInteger amplifier
		{
			get
			{
				return _radix.significand;

				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// return the string of digits inside the recuring scope.
		/// </summary>
		/// <returns>
		///		
		/// </returns>
		/// <example>
		///  12345123.(45123)  here 45123 as an integer is the returned.
		/// </example>

		public BigInteger recurPart()
		{
			return _radix.significand % nilnul.num.natural.op.PowX2.Do_basePlural_indexNonNeg(_radix.base_.val, recurSpan.val);
		}

		public override string ToString()
		{
			return toTxt1();
		}

		public string ToStr()
		{
			if (recurSpan == 0)
			{
				return _radix.ToString();//.toStr_linear_0_prepended2();
			}
			var magStr = nilnul.num.natural.op.ToStrX.Do(magnitudeAsBigInt, radixAsBigInt);
			if (magStr.Length < recurSpanAsInt)
			{
				magStr = magStr.PadLeft(recurSpanAsInt, '0');
			}
			var recurPartStr = magStr.Substring(
				magStr.Length - (int)recurSpanAsBigInt
				, recurSpanAsInt
			);
			var unRecur = magStr.Length - recurPartStr.Length;
			var suffix = magStr.Substring(0, unRecur);
			var index = this.indexAsInt;
			index += recurSpanAsInt;
			while (index > 0)
			{
				index -= recurPartStr.Length;
				suffix += recurPartStr;
			}
			var offset = suffix.Length + index;
			if (offset <= 0)
			{
				suffix = "0." + nilnul.obj.str.X.Repeat(0, -(offset)) + suffix;// +magStr;// +significandStr;
			}
			else
			{
				suffix = suffix.Insert(offset, ".");
			}
			suffix += "(" + recurPartStr + ")";
			return (sign < 0 ? "-" : "") + suffix;
		}
		public const string separatorForLatterCycle = "(";

		/// <summary>
		/// check whether the recurpart only happens after Dot.
		/// </summary>
		/// <returns></returns>
		/// 
		[Obsolete()]
		public string toTxt()
		{
			if (recurSpan == 0)
			{
				return _radix.ToString();//.toStr_linear_0_prepended2();
			}
			var magStr = nilnul.num.natural.op.ToStrX.Do(magnitudeAsBigInt, radixAsBigInt);
			if (magStr.Length < recurSpanAsInt)
			{
				magStr = magStr.PadLeft(recurSpanAsInt, '0');
			}
			var recurPartStr = magStr.Substring(
				magStr.Length - (int)recurSpanAsBigInt
				, recurSpanAsInt
			);
			var unRecur = magStr.Length - recurPartStr.Length;
			var suffix = magStr.Substring(0, unRecur);
			var index = this.indexAsInt;
			index += recurSpanAsInt;
			while (index > 0)
			{
				index -= recurPartStr.Length;
				suffix += recurPartStr;
			}
			var offset = suffix.Length + index;
			if (offset <= 0)
			{
				suffix = "0." + nilnul.obj.str.X.Repeat(0, -(offset)) + suffix;// +magStr;// +significandStr;
			}
			else
			{
				suffix = suffix.Insert(offset, ".");
			}
			suffix += separatorForLatterCycle + recurPartStr;
			return (sign < 0 ? "-" : "") + suffix;
		}

		public string toTxt1()
		{
			#region supposing that Radix is standardized: with a dot somewhere; and that the recur only occurs after dot.


			#endregion
			if (recurSpan == 0)
			{
				return _radix.ToString();//.toStr_linear_0_prepended2();
			}

			var sb = 
					_radix.toTxt_noSign_dotInserted_noZeroPrepend()
			;
			#region insert recur enclosing



			sb.Insert(sb.Length-recurSpanAsInt,separatorForLatterCycle);

			#endregion

			if (sb.First()==Radix.DOT)
			{
				sb.Prepend('0');


			}
			sb.Prepend(sign<0?"-":"");

			return sb.ToString();


		}

		//public  string ToStr_decimal()
		//{
		//	if (recurSpan == 0)
		//	{
		//		return _float.toStr_linear_0_prepended();
		//	}
		//	var magStr = magnitudeAsBigInt.ToString();
		//	if (magStr.Length < recurSpanAsInt)
		//	{
		//		magStr = magStr.PadLeft(recurSpanAsInt, '0');
		//	}
		//	var recurPartStr = magStr.Substring(
		//		magStr.Length - (int)recurSpanAsBigInt
		//		, recurSpanAsInt
		//	);
		//	var unRecur = magStr.Length - recurPartStr.Length;
		//	var suffix = magStr.Substring(0, unRecur);
		//	var index = this.indexAsInt;
		//	index += recurSpanAsInt;
		//	while (index > 0)
		//	{
		//		index -= recurPartStr.Length;
		//		suffix += recurPartStr;
		//	}
		//	var offset = suffix.Length + index;
		//	if (offset <= 0)
		//	{
		//		suffix = "0." + nilnul.obj.str.X.Repeat(0, -(offset)) + suffix;// +magStr;// +significandStr;
		//	}
		//	else
		//	{
		//		suffix = suffix.Insert(offset, ".");
		//	}
		//	suffix += "(" + recurPartStr + ")";
		//	return (sign < 0 ? "-" : "") + suffix;
		//}

		public string ToMathMl()
		{
			throw new NotImplementedException();
		}

		public string ToStr_func()
		{
			return string.Format("nilnul.num.rational.float_.Periodic({0},{1},{2})", radixAsBigInt, _radix.toStr_func(), recurSpan);

			throw new NotImplementedException();
		}



		public Recur()
			: this(2, 0, 0, 0)
		{


		}

		private Recur(Radix radix, BigInteger _natural_recurSpan)
		{
			this.radix = radix;
			this.recurSpanAsBigInt = _natural_recurSpan;



		}


		public Recur(Radix float_, natural.Natural_bigInteger recurSpan_natural)
		{
			this.radix = float_;
			this._recurSpan = recurSpan_natural;



		}



		public Recur(BigInteger radix_plural, BigInteger significand, BigInteger index, BigInteger recurSpan_natural)
			: this(new Radix(radix_plural, significand, index), recurSpan_natural)
		{

		}

		public Recur(BigInteger radix_plural, SignificandIndex float_, BigInteger recurSpan_natural)
			: this(new Radix(radix_plural, float_), recurSpan_natural)
		{

		}

		/// <summary>
		/// let 03.09(99) be 03.09+.01
		/// </summary>
		public void foldRimmings()
		{


		}

		static public bool LessThanOne(Radix p)
		{

			///

			return p.toRational() < 1;

			throw new NotImplementedException();


		}

		static public bool IsNonNegative(Radix p)
		{

			///

			return p.toRational() >= 0;

			throw new NotImplementedException();


		}


		public void set(BigInteger finite, Radix recur)
		{

			///assert finite as 
			///



		}
		[Obsolete()]
		public Q toRational()
		{
			return ToRational(this);

		}
		[Obsolete()]
		static public Q ToRational(
			Recur p
			)
		{

			var recurPart = p.recurPart();

			return (p.significand - recurPart) * nilnul.num.quotient.op.PowX.Eval_basePlural_retQ(p.radixAsBigInt, p.indexAsBigInt)
				+

				nilnul.num.quotient.Q.Divide(
					recurPart
					,
					nilnul.num.int_.op.PowX.Eval_basePlural_indexNoNeg(p.radixAsBigInt, p.recurSpanAsBigInt) - 1
				)
				*
				  nilnul.num.quotient.op.PowX.Eval_basePlural_retQ(p.radix.base_.val, (p.recurSpan

				  +
					p.indexAsBigInt     //this is usually negative.

				  ))
			;


		}
		[Obsolete()]
		static public Recur FroRational(Q r)
		{
			return FroRational(10, r);
		}

		[Obsolete()]
		static public Recur FroRational_binary(Q r)
		{
			return FroRational(2, r);
		}

		[Obsolete()]
		static public Recur Q2Recur_binary(Q q, BigInteger digitsAfterPoint_natural)
		{
			return Quotient2Recur(2, q, digitsAfterPoint_natural);
		}

		[Obsolete()]
		static public Recur Q2Recur_decimal(Q q, BigInteger digitsAfterPoint_natural)
		{
			return Quotient2Recur(10, q, digitsAfterPoint_natural);
		}

		[Obsolete()]
		static public Recur Quotient2Recur(BigInteger root, Q q, BigInteger digitsAfterPoint_natural)
		{


			var intProper = Q.ToIntAndTail(q);

			BigInteger significand = intProper.Item1;
			BigInteger remainder = intProper.Item2.numerator;

			List<BigInteger> remainders = new List<BigInteger>();
			List<Q> propers = new List<Q>();

			BigInteger quotient;

			BigInteger recurSpan = -1;
			BigInteger index = 0;

			while (recurSpan == -1)
			{
				if (digitsAfterPoint_natural > 0)
				{
					if (remainder == 0)
					{
						//recurSpan = 0;
						return new Recur(root, significand, index, 0);
					}
					remainders.Add(remainder);
					//quotient = BigInteger.DivRem(remainder * radix_plural, r.denominatorAsBigInt, out remainder);
					significand = significand * root
						+ BigInteger.DivRem(remainder * root, q.denominatorAsBigInt, out remainder);    //remainder &isin; [0,  denominator)
					index--;
					recurSpan = remainders.IndexOf(remainder);
					digitsAfterPoint_natural--;
				}
				else
				{
					return new Recur(root, significand, index, 0);
				}
			}

			return new Recur(root, significand, index, remainders.Count - recurSpan);



		}

		[Obsolete()]
		static public Recur FroRational(BigInteger radix_plural, Q r)
		{
			var intProper = Q.ToIntAndTail(r);
			BigInteger significand = intProper.Item1;
			BigInteger remainder = intProper.Item2.numerator;

			List<BigInteger> remainders = new List<BigInteger>();
			List<Q> propers = new List<Q>();

			BigInteger quotient;

			BigInteger recurSpan = -1;
			BigInteger index = 0;

			while (recurSpan == -1)
			{
				if (remainder == 0)
				{
					recurSpan = 0;
					return new Recur(radix_plural, significand, index, 0);

				}

				remainders.Add(remainder);
				//quotient = BigInteger.DivRem(remainder * radix_plural, r.denominatorAsBigInt, out remainder);
				significand = significand * radix_plural
					+ BigInteger.DivRem(remainder * radix_plural, r.denominatorAsBigInt, out remainder);    //remainder &isin; [0,  denominator)

				index--;
				recurSpan = remainders.IndexOf(remainder);

			}

			return new Recur(radix_plural, significand, index, remainders.Count - recurSpan);


			throw new NotImplementedException();

		}

		/// <summary>
		/// to a recur till the precision is reached
		/// </summary>
		/// <param name="_radix__plural"></param>
		/// <param name="x"></param>
		/// <returns></returns>

		static public Recur _FroQuotient(BigInteger _radix__plural, Q1 x,BigInteger _natural__digitsAfterDo)
		{
			const int TO_BE_FOUND = -1;

			var mixedFrac = q.be.Proper.En.ToMixedFrac(x);

			BigInteger multiplier = mixedFrac.Item1;
			BigInteger exponent = 0;

			List<BigInteger> remainders = new List<BigInteger>();
			BigInteger remainder = mixedFrac.Item2.numerator;

			BigInteger recurPosition = TO_BE_FOUND;

			while (recurPosition == TO_BE_FOUND)
			{
				if (_natural__digitsAfterDo-- <=0)
				{
					break;
				}

				if (remainder == 0)
				{
					///0 is added to the remainder; 0 will repeat for ever; and the recurFound is the last position; recurSpan is the length one. This reduces to :  no 0 is added, and ---
					recurPosition = remainders.Count;

				}
				else
				{
					remainders.Add(remainder);

					multiplier = multiplier * _radix__plural
						+ BigInteger.DivRem(remainder * _radix__plural, x.denominator.val, out remainder);
					exponent--;

					recurPosition = remainders.IndexOf(remainder);

				}

			}

			if (recurPosition==TO_BE_FOUND)
			{
				return new Recur(_radix__plural, multiplier, exponent, 0);

			}
			var recurSpan = remainders.Count - recurPosition;
			if (recurSpan==0)
			{
				var radix = new Radix(
					
					_radix__plural, multiplier, exponent
				);

				radix.appendZero(   );

				return new Recur(  radix, 1);

			}

			return new Recur(_radix__plural, multiplier, exponent, recurSpan);
		}


		/// <summary>
		/// todo:
		/// </summary>
		/// <param name="_radix__plural"></param>
		/// <param name="x"></param>
		/// <returns></returns>
		static public Recur _FroQuotient(BigInteger _radix__plural, Q1 x)
		{
			const int TO_BE_FOUND = -1;

			var mixedFrac = q.be.Proper.En.ToMixedFrac(x);

			BigInteger multiplier = mixedFrac.Item1;
			BigInteger exponent = 0;

			List<BigInteger> remainders = new List<BigInteger>();
			BigInteger remainder = mixedFrac.Item2.numerator;

			BigInteger recurPosition = TO_BE_FOUND;

			while (recurPosition ==TO_BE_FOUND)
			{
				if (remainder == 0)
				{
					///0 is added to the remainder; 0 will repeat for ever; and the recurFound is the last position; recurSpan is the length one. This reduces to :  no 0 is added, and ---
					recurPosition = remainders.Count;

				}
				else
				{
					remainders.Add(remainder);

					multiplier = multiplier * _radix__plural
						+ BigInteger.DivRem(remainder * _radix__plural, x.denominator.val, out remainder); 
					exponent--;

					recurPosition = remainders.IndexOf(remainder);

				}

			}

			return new Recur(_radix__plural, multiplier, exponent, remainders.Count - recurPosition);
		}

		/// <summary>
		/// get all the remainders, till a cycle formed.
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <returns></returns>
		/// 
		[Obsolete("better to get the integer part into calculation as a whole")]
		static public Recur _FroProper(BigInteger _radix_plural, be.Proper.En proper)
		{
			const int NOT_FOUND = -1;


			List<BigInteger> remainders = new List<BigInteger>() { };
			BigInteger remainder = proper.numerator;// intProper.Item2.numerator;

			BigInteger recurFound = NOT_FOUND/* remainders.IndexOf(remainder)*/;

			BigInteger multiplier = 0;
			BigInteger exponent = 0;

			while (recurFound == NOT_FOUND)
			{

				if (remainder == 0)
				{
					///0 is added to the remainder; 0 will repeat for ever; and the recurFound is the last position; recurSpan is the length one. This reduces to :  no 0 is added, and ---
					recurFound = remainders.Count;
				}
				else
				{
					remainders.Add(remainder);

					multiplier = 
						multiplier * _radix_plural
						+ 
						BigInteger.DivRem(
							remainder * _radix_plural,									proper.denominator.val, 
							out remainder
						)
					;  
					exponent--;	//this offsets the effect of multiplier*_radix

					recurFound = remainders.IndexOf(remainder);

				}

			}

			return new Recur(_radix_plural, multiplier, exponent, remainders.Count - recurFound);
		}
	}
}
