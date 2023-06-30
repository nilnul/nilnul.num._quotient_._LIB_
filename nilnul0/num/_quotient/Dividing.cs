using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._quotient
{
	/// <summary>
	/// the underneath can be zero. To bypass the check, the computation can be fast.
	/// </summary>
	/// alias:
	///		ratio
	///			eg:
	///				3:0
	public readonly struct Dividing
	{
		/// <summary>
		/// note this is different from <see cref="nilnul.num._quotient.dividing_.Frac.DividerSign"/>
		/// </summary>
		public const char DividerSign = '\\';

		private readonly BigInteger _numerator;

		public readonly BigInteger numerator
		{
			get { return  _numerator; }
			//set { _numerator = value; }
		}

		public readonly BigInteger _denominator;

		public readonly BigInteger denominator
		{
			get { return _denominator; }
			//set { _denominator = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="numerator"></param>
		/// <param name="denominator">might be nil</param>
		public Dividing(in BigInteger numerator,in  BigInteger denominator)
		{
			_numerator = numerator;
			_denominator = denominator;

		}
		public Dividing(in BigInteger numerator) : this(in numerator, 1)
		{

		}

	

		/*Beginning with C# 10, a structure type can contain an explicit parameterless constructor. For more information, see the Parameterless constructors and field initializers section of the Structure types article.*/

		public static void Add(
			in BigInteger numerabor, in BigInteger denominator, in BigInteger yNum, in BigInteger yDen
			,
			out (BigInteger, BigInteger) r
			)
		{
			r =
			  (
				numerabor * yDen
				+
				yNum * denominator
				,
				denominator * yDen
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static
			 (BigInteger, BigInteger) Add(
			in BigInteger numerabor, in BigInteger denominator, in BigInteger yNum, in BigInteger yDen

			)
		{
			return
			  ( 
				numerabor * yDen
				+
				yNum * denominator
				,
				 denominator * yDen
			);
		}

		public static  Dividing operator +(in Dividing x, in Dividing y)
		{
			return new Dividing(
				x._numerator * y._denominator + y._numerator * x._denominator
				,
				x._denominator*y._denominator
			);

		

		}

		public static  Dividing operator +(in Dividing x,in int y)
		{
			return new Dividing(
				x._numerator  + y * x._denominator
				,
				x._denominator
			);

		

		}



		public static Dividing operator *(in Dividing x,in Dividing y)
		{
			return new Dividing(
				x._numerator * y._numerator
				,
				x._denominator * y._denominator
			);
		}

		public static Dividing operator -(in Dividing x)
		{
			return new Dividing(
				
				-x._numerator
				,
				x._denominator
			);
		}
		public static Dividing operator -(in Dividing x, in Dividing y)
		{
			return new Dividing(
				x._numerator * y._denominator - y._numerator * x._denominator
				,
				x._denominator * y._denominator
			);
		}

		public static Dividing operator -(in Dividing x, int y)
		{
			return x + -y;
		}

		/// <summary>
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public static Dividing Inverse(in Dividing x)
		{
			/// if original is exception, then the exception should propagate.
			//if (x._denominator == 0)
			//{
			//	throw new DivideByZeroException();
			//}

			///if the numerator is 0, the exception is deferred.
			return new Dividing(x._denominator, x._numerator);
		}

		public static Dividing operator /(in Dividing x, in Dividing y)
		{
			return x * Inverse(y);
		}
		public  bool isNil()
		{
			return (_numerator == 0);
		}

		public static bool IsNil(in Dividing x)
		{
			///exception or nil
			return (x._numerator == 0);
		}

		public static bool operator ==(in Dividing x, in Dividing y)
		{
			return (x - y).isNil();
		}

		public static bool operator ==(in Dividing x, in int y)
		{
			return (x - y).isNil();
		}

		public static bool operator !=(in Dividing x, in Dividing y)
		{
			return !(x == y);
		}
		public static bool operator !=(in Dividing x,in int y)
		{
			return !(x == y);
		}

		//public void simplify() {
		//	var gcd = nilnul.num.integer.duo.op.Gcd.Eval_retN1(numerator, denominator);
		//	_numerator /= gcd;
		//	_denominator = new integer.be_.nonnil.En( _denominator/  gcd.val);

		//}

		public override string ToString()
		{
			return $"{_numerator}/{_denominator}";
		}


		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Dividing Parse(string s)
		{

			///first find the /
			///
			/// 
			string[] terms = s.Split(DividerSign);

			switch (terms.Length)
			{
				case 0:
					return new Dividing();
				case 1:
					return new Dividing(
						BigInteger.Parse(terms[0])
					);
				case 2:
					return new Dividing(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));

				default:
					throw new Exception(
						string.Format("There are more than two terms sperated by {0}.", DividerSign)
					);
					break;
			}

		}

		static public bool TryParse(string s, out Dividing result)
		{

			try
			{
				result = Parse(s);
				return true;
			}
			catch (Exception)
			{
				result = default(Dividing); //null
				return false;

			}

		}



	}
}
