using nilnul.num.integer_;
using nilnul.num.quotient_.nonneg_.radix_.floaty;
using nilnul.num.quotient_.radix;
using nilnul.num.quotient_.radix_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix.recur.of_.unary_
{

	/// <summary>
	/// as this is a recur, we need to extend the signific to accormodate the cycle part, not 0 as done by <see cref="radix.of_.unary_._DecreaseIndicX"/>;
	/// eg:
	///		-010230 * 10 ^ -01, recur: 3  =01023.0230230
	///			=>
	///				-010230230 * 10^-4,recur 3
	///				=-01023.0(230
	/// </summary>
	static public class _DecreaseIndicX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="radix"></param>
		/// <param name="cycle">must be positive, as we need to infinitely repeat the cycle before truncating it;</param>
		/// <param name="_indicDecrease"></param>
		/// <returns></returns>
		public static (num_.Radix2, BigInteger) __Duo_1pos_2nonneg(RadixI radix, int cycle,  int _indicDecrease)
		{

			var cyclePart = radix.precision.gits.Take( cycle);

			var toFill = nilnul.obj.stream.of_.str_.seq_.started_.cyclic_._WhileTrue.Seq_assumeStarted(cyclePart).Take(_indicDecrease);//.SelectMany(x=>x);


			return (
				new nilnul.num_.Radix2(
					radix.precision.radic.eeByRef
					,
						
					radix.precision.gits.Concat(
						toFill
					).Select(
						x => x.eeByRef
					)
					
				)
				,
				radix.indic - _indicDecrease 
			);
		}


		public static (num_.Radix2, BigInteger) _Duo_12pos(RadixI recur, int cycle,  int _indicDecrease)
		{
			return __Duo_1pos_2nonneg(recur, cycle, _indicDecrease);
		}


		static public (num_.RadixI precision, BigInteger indic) _Duo_1positive_2nil0pos(
			RadixI radix
			,
			int cycle
			,
			int _indicDecrease
		)
		{
			if (_indicDecrease == 0)
			{
				return (radix.precision, radix.indic);
			}

			return _Duo_12pos(radix,cycle, _indicDecrease);
		}
		static public (num_.RadixI precision, BigInteger indic) _Duo_1nil0pos_2nonneg(
			RadixI radix
			,
			int cycle
			,
			int _indicDecrease
		)
		{
			if (cycle==0)
			{
				return nonneg_.radix.of_.unary_._AppendNilX._Duo_1nonneg(radix,_indicDecrease);
			}

			return _Duo_1positive_2nil0pos(radix,cycle, _indicDecrease);
		}


		public static (num_.RadixI, BigInteger) _Duo_1pos(RecurI recur,  int _indicDecrease)
		{

			return _Duo_1nil0pos_2nonneg(recur.radix,(int) recur.period.eeByRef,_indicDecrease);
			;
		}
		public static (num_.RadixI, BigInteger) _Duo_1nil0pos(RecurI recur,   int _indicDecrease)
		{
			if (_indicDecrease==0)
			{
				return (recur.radix.precision,recur.radix.indic);
			}
			return _Duo_1pos(recur,  _indicDecrease);
		}

		static public Recur _AsRecur_1pos(
			RecurI recur
			,
			int _indicDecrease
		)
		{
			return new Recur( _Duo_1pos(recur,  _indicDecrease),recur.period );
		}

		public  static Recur _AsRecur_1pos(RecurI recur, BigInteger indic)
		{
			return _AsRecur_1pos(recur, (int)indic);
		}

		public static RecurI _AsRecur_1nil0pos(RecurI recur,   int _indicDecrease)
		{
			if (_indicDecrease==0)
			{
				return recur;
			}
			return _AsRecur_1pos(recur,_indicDecrease);
			//return new Recur( _Duo_1pos(recur,  _indicDecrease),recur.cycle );
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="recur"></param>
		/// <param name="_indicDecrease">we later have to use int</param>
		/// <returns></returns>
		public static RecurI _AsRecur_1nil0pos(RecurI recur,   BigInteger _indicDecrease)
		{
			
			return _AsRecur_1nil0pos(recur,(int)_indicDecrease);
		}


	}
}
