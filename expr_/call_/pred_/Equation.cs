using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient
{
	public class Equation
	{
		private nilnul.num.quotient.ExprI _left;

		public nilnul.num.quotient.ExprI left
		{
			get { return _left; }
			set { _left = value; }
		}

		private nilnul.num.quotient.ExprI _right;

		public nilnul.num.quotient.ExprI right
		{
			get { return _right; }
			set { _right = value; }
		}

		public Equation(ExprI left, ExprI right)
		{

		}


	}
}
