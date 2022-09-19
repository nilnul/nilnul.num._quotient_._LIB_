using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.quotient._streamS
{
	public partial class Wallis : StreamI1
	{


		private BigInteger _num;

		public BigInteger num
		{
			get { return _num; }
			set { _num = value; }
		}

		private BigInteger _den;

		public BigInteger den
		{
			get { return _den; }
			set { _den = value; }
		}

		private bool _oddEven;	//true:even, false:odd

		public bool oddEven
		{
			get { return _oddEven; }
			set { _oddEven = value; }
		}


		private Q _accumulatedProduct=1;

		public Wallis()
		{
			_num = 0;
			_den = 1;
		}

		public Q next()
		{
			_oddEven = !_oddEven;

			if (_oddEven)
			{
				_num += 2;
			}
			else
			{
				_den += 2;
			}


			return _accumulatedProduct *= new Q(_num, _den);


			throw new NotImplementedException();
		}

		public void reset()
		{
			_num = 0;
			_den = 1;

			//throw new NotImplementedException();
		}

		static public Q Item(int i) {
			Wallis stream = new Wallis();

			var i1 = 0;
			while (i1++<i)
			{
				stream.next();
			}
			return stream.next();
		}

		public IEnumerator<Q> GetEnumerator()
		{

			yield return next();

			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();

			//throw new NotImplementedException();
		}
	}
}
