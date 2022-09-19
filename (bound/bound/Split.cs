using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B = nilnul.num.quotient.Bound;

namespace nilnul.num.quotient.bound
{
	/// <summary>
	/// split the interval into signed bound.nulable; 
	/// </summary>
	static public class _SplitX
	{

		static public IEnumerable<Bound> BySign(Bound range)
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
									new Bound(range.lower, Border2.CreateOpenNil())
									,Bound.CreateZero()
								};
							}
							else
							{
								return new[] { range };
							}
							break;
						case integer._sign.Ret.Positive:
							return new[] {
								new B(range.lower,  Border2.CreateOpenNil())
								,
								B.CreateZero()
								,
								new B(Border2.CreateOpenNil(), range.upper)
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
									B.CreateZero()
									,
									new B(Border2.CreateOpenNil(),range.upper)
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
		static public nilnul.obj.Trio<B> Triplet(Bound range)
		{
			switch (nilnul.num.quotient._SignX1.Sign(range.lower.mark))
			{
				case integer._sign.Ret.Negative:
					switch (nilnul.num.quotient._SignX1.Sign(range.upper.mark))
					{
						case integer._sign.Ret.Negative:
							return new obj.Trio<B>( range ,null,null);
							break;
						case integer._sign.Ret.Nil:
							if (range.upper.isClose)
							{
								return new obj.Trio<B>(
									new B(range.lower, Border2.CreateOpenNil())
									,B.CreateZero()
									,null
								);
							}
							else
							{
								return new obj.Trio<B>(range ,null,null);
							}
							break;
						case integer._sign.Ret.Positive:
							return new obj.Trio<B>(
								new B(range.lower,  Border2.CreateOpenNil())
								,
								B.CreateZero()
								,
								new B(Border2.CreateOpenNil(), range.upper)
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
							return new obj.Trio<B>(null,range ,null);
							break;
						case integer._sign.Ret.Positive:
							if (range.lower.isClose)
							{
								return new obj.Trio<B>(
									null,
									B.CreateZero()
									,
									new B(Border2.CreateOpenNil(),range.upper)
								);
							}
							else
							{
								return new obj.Trio<B>(
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
					return new obj.Trio<B>(null,null, range);
					break;
			}
		}

	}
}
