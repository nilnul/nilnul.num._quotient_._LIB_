using System;
using System.Numerics;

namespace nilnul.num.quotient_.nonneg_._radix
{
	public class Scientific : ScientificI
	{
		private nilnul.Num_ofIn _precision;

		public nilnul.Num_ofIn precision
		{
			get { return _precision; }
			set { _precision = value; }
		}

		private BigInteger _indic;

		public BigInteger indic
		{
			get { return _indic; }
			set { _indic = value; }
		}

		public Scientific(nilnul.Num_ofIn precision,BigInteger indic)
		{
			_precision = precision;
			_indic = indic;
		}

		static public string Phrase(Scientific scientific) {
			return $"{scientific. _precision}e{scientific. _indic}";

		}

		/// <summary>
		/// use lower letter e, as upper letter E is reserved for complex number in euler polar form: such as -1.3E-3.5 := -1.3(cos(-3.5) + i* sin(-3.5))
		/// </summary>
		/// <returns>
		/// </returns>
		public override string ToString()
		{
			return $"{_precision}e{_indic}";
		}

		public static string _Phrase_0nonnegAsPrecision(BigInteger precision, BigInteger indic)
		{
			return $"{ precision}e{indic}";

		}
	}
}
