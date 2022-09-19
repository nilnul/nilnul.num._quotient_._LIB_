using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.ext.border.duo.be
{
	public partial class Interval1
		: BeI<Duo1>
		, nilnul.bit.BeI<Duo1>
	{
		static public bool Eval(Duo1 x)
		{

			return Singleton.Eval(x) || Spanned.Eval(x);

		}
		static public bool Eval_literalCompute(Duo1 x)
		{

			var t = ext.Comparer1.Singleton.Compare(x.lower.mark, x.upper.mark);


			if (

				t < 0

			)
			{
				return true;

			}
			if (t == 0)
			{
				if (x.lower.openFalseCloseTrue)
				{
					if (x.upper.openFalseCloseTrue)
					{
						return true;
					}
					return false;

				}
				return false;

			}
			return false;

		}

		public bool be(Duo1 obj)
		{
			return Eval(obj);

			throw new NotImplementedException();
		}

		public class En :
			nilnul.bit.be.Asserted<Duo1, Interval1>
		{
			

			public En(Duo1 x)
				: base(x)
			{

			}

			public En(Border1 border11, Border1 border12)
				:this(new Duo1(border11,border12))
			{
				
			}

			public ext.Border1 upper
			{
				get
				{
					return val.upper;
				}
			}

			public ext.Border1 lower
			{
				get
				{
					return val.lower;
				}
			}

			public bool contains(ExtI ext)
			{
				return val.contains(ext);
			}

			public bool notContains(ExtI ext)
			{
				return !contains(ext);
			}


		



		}



	}
}
