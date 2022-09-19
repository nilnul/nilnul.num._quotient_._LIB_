﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.slider_._geometric_
{
	[Obsolete(nameof(slider_.Geometric))]
	public class Headed :  SliderI
	{

		public Headed(Q1 head, Q1 rate)
		{
			_current = head;
			_rate = rate;
		}

		private Q1 _current;
		private Q1 _rate;
		public Simplify.Ed1 current
		{
			get
			{
				return _current;			}
		}

	

		public Simplify.Ed1 multiplier
		{
			get
			{
				return _rate;
				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			_current *= _rate;
			//throw new NotImplementedException();
		}
	}
}
