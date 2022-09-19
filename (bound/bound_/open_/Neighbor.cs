using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;
using Range = nilnul.num.quotient.border.duo.be_.Nonempty.En;

using q = nilnul.num.quotient;
using q_ = nilnul.num.quotient_;
using nilnul.num.quotient._bound;

namespace nilnul.num.quotient.bound_.open_
{
	/// <summary>
	/// zero must be in this.
	/// </summary>
	public interface NeighborI
	{
		Q1 center { get; }

		quotient_.Positive1 radius { get; }




	}

	public class Neighbor : NeighborI
		,
		q._bound_.LowerI, q._bound_.UpperI
	{
		private Q1 _center;

		public Q1 center
		{
			get { return _center; }
			set { _center = value; }
		}

		private quotient_.Positive1 _radius;

		public quotient_.Positive1 radius
		{
			get { return _radius; }
			set { _radius = value; }
		}

		public Lower lower => Lower.CreateOpen(_center - _radius);

		public Upper upper => Upper.CreateOpen(_center + _radius);

		public Neighbor(Q1 center, q_.Positive1 radius)
		{
			_center = center;
			_radius = radius;

		}



		public Neighbor(q_.Positive1 radius) : this(0, radius)
		{

		}

		public Bound toClosed() {
			return Bound.CreateClose( _center -_radius, _center + _radius);
  }

		static public implicit operator Bound(Neighbor x)
		{
			return new Bound(x.lower, x.upper);


		}

		static public Neighbor Create(Q1 center, Q1 radius_positive)
		{
			return new Neighbor(
			center,
			new q_.Positive1(radius_positive)
				);
		}
		static public Neighbor Create(Q1 radius_positive)
		{
			return Create(0,radius_positive);
		}

		static public quotient.Bound CreateBound(Q1 center, q_.Positive1 radius)
		{
			return Create(
				center
				,
				 radius

			);
		}


		static public quotient.Bound CreateBound(q_.Positive1 radius)
		{
			return CreateBound(
				0
				,
				 radius

			);
		}



	}
}
