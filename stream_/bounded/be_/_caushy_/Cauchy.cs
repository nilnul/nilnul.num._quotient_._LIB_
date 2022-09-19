using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream.be_
{
	/// <summary>
	/// convergent:
	/// given positive Q <var>q</var>, we can find N <var>n</var> such that  for any <var>i, j</var>, where i, j >N,  | the element[i] - element[j]| &le;q.
	/// </summary>
	///
	[Obsolete()]
	public class Cauchy : nilnul.num.quotient.stream.BeI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool be(StreamI4 obj)
		{
			//by inpsecting the function of n->q of the term of the stream.
			throw new NotImplementedException();
		}

		static public Cauchy Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Cauchy>.Instance;
			}
		}

	}
}
