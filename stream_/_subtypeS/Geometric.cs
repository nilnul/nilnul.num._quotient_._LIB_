using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.stream._subtypeS
{
	public interface GeometricI : StreamI2 {
		Q head { get; }

		Q rate { get; }
	}
	public class Geometric_givenHead : GeometricI
	{

		private Q _head;

		public Q head
		{
			get { return _head; }
			set { _head = value; }
		}

		private Q _rate;

		public Q rate
		{
			get { return _rate; }
			set { _rate = value; }
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

	

	

		public Geometric_givenHead(Q head, Q rate)
		{
			_head = head;
			_rate = rate;

			_current = head;
			_subsequent =head ;
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

			_current = _subsequent;
			_subsequent*=_rate;
			return _current;

			throw new NotImplementedException();
		}

		public void reset()
		{
			_current = _head;
			_subsequent = _head;


			return;
			throw new NotImplementedException();
		}

		

		static public Geometric_givenHead Create_headIsOne( Q d) {

			return new Geometric_givenHead(
				1//
				,
				d

			);

		}

		static public Geometric_givenHead CreateHalfHalf() {
			return new Geometric_givenHead(Q.CreateHalf(), Q.CreateHalf());
		}








	}

	
	public class Geometric_givenHeadDivideRate : GeometricI
	{

		private Q _headDivideRate;

		public Q headDivideRate
		{
			get { return _headDivideRate; }
			set { _headDivideRate = value; }
		}

		private Q _rate;

		public Q rate
		{
			get { return _rate; }
			set { _rate = value; }
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
				return _headDivideRate * _rate;
				throw new NotImplementedException();
			}
		}

	

		public Geometric_givenHeadDivideRate(Q headDivideRate, Q rate)
		{
			_headDivideRate = headDivideRate;
			_rate = rate;

			_headDivideRate = headDivideRate * rate;

			_current = headDivideRate;
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

			return _current*=_rate;

			throw new NotImplementedException();
		}

		public void reset()
		{
			_current = _headDivideRate;

			return;
			throw new NotImplementedException();
		}

		static public Geometric_givenHeadDivideRate Create_sumIsOne() {
			return new Geometric_givenHeadDivideRate(1, Q.CreateHalf());
		}

		

		






	}
}
