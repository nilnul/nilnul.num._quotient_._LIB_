using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient
{
	/// <summary>
	/// zero must be in this.
	/// </summary>
	public  interface AccuracyI
	{
		Q1 center { get; }

		be_.Nonneg.En radius { get; }

		



	}

	public class Accuracy:AccuracyI
	{
		private Q1 _center;

		public Q1 center
		{
			get { return _center; }
			set { _center = value; }
		}

		private be_.Nonneg.En _radius;

		public be_.Nonneg.En radius
		{
			get { return _radius; }
			set { _radius = value; }
		}

		public Accuracy(Q1 center, be_.Nonneg.En radius)
		{
			_center = center;
			_radius = radius;

		}

		public Accuracy(be_.Nonneg.En radius):this(0,radius)
		{

		}

	}
}
