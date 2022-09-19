using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Range = nilnul.num.quotient.border.duo.be_.Nonempty.En;

namespace nilnul.num.quotient
{
	/// <summary>
	/// zero must be in this.
	/// </summary>
	///
	[Obsolete()]
	public interface NeighborI
	{
		Q1 center { get; }

		be_.Positive1.En radius { get; }





	}

	[Obsolete()]
	public class Neighbor : NeighborI
	{
		private Q1 _center;

		public Q1 center
		{
			get { return _center; }
			set { _center = value; }
		}

		private be_.Positive1.En _radius;

		public be_.Positive1.En radius
		{
			get { return _radius; }
			set { _radius = value; }
		}

		public Neighbor(Q1 center, be_.Positive1.En radius)
		{
			_center = center;
			_radius = radius;

		}



		public Neighbor(be_.Positive1.En radius) : this(0, radius)
		{

		}

		public bool contains(Q1 x)
		{
			return ((Range)this).contains(x);
		}

		public bool notContains(Q1 x)
		{
			return !contains(x);
		}

		public quotient.Border1 lower
		{
			get
			{
				return Border1.CreateOpen(center - radius);
			}

		}
		public quotient.Border1 upper
		{
			get
			{
				return Border1.CreateOpen(center + radius);
			}

		}

		public quotient.border.Duo borders
		{
			get
			{
				return new border.Duo(lower, upper);
			}
		}

		static public implicit operator Range(Neighbor x)
		{
			return new Range(x.borders);


		}

		static public Neighbor operator *(Neighbor x, quotient.be_.Positive1.En nonZero) {
			return new Neighbor(
				x.center*nonZero
				,
				x.radius*nonZero
				);
		}
		static public Neighbor operator *(Neighbor x, int y) {
			return x * new be_.Positive1.En(y);
		}

		static public Neighbor Create(Q1 center, Q1 radius_positive)
		{
			return new Neighbor(
			center,
			new be_.Positive1.En(radius_positive)
				);
		}
		static public Neighbor Create(  Q1 radius_positive)
		{
			return new Neighbor(
			0,
			new be_.Positive1.En(radius_positive)
				);
		}

		static public quotient.border.duo.be_.Nonempty.En CreateRange(Q1 center, be_.Positive1.En radius)
		{
			return border.duo.be_.Nonempty.En.CreateOpen(
				center - radius
				,
				center + radius

			);
		}

		static public quotient.border.duo.be_.Nonempty.En CreateRange(be_.Positive1.En radius)
		{
			return CreateRange(0, radius);
		}


	}
}
