﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix
{

	/// <summary>
	/// we shall be loyal to the inner structure;
	/// eg:
	///		-0 is not normalized to 0, as some user might write -0 and we should be able to represent it;
	///		000 is not normalized to 0;
	///		.123 is not converted to 0.123
	///			or we can convert it if explicitly required
	///		"", however is normalized to "0"
	/// </summary>
	class IPhrase
	{
	}


}
