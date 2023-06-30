using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.of_.binary.cascader_
{
	public class OpDefault<TOp>
		:
		nilnul.obj.of_.binary.cascader_.OpDefault<DenomNonnilI,TOp>
		where TOp:nilnul.obj.of_.BinaryI<DenomNonnilI>,new()
	{
	}
}
