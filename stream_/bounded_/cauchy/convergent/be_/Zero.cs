﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num.quotient.stream_.convergent.be_k
{
	/// <summary>
	/// limit is positive.
	/// <seealso cref="nameof(nilnul.num.quotient.stream) + tail.terms."/>
	/// </summary>
	public class Zero : BeI
	{


		static public Zero Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Zero>.Instance;
			}
		}


		[MayPerpetual]
		public bool be(ConvergentI obj)
		{
			return  _SignX.Sign(obj)==0;
//			throw new NotImplementedException();
		}



	}
}
