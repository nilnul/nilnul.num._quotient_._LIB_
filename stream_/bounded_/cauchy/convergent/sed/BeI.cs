using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.convergent.sed
{
	/*extern alias obj;*/
	public interface BeI
		:
		/*obj::*/nilnul.obj.BeI1<ConvergentI>
	{
	}

	public interface BeI<T>
		:
		/*obj::*/nilnul.obj.BeI1<T>
		where T:SedI
	{

	}
}
