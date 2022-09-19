using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.border.be_
{
	[Obsolete()]
	public class Invertible : nilnul.num.quotient.border.BeI
	{

		static public readonly Invertible Singleton = SingletonByDefault<Invertible>.Instance;

		public bool be(Border1 obj)
		{
			return obj.mark != 0;
			throw new NotImplementedException();
		}

		public class En : nilnul.be.Asserted<Border1, Invertible>
		{
			public En(Border1 val) : base(val)
			{
			}

			static public Border1 _Inverse(Border1 _invertible) {
				return new Border1(_invertible.openFalseCloseTrue, 1/_invertible.mark);
			}
		}
	}
}
