using nilnul.num.quotient_;
using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.of_.binary.converse_
{
	public class OpDefault<TOp>
		:
		Converse
		where TOp : nilnul.obj.of_.BinaryI<DenomNonnilI>, new()
	{
		public OpDefault() : base(
				 nilnul._obj.typ_._UnisonX<TOp>.Unison
		)
		{
		}


		static public OpDefault<TOp> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<OpDefault<TOp>>.Unison;
			}
		}

	}
}
