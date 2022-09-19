using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.cauchy.eq_
{
	public interface CofinalI:IEqualityComparer<CauchyI>
	{

	}
	public class Cofinal : CofinalI
	{
		public bool Equals(CauchyI x, CauchyI y)
		{
			throw new NotImplementedException();
		}

		public int GetHashCode(CauchyI obj)
		{
			throw new NotImplementedException();
		}
	}
}
