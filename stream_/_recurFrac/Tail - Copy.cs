using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.quotient._stream._continuedFraction
{
	public partial class Tail : nilnul.num.quotient.StreamI
	{
		private nilnul.num._positive.StreamI _positiveNumStream;

		public nilnul.num._positive.StreamI positiveNumStream
		{
			get { return _positiveNumStream; }
			set { _positiveNumStream = value; }
		}
		public Tail(_positive.StreamI denominators)
		{
			_positiveNumStream = denominators;
			_enumerator = GetEnumerator();

		}

		public Q ComputeTill(BigInteger n)
		{
			return form.continuedFraction.ProperContinuedFraction._ToFraction(nilnul.num.type.stream.ExtensionMethods.AsStr(_positiveNumStream, n));
		}

		private IEnumerator<Q> _enumerator;
		public IEnumerator<Q> GetEnumerator()
		{

			BigInteger numerator = 0, denominator = 1;
			yield return new Q();

			BigInteger numerator1 = 1, denominator1 = _positiveNumStream.next().val;
			yield return Q.Inverse(denominator1);


			while (true)
			{
				var denominatorElementNext = _positiveNumStream.next().val;

				BigInteger numeratorNext = _ComputeNextFractionParts(_positiveNumStream.next().val, numerator1, numerator);
				BigInteger convergentDenominatorNext = _ComputeNextFractionParts(denominatorElementNext, denominator, denominator1);

				yield return new Q(numeratorNext, convergentDenominatorNext);

				numerator = numerator1; denominator = denominator1;
				numerator1 = numeratorNext; denominator1 = denominatorElementNext;



			}
		}

		static private BigInteger _ComputeNextFractionParts(BigInteger denominatorElement, BigInteger convergentComponentPrevious, BigInteger convergentComponentPreviousPrevious)
		{
			return denominatorElement * convergentComponentPrevious + convergentComponentPreviousPrevious;
		}

		public Q next()
		{
			_enumerator.MoveNext();
			return _enumerator.Current;

			throw new NotImplementedException();
		}

		public void reset()
		{
			_positiveNumStream.reset();
			_enumerator = GetEnumerator();
			return;
			throw new NotImplementedException();
		}
	}
}
