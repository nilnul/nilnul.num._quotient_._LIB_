using nilnul.num.quotient.be_.approx_;
using nilnul.num.quotient_.denomNonnil;
using nilnul.num.quotient_.denomNonnil_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.re_
{
	public class Approx
		: nilnul.obj.Box_ofIn<

			nilnul.num.quotient.be_.approx_.Nil
		>
		,
		nilnul.num.quotient_.denomNonnil.ReI
	{


		public Approx(Nonneg x) : this(new Nil( x ))
		{
		}
		public Approx(
			num.quotient_.DenomNonnilI x
		)
		:this( new Nonneg(x) )
		{

		}
		public Approx(int x=0):this(new Nonneg(x))
		{

		}

		public Approx(in Nil val) : base(val)
		{
		}

		public Approx(Nil x) : this(in x)
		{
		}

		public Approx():this(0)
		{

		}

		public bool re(quotient_.DenomNonnilI a, quotient_.DenomNonnilI b)
		{
			return boxed.be(
				a.ToImpl()-b
			);
		}


		static public Approx Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Approx>.Instance;
			}
		}

	}
}
