using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.str_.started.scala_
{
	/// <summary>
	/// by recursion, which would involve a tail call;
	/// </summary>
	/// <remarks>
	/// to support <see cref="quotient_.fractile_"/>
	/// </remarks>
	public class Fractile
	{
		static public DenomNonnilI _Scala_0started(
			DenomNonnilI head
			,
			IEnumerator<DenomNonnilI> enumerator
		) {

			///this has to be tail call;
			/// as we can see from below, we cannot process in a stream way like as we need info from following terms; maybe this is part of the reason why it's not widely used;
			/// 
			///

			if (enumerator.MoveNext())
			{
				return quotient.of_.binary_.Fractile.Unison.op(
					head
					,
					_Scala_0started(enumerator.Current,enumerator)
				); /// :only a tail call is possible <see cref="quotient.of_.binary_.fractile.converse.Cascader" />
			}
			return head;


		}


		static public DenomNonnilI _Scala_0started(
			IEnumerator<DenomNonnilI> enumerator
		) {
			enumerator.MoveNext();
			return _Scala_0started(enumerator.Current, enumerator);
		}

		static public DenomNonnilI _Scala_0started(
			IEnumerable<DenomNonnilI> enumerator
		) {
			
			return _Scala_0started(enumerator.GetEnumerator());
		}

	}
}
