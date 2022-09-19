using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.stream._instanceS
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

		private Q _initial;

		public Q initial
		{
			get { return _initial; }
			set { _initial = value; }
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

		public Q head
		{
			get
			{
				return _initial;
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
			_current = initial;
			return;
			throw new NotImplementedException();
		}

		

		static public Arithmetic Create_diffNotReducedFroIni(Q ini, Q d) {

			return new Arithmetic() {
				initial = ini - d	//
				,
				diff=d

			};

		}






	}
}
