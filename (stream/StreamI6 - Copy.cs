using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient
{
	public interface StreamI6 
		: 
		nilnul.obj.StreamI<Q1>
		,
		nilnul.obj.StreamI2<Q1>
	{

	}

	static public class StreamX6
	{
		static public StreamI6 Multi(this StreamI6 a, StreamI6 b) {
			return num.quotient.stream.combine_.Multi.Singleton.combine(a, b);
		}
		static public num.quotient.stream.Series1 Series(this StreamI6 a) {
			return new num.quotient.stream.Series1(a);
		}


	}

}
