using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.matrix.op;

namespace nilnul.num.matrix.square
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// An eigenspace of A is the set of all eigenvectors with the same eigenvalue, together with the zero vector.[
    /// 
    /// </remarks>
    public partial class Eigenspace
    {
		static public void Eval(Square s) {
 
			//

			var sMinusLambda = Minus.Eval(s, Identity.Create(s.rowsCount));

			sMinusLambda.TransCononical();




		
		}

    }
}
