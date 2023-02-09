using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B = nilnul.num.quotient.Bound;


namespace nilnul.num.quotient.bound_.nilMarked_.nil.nulable.accumulate_
{
	public class _UnionX
	{
		static public B Bound(IEnumerable<B> nilMarkedNilS){
			if (
				nilMarkedNilS.Any(x=> !(x is null))
			)
			{
				return B.CreateZero();

			}
			return null;
		}

		static public B Bound(params B[] nilMarkedNilS)
		{
			return Bound((IEnumerable<B>)nilMarkedNilS  );
		}

	}
}
