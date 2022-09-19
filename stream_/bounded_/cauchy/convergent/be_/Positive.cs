using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num.quotient.stream_.convergent.be_
{
	/// <summary>
	/// limit is positive.
	/// <seealso cref="nameof(nilnul.num.quotient.stream) + tail.terms.positve"/>
	/// </summary>
	public class Positive : BeI
	{


		static public Positive Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Positive>.Instance;
			}
		}


		[MayPerpetual]
		public bool be(ConvergentI obj)
		{
			return  _SignX.Sign(obj)>0;
//			throw new NotImplementedException();
		}



	}
}
