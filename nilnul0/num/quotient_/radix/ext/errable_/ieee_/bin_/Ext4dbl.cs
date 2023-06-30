using nilnul.num.integer._ext;
using System;
using System.CodeDom;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_
{
	[Obsolete("for quotient.ext, we have better use:" + nameof(quotient.ExtA) + "; this is better for real numbers;")]

	public class Ext4dbl
		:
		nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.be_.nonerr.vow.Ee
		,
		Ext4dblI

	{
		public Ext4dbl(in double val) : base(val)
		{
		}

		public Ext4dbl(double val) : base(val)
		{
		}

		static public readonly Ext4dbl NegInf = new Ext4dbl(double.NegativeInfinity);
		static public readonly Ext4dbl PosInf = new Ext4dbl(double.PositiveInfinity);
		static public readonly Ext4dbl Nil = new Ext4dbl(0);
		static public readonly Ext4dbl One = new Ext4dbl(1);

		static public readonly Ext4dbl NegOne = new Ext4dbl(-1);


		static public Ext4dbl operator -(Ext4dbl x) {
			if (x.errable ==0)
			{
				return x;
			}
			return new Ext4dbl(-x.errable);
		}

		///// <summary>
		/////  may lose some presion;
		///// </summary>
		///// <param name="x"></param>
		///// <param name="y"></param>
		///// <returns></returns>
		//static public Ext4dblI operator /(Ext4dbl x,Ext4dblI y) {
		//	return ext.of_.binary_.Divide.Singleton.op(x,y);
		//}

		public double errable => this.eeByRef;


	}
}
