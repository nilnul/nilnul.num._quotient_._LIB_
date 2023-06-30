using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	[MayPerpetual("if the two are not equal, this will terminate. otherwise, this will perpetual")]
	public class Eq : IEqualityComparer<StreamI3>
	{
		public bool Equals(StreamI3 x, StreamI3 y)
		{
			while (x.next() == y.next())
			{


			}

			return false;

			throw new NotImplementedException();
		}

		public int GetHashCode(StreamI3 obj)
		{
			return 0;
			throw new NotImplementedException();
		}
	}
}
