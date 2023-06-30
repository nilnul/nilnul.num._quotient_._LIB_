using System;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_
{
	/// <summary>
	/// note that double is already defined as including inf;
	/// note: double also includes transfinite such as nan;
	/// </summary>
	///
	[Obsolete("for quotient.ext, we have better use:"+nameof(quotient.ExtA) + "; this is better for real numbers;")  ]
	public interface Ext4dblI
		:
		//nilnul.obj.vow.Ee_ofIn
		//,
		IExt
		,
		ieee_._bin_.ErrableI
	{
		//double errable { get; }
	}
}
