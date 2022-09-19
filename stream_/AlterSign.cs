using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using System.Numerics;

namespace nilnul.num.quotient.stream_
{
	public class AlterSign : StreamI3
	{

		private nilnul.num.integer.stream_.alterSign.InInt _oddAlter=new integer.stream_.alterSign.InInt();

		public nilnul.num.integer.stream_.alterSign.InInt oddAlter
		{
			get { return _oddAlter; }
			private set { _oddAlter = value; }
		}

		public AlterSign()
		{

		}




		public Simplify.Ed1 next()
		{
			return (_oddAlter.next());

			throw new NotImplementedException();
		}
	}
}
