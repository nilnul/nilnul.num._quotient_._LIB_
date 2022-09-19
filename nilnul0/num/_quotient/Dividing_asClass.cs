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
	public  class Dividing_asClass
	{
		/// <summary>
		/// note this is different from <see cref="nilnul.num._quotient.dividing_.Frac.DividerSign"/>
		/// </summary>
		public const char DividerSign = '\\';

		private  BigInteger _numerator;

		public ref BigInteger numerator
		{
			get { return ref  _numerator; }
			//set { _numerator = value; }
		}

		public  BigInteger _denominator;

		public ref BigInteger denominator
		{
			get { return ref _denominator; }
			//set { _denominator = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="numerator"></param>
		/// <param name="denominator">might be nil</param>
		public Dividing_asClass(in BigInteger numerator,in  BigInteger denominator)
		{
			_numerator = numerator;
			_denominator = denominator;
		}

		public Dividing_asClass(in BigInteger numerator) : this(in numerator, 1)
		{

		}

		public Dividing_asClass():this(0)
		{

		}


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

		public static  Dividing_asClass operator +(in Dividing_asClass x, in Dividing_asClass y)
		{
			return new Dividing_asClass(
				x._numerator * y._denominator + y._numerator * x._denominator
				,
				x._denominator*y._denominator
			);

		

		}

		public static  Dividing_asClass operator +(in Dividing_asClass x,in int y)
		{
			return new Dividing_asClass(
				x._numerator  + y * x._denominator
				,
				x._denominator
			);

		

		}



		public static Dividing_asClass operator *(in Dividing_asClass x,in Dividing_asClass y)
		{
			return new Dividing_asClass(
				x._numerator * y._numerator
				,
				x._denominator * y._denominator
			);
		}

		public static Dividing_asClass operator -(in Dividing_asClass x)
		{
			return new Dividing_asClass(
				
				-x._numerator
				,
				x._denominator
			);
		}
		public static Dividing_asClass operator -(in Dividing_asClass x, in Dividing_asClass y)
		{
			return new Dividing_asClass(
				x._numerator * y._denominator - y._numerator * x._denominator
				,
				x._denominator * y._denominator
			);
		}

		public static Dividing_asClass operator -(in Dividing_asClass x, int y)
		{
			return x + -y;
		}

		/// <summary>
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public static Dividing_asClass Inverse(in Dividing_asClass x)
		{
			/// if original is exception, then the exception should propagate.
			//if (x._denominator == 0)
			//{
			//	throw new DivideByZeroException();
			//}

			///if the numerator is 0, the exception is deferred.
			return new Dividing_asClass(x._denominator, x._numerator);
		}

		public static Dividing_asClass operator /(in Dividing_asClass x, in Dividing_asClass y)
		{
			return x * Inverse(y);
		}
		public  bool isNil()
		{
			return (_numerator == 0);
		}

		public static bool IsNil(in Dividing_asClass x)
		{
			///exception or nil
			return (x._numerator == 0);
		}

		public static bool operator ==(in Dividing_asClass x, in Dividing_asClass y)
		{
			return (x - y).isNil();
		}

		public static bool operator ==(in Dividing_asClass x, in int y)
		{
			return (x - y).isNil();
		}

		public static bool operator !=(in Dividing_asClass x, in Dividing_asClass y)
		{
			return !(x == y);
		}
		public static bool operator !=(in Dividing_asClass x,in int y)
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
		static public Dividing_asClass Parse(string s)
		{

			///first find the /
			///
			/// 
			string[] terms = s.Split(DividerSign);

			switch (terms.Length)
			{
				case 0:
					return new Dividing_asClass();
				case 1:
					return new Dividing_asClass(
						BigInteger.Parse(terms[0])
					);
				case 2:
					return new Dividing_asClass(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));

				default:
					throw new Exception(
						string.Format("There are more than two terms sperated by {0}.", DividerSign)
					);
					break;
			}

		}

		static public bool TryParse(string s, out Dividing_asClass result)
		{

			try
			{
				result = Parse(s);
				return true;
			}
			catch (Exception)
			{
				result = default(Dividing_asClass); //null
				return false;

			}

		}



	}
}
