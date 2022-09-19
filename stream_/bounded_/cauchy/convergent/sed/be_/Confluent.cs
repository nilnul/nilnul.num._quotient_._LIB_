using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.convergent.sed.be_
{
	public class Confluent : BeI
	{
		/// <summary>
		/// the limit of each element is the same.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool be(ConvergentI obj)
		{
			throw new NotImplementedException();
		}

		static public Confluent Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Confluent>.Instance;
			}
		}

	}
}
