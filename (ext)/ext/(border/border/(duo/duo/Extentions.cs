using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.ext.border.duo
{
	public static  class Extensions
	{
		

		static public bool Contains(this border.Duo1 nonempty, ExtI x) {
			return nonempty.contains(x);
		}

		static public bool ContainsInf(this border.Duo1 nonempty) {
			return nonempty.contains(ext_.Inf.Singleton);
		}

		static public bool ContainsMinimal(this border.Duo1 nonempty) {
			return nonempty.contains(ext_.NegInf.Singleton);
		}

		static public bool ContainsExtremum(this border.Duo1 nonempty) {
			return nonempty.ContainsInf() || nonempty.ContainsMinimal();
		}

		static public bool NotContainsExtremum(this border.Duo1 nonempty) {
			return !ContainsExtremum(nonempty);
		}







	}
}
