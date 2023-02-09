using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.range_.nilMarked_.nil.nulable.accumulate_
{
	public class _UnionX
	{
		static public Range1 Range(IEnumerable<Range1> nilMarkedNilS){
			if (
				nilMarkedNilS.Any(x=> !(x    is null ) )
			)
			{
				return Range1.CreateZero();

			}
			return null;
		}

		static public Range1 Range(params Range1[] nilMarkedNilS)
		{
			return Range(nilMarkedNilS as IEnumerable<Range1>);
		}

	}
}
