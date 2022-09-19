using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.slider_
{
	[PartialImplementation(nameof(bernoulli_.Recur))]
	public class Bernoulli
		: nilnul.num.quotient.SliderI
	{
		private int _index;

		public int index
		{
			get { return _index; }
		}

		

	
		private IEnumerator<Q1> _enumerator;

		public Bernoulli()
		{
			 ;
			_enumerator= str_.Bernoulli.Enumerate().GetEnumerator();
			_enumerator.MoveNext();
			
			/*https://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=ZH-CN&k=k(%22System.Collections.Generic.IEnumerable%601.GetEnumerator%22);k(SolutionItemsProject);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.6);k(DevLang-csharp)&rd=true
																  Initially, the enumerator is positioned before the first element in the collection. At this position, P:System.Collections.Generic.IEnumerator`1.Current is undefined. Therefore, you must call the M:System.Collections.IEnumerator.MoveNext method to advance the enumerator to the first element of the collection before reading the value of P:System.Collections.Generic.IEnumerator`1.Current.
																		   */

		}




		public Simplify.Ed1 current
		{
			get
			{
				return _enumerator.Current;

				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			if (_index<int.MaxValue)
			{
				_enumerator.MoveNext();
				_index++;



			}
			else
			{
				throw new NotImplementedException();

			}
		}
	}
}
