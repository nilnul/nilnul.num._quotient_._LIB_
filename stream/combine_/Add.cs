using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream.combine_
{
	public class Add : quotient.stream.Combine
	{
		public Add() : base(nilnul.num.quotient.combine_.Add.Instance)
		{
		}

		static public Add Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Add>.Instance;
			}
		}


	}

}
