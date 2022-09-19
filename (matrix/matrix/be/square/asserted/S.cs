using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.matrix.be.square.asserted
{
	public partial class S
	{
		/*
		很简单，就是把把复数换成某些矩阵(把单位阵I当作1），原先的运算规律仍然成立。这样相角就容易理解了。
举例：
2阶方阵a=(0 1;-1 0)，则容易验证a^2=-I,a^3=-a, a^4=I，那么这个a在这里的作用就类似于虚数单位i了。
			*/
		static public Q[,] Imaginary2_2_ = new Q[,] { {0,1 }, { -1,0} };
	}
}
