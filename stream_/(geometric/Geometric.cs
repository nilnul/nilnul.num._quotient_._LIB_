using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.stream._instanceS
{
	public interface GeometricI : StreamI2 {
		Q head { get; }

		Q rate { get; }
	}
	public class Geometric_headIsNotAmplified : GeometricI
	{

		private Q _initial;

		public Q initial
		{
			get { return _initial; }
			set { _initial = value; }
		}

		private Q _multiplier;

		public Q multiplier
		{
			get { return _multiplier; }
			set { _multiplier = value; }
		}

		private Q _current;

		public Q current
		{
			get { return _current; }
			set { _current = value; }
		}

		private Q _subsequent;

		public Q subsequent
		{
			get { return _subsequent; }
			set { _subsequent = value; }
		}

		public Q head
		{
			get
			{
				return _initial;
				throw new NotImplementedException();
			}
		}

		public Q rate
		{
			get
			{
				return _multiplier;
				throw new NotImplementedException();
			}
		}

		public Geometric_headIsNotAmplified(Q ini, Q amplifier)
		{
			_initial = ini;
			_multiplier = amplifier;
			_current = ini;
			_subsequent = _current * amplifier;
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
			var oldCurrent = _current.clone();

			_current*=multiplier;
			return oldCurrent;

			throw new NotImplementedException();
		}

		public void reset()
		{
			_current = _initial;
			return;
			throw new NotImplementedException();
		}

		

		static public Geometric_headIsAmplified Create_headIsOne( Q d) {

			return new Geometric_headIsAmplified(
				1//
				,
				d

			);

		}






	}

	
	public class Geometric_headIsAmplified : GeometricI
	{

		private Q _initial;

		public Q initial
		{
			get { return _initial; }
			set { _initial = value; }
		}

		private Q _multiplier;

		public Q multiplier
		{
			get { return _multiplier; }
			set { _multiplier = value; }
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
				return _initial * _multiplier;
				throw new NotImplementedException();
			}
		}

		public Q rate
		{
			get
			{
				return _multiplier;
				throw new NotImplementedException();
			}
		}

		public Geometric_headIsAmplified(Q ini, Q amplifier)
		{
			_initial = ini;
			_multiplier = amplifier;
			_current = ini;
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

			return _current*=multiplier;

			throw new NotImplementedException();
		}

		public void reset()
		{
			_current = _initial;
			return;
			throw new NotImplementedException();
		}

		

		static public Geometric_headIsAmplified Create_headIsOne( Q d) {

			return new Geometric_headIsAmplified(
				1//
				,
				d

			);

		}






	}
}
