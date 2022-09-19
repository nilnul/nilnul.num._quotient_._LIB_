using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_._radix.xpn_
{
	

	[Serializable]
	public class OverlongException : Exception
	{
		public OverlongException() { }
		public OverlongException(string message) : base(message) { }
		public OverlongException(string message, Exception inner) : base(message, inner) { }
		protected OverlongException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
