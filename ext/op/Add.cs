using nilnul.num.quotient._ext;
using nilnul.num.rational;
using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.ext.op
{
	public partial class Add
	{
		static public num.quotient._ext.ExtI Eval(num.quotient._ext.ExtI x, num.quotient._ext.ExtI y)
		{
			if (x is _ext.NegInf)
			{
				if (y is _ext.NegInf)
				{
					return _ext.NegInf.Singleton;

				}
				if (y is _ext.Base)
				{
					return _ext.NegInf.Singleton;

				}
				throw new Exception();
			}
			if (x is _ext.Base)
			{
				if (y is _ext.NegInf)
				{
					return _ext.NegInf.Singleton;

				}
				if (y is _ext.Base)
				{

					return new _ext.Base((x as _ext.Base).val + (y as _ext.Base).val);
				}
				if (y is _ext.Inf)
				{
					return _ext.Inf.Singleton;
				}

			}

			if (y is _ext.NegInf)
			{
				throw new Exception();

			}
			if (y is _ext.Base)
			{
				return _ext.Inf.Singleton;
			}
			return _ext.Inf.Singleton;

		}

		//static public ExtendedI Eval(ExtendedI<Rational_InheritFraction2> x, ExtendedI<Rational_InheritFraction2> y)
		//{

		//	return Eval(
		//		_ext.ExtendedX.Create(x)
		//		,
		//		_ext.ExtendedX.Create(y)
		//		);

		//}
	}
}

namespace nilnul.num.rational.ext.op
{
	public partial class Add
	{
		static public ExtendedI Eval(ExtendedI x, ExtendedI y)
		{
			if (x is NegInf)
			{
				if (y is NegInf)
				{
					return NegInf.Singleton;

				}
				if (y is Literal)
				{
					return NegInf.Singleton;

				}
				throw new Exception();
			}
			if (x is Literal)
			{
				if (y is NegInf)
				{
					return NegInf.Singleton;

				}
				if (y is Literal)
				{

					return new Literal((x as Literal).val + (y as Literal).val);
				}
				if (y is PosInf)
				{
					return PosInf.Singleton;
				}

			}

			if (y is NegInf)
			{
				throw new Exception();

			}
			if (y is Literal)
			{
				return PosInf.Singleton;
			}
			return PosInf.Singleton;

		}

		static public ExtendedI Eval(ExtendedI<Rational_InheritFraction2> x, ExtendedI<Rational_InheritFraction2> y)
		{

			return Eval(
				ExtendedX.Create(x)
				,
				ExtendedX.Create(y)
				);

		}
	}
}
