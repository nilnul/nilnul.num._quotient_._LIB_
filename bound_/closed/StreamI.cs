using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.bound_.closed
{
	public interface IStream
		:
		nilnul.obj.IStream<bound_.IClosed>
	{ }
	/// <summary>
	/// to support real definition, as real can be on the border, outside an open /half-open interval
	/// </summary>
	public interface StreamI:nilnul.obj.StreamI2< quotient.bound_.ClosedI>,IStream
	{
	}
}
