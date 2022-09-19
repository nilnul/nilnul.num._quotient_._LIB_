using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient._bound.lower_;
using nilnul.num.quotient._bound.upper_;
using nilnul.num.quotient.bound.be_.closed.vow;
using nilnul.num.quotient_;
using Q1 = nilnul.num.Quotient_NonnilDenom;


namespace nilnul.num.quotient_.denomNonnil.bound_
{
	public class Closed1 :
		nilnul.obj.Box_ofIn<denomNonnil.co.be_.le.vow.Ee>
		,
		denomNonnil.BoundI
		
	{
		public Closed1(in co.be_.le.vow.Ee val) : base(in val)
		{
		}
		public Closed1(co.be_.le.vow.Ee val) : base(val)
		{
		}


		public Closed1(Q1 border21, Q1 border22):this(
			new co.be_.le.vow.Ee(
				 (border21,border22)
			)
		)
		{
		}

		public Closed1(Q1 singleton):this(singleton,singleton)
		{

		}
		public Closed1(int v):this(new Q1(v))
		{
		}
		public Closed1():this(0)
		{

		}


		public num.Quotient_NonnilDenom mid {
			get {
				return (boxed.eeByRef.Item1+boxed.eeByRef.Item2)/ 2;
			}
		}

		


		public bool isSingleton =>boxed.eeByRef.Item1 == boxed.eeByRef.Item2;


		public Quotient_NonnilDenom diameter => boxed.eeByRef.Item2-boxed.eeByRef.Item1;

		//public Border2 upper => boxed.en.upper;
		//public Border2 lower => boxed.en.lower;

		public border_.Lower lower => new border_.Lower (true, boxed.eeByRef.Item1);

		public border_.Upper upper =>  new border_.Upper(true, boxed.eeByRef.Item2);

		public Q1 lowerMark => boxed.eeByRef.Item1;

		public Q1 upperMark =>   boxed.eeByRef.Item2;


		public bool has(Q1 ext)
		{
			return ext>=boxed.eeByRef.Item1 && ext<=boxed.eeByRef.Item2;
		}

		public bool hasNil()
		{
			return has(0);
		}

		public bool isClosed()
		{
			return true;
		}

		public bool diameterIsLe(denomNonnil_.Positive diameter)
		{
			return this.diameter<=diameter;
		}
		public bool diameterIsGe(denomNonnil_.Positive diameter)
		{
			return this.diameter>=diameter;
		}
		
		public bool diameterIsLt(denomNonnil_.Positive diameter)
		{

			return this.diameter < diameter;
		}

	

		public bool diameterIsGt(denomNonnil_.Positive diameter)
		{
			return this.diameter>diameter;
		}



		public bool isNil()
		{
			return isSingleton && boxed.eeByRef.Item1.beNil;
		}

	

		public bool notHasNil()
		{
			return !hasNil();
		}
		static public implicit operator denomNonnil.Bound( Closed1 range)
		{
			return new Bound(range.lower,range.upper);
		}
		static public Closed1 operator *(Q1 scale, Closed1 range)
		{
			return new Closed1(scale*range.boxed.eeByRef.Item1,scale*range.boxed.eeByRef.Item2);
		}

		static public Closed1 operator *(Closed1 x, Closed1 y) {

			var points = new[] {
				x.boxed.eeByRef.Item1*y.boxed.eeByRef.Item1
				,
				x.boxed.eeByRef.Item1*y.boxed.eeByRef.Item2
				,
				x.boxed.eeByRef.Item2*y.boxed.eeByRef.Item1
				,
				x.boxed.eeByRef.Item2*y.boxed.eeByRef.Item2

			};

			return new Closed1(
				nilnul.num.quotient_.denomNonnilEs_.headed.to_.scalar_.Min.Singleton.to(points)
				,
				nilnul.num.quotient_.denomNonnilEs_.headed.to_.scalar_.Max.Singleton.to(points)
			);

		}


		static public Closed1 operator +(Closed1 a, Closed1 b)
		{
			return new Closed1(a.lower.mark + b.lower.mark, a.upper.mark + b.upper.mark);
		}

		static public Closed1 operator -(Closed1 a)
		{
			return new Closed1(-a.boxed.eeByRef.Item2,a.boxed.eeByRef.Item1);
		}

		static public Closed1 Create_orderIfNecessary(Q1 a, Q1 b)
		{
			if (a <= b)
			{
				return new Closed1(a, b);

			}
			return new Closed1(b, a);
		}

		//static public Closed1 Create_byMergeBorder(quotient.Bound bound)
		//{
		//	return new Closed1(bound.lower.mark, bound.upper.mark);
		//}


	}


}
