using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.range
{
	[Obsolete()]
	static public class _SplitX
	{

		static public IEnumerable<Range1> BySign(Range1 range)
		{
			switch (nilnul.num.quotient._SignX1.Sign(range.lower.mark))
			{
				case integer._sign.Ret.Negative:
					switch (nilnul.num.quotient._SignX1.Sign(range.upper.mark))
					{
						case integer._sign.Ret.Negative:
							return new[] { range };
							break;
						case integer._sign.Ret.Nil:
							if (range.upper.isClose)
							{
								return new[] {
									new Range1(range.lower, Border2.CreateOpenNil())
									,Range1.CreateZero()
								};
							}
							else
							{
								return new[] { range };
							}
							break;
						case integer._sign.Ret.Positive:
							return new[] {
								new Range1(range.lower,  Border2.CreateOpenNil())
								,
								Range1.CreateZero()
								,
								new Range1(Border2.CreateOpenNil(), range.upper)
							};
							break;
						default:
							throw new UnexpectedReachException();
							break;
					}
					break;
				case integer._sign.Ret.Nil:
					switch (nilnul.num.quotient._SignX1.Sign(range.upper.mark))
					{

						case integer._sign.Ret.Nil:
							return new[] { range };
							break;
						case integer._sign.Ret.Positive:
							if (range.lower.isClose)
							{
								return new[] {
									Range1.CreateZero()
									,
									new Range1(Border2.CreateOpenNil(),range.upper)
								};
							}
							else
							{
								return new[] {
									 range
								};
							}
							break;
						default:
							throw new UnexpectedReachException();
							break;
					}
					break;
				
				default:// positive
					return new[] { range};
					break;
			}
		}
		static public nilnul.obj.Trio<Range1> Triplet(Range1 range)
		{
			switch (nilnul.num.quotient._SignX1.Sign(range.lower.mark))
			{
				case integer._sign.Ret.Negative:
					switch (nilnul.num.quotient._SignX1.Sign(range.upper.mark))
					{
						case integer._sign.Ret.Negative:
							return new obj.Trio<Range1>( range ,null,null);
							break;
						case integer._sign.Ret.Nil:
							if (range.upper.isClose)
							{
								return new obj.Trio<Range1>(
									new Range1(range.lower, Border2.CreateOpenNil())
									,Range1.CreateZero()
									,null
								);
							}
							else
							{
								return new obj.Trio<Range1>(range ,null,null);
							}
							break;
						case integer._sign.Ret.Positive:
							return new obj.Trio<Range1>(
								new Range1(range.lower,  Border2.CreateOpenNil())
								,
								Range1.CreateZero()
								,
								new Range1(Border2.CreateOpenNil(), range.upper)
							);
							break;
						default:
							throw new UnexpectedReachException();
							break;
					}
					break;
				case integer._sign.Ret.Nil:
					switch (nilnul.num.quotient._SignX1.Sign(range.upper.mark))
					{

						case integer._sign.Ret.Nil:
							return new obj.Trio<Range1>(null,range ,null);
							break;
						case integer._sign.Ret.Positive:
							if (range.lower.isClose)
							{
								return new obj.Trio<Range1>(
									null,
									Range1.CreateZero()
									,
									new Range1(Border2.CreateOpenNil(),range.upper)
								);
							}
							else
							{
								return new obj.Trio<Range1>(
									null,null,
									 range
								);
							}
							break;
						default:
							throw new UnexpectedReachException();
							break;
					}
					break;
				
				default:// positive
					return new obj.Trio<Range1>(null,null, range);
					break;
			}
		}

	}
}
