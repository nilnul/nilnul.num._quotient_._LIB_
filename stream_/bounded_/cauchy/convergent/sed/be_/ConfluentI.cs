using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.convergent.sed.be_
{
	public interface ConfluentI : BeI
	{
	}

	public interface ConfluentI<T> 
		: 
		nilnul.num.quotient.stream_.convergent.sed.BeI<T>

		where T:nilnul.num.quotient.stream_.convergent.SedI
	{
	}
}
