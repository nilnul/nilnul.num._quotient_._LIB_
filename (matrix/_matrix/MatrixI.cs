using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient._matrix
{
	/// <summary>
	/// every element is real, and is known
	/// </summary>
	public partial interface MatrixI
	{
		int rowCount
		{
			get;
			set;
		}
		int colCount
		{
			get;
		}
		Q item(int row,int col);
	}
}
