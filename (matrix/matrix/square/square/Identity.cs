using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.square
{
	public class Identity
	{
		static public double[,] Create(int size) {
			var raw = Matrix.Ini(size);

			for (int i = 0; i < size; i++)
			{
				raw[i, i] = 1;
				
			}
			return raw;
		}
	}
}
