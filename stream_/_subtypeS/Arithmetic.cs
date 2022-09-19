using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.stream._subtypeS
{

	public interface ArithmeticI : StreamI {
		Q head {
			get;
		}
		Q diff {
			get;
		}
	}

	
	public class Arithmetic : ArithmeticI
	{

		private Q _headMinusDiff;

		public Q headMinusDiff
		{
			get { return _headMinusDiff; }
			set { _headMinusDiff = value; }
		}

		private Q _diff;

		public Q diff
		{
			get { return _diff; }
			set { _diff = value; }
		}

		private Q _current;

		public Q current
		{
			get { return _current; }
			set { _current = value; }
		}
		public Arithmetic(Q headMinusDiff, Q diff)
		{
			_headMinusDiff = headMinusDiff;
			_diff = diff;

			_head = headMinusDiff + diff;



			_current = headMinusDiff;

		}

		private Q _head;
		public Q head
		{
			get
			{
				return _head;
				throw new NotImplementedException();
			}
		}

		public IEnumerator<Q> GetEnumerator()
		{

			while (true)
			{
				yield return next();
			}
			//throw new NotImplementedException();
		}

		public Q next()
		{

			return _current+=diff;

			throw new NotImplementedException();
		}

		public void reset()
		{
			_current = _headMinusDiff;
			return;
			throw new NotImplementedException();
		}

		

		static public Arithmetic Create_givenAsHead(Q head, Q d) {

			return new Arithmetic(
				head - d	//
				,
				d

			);

		}






	}
}
