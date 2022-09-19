using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_._radix.xpn_
{
	

	[Serializable]
	public class InfiniteException : Exception
	{
		public InfiniteException() { }
		public InfiniteException(string message) : base(message) { }
		public InfiniteException(string message, Exception inner) : base(message, inner) { }
		protected InfiniteException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
