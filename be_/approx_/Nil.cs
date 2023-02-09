using nilnul.bit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient_;

namespace nilnul.num.quotient.be_.approx_
{
	/// <summary>
	/// around nil
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// alias:
	///		nilish
	///		nily
	///		minimal
	///		insignicant
	///		unimportant
	///		ignorable
	///		neglectable
	///		nilectable
	public class Nil
			:
		nilnul.obj.Box1<nilnul.num.quotient_.denomNonnil.Clasp>
		,
		nilnul.num.quotient_.denomNonnil.BeI
	{
		public Nil(quotient_.denomNonnil_.Nonneg val) : base(nilnul.num.quotient_.denomNonnil.clasp_.centered_._OriginarX.Clasp_ofRadius(val))
		{
		}
		public Nil(quotient_.DenomNonnilI val) : this(
			new quotient_.denomNonnil_.Nonneg(val)
		)
		{
		}

		public Nil(quotient_.DenomNonnil val) : this(
			new quotient_.denomNonnil_.Nonneg(val)
		)
		{
		}

		public bool be(in DenomNonnilI val)
		{
			return boxed.has(val);
		}

		public bool be(DenomNonnilI obj)
		{
			return be(in obj);
		}


		public bool not(DenomNonnilI x)
		{
			return !be(x);
		}

		/// <summary>
		/// this can be changed before call this
		/// </summary>
		public static Nil Injected = new Nil( new quotient_.DenomNonnil(1,1000) );

		public static void SetInjected(DenomNonnilI x)
		{
			Injected = new Nil(x);
		}

	}
}

