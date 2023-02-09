using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient._bound.lower_;
using nilnul.num.quotient._bound.upper_;
using nilnul.num.quotient.bound.be_.closed.vow;
using nilnul.num.quotient_;
using Q1 = nilnul.num.quotient_.DenomNonnil;


namespace nilnul.num.quotient_.denomNonnil
{

	public class Clasp :
		nilnul.obj.Box_ofIn<denomNonnil.co.be_.le.vow.Ee>
		,
		denomNonnil.BoundI
		,
		denomNonnil._collection_.HasI
		,
		IClasp
		
	{
		public Clasp(in co.be_.le.vow.Ee val) : base(in val)
		{
		}
		public Clasp(co.be_.le.vow.Ee val) : base(val)
		{
		}


		public Clasp(Q1 border21, Q1 border22):this(
			new co.be_.le.vow.Ee(
				 (border21,border22)
			)
		)
		{
		}

		public Clasp(Q1 singleton):this(singleton,singleton)
		{

		}
		public Clasp(int v):this(new Q1(v))
		{
		}
		public Clasp():this(0)
		{

		}


		public num.quotient_.DenomNonnil mid {
			get {
				return (boxed.eeByRef.Item1+boxed.eeByRef.Item2)/ 2;
			}
		}

		


		public bool isSingleton =>boxed.eeByRef.Item1 == boxed.eeByRef.Item2;


		public DenomNonnil diameter => boxed.eeByRef.Item2-boxed.eeByRef.Item1;

		//public Border2 upper => boxed.en.upper;
		//public Border2 lower => boxed.en.lower;

		public border_.LowerI lower => new border_.Lower (true, boxed.eeByRef.Item1);

		public border_.UpperI upper =>  new border_.Upper(true, boxed.eeByRef.Item2);

		public Q1 lowerMark => boxed.eeByRef.Item1;

		public Q1 upperMark =>   boxed.eeByRef.Item2;


		public bool has(Q1 ext)
		{
			return ext>=boxed.eeByRef.Item1 && ext<=boxed.eeByRef.Item2;
		}

	
		public bool has(DenomNonnilI ext)
		{

			return has(ext.ToImpl());
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
			return this.diameter<=diameter.eeByRef;
		}
		public bool diameterIsGe(denomNonnil_.Positive diameter)
		{
			return this.diameter>=diameter.eeByRef;
		}
		
		public bool diameterIsLt(denomNonnil_.Positive diameter)
		{

			return this.diameter < diameter.eeByRef;
		}

	

		public bool diameterIsGt(denomNonnil_.Positive diameter)
		{
			return this.diameter>diameter.eeByRef;
		}



		public bool isNil()
		{
			return isSingleton && boxed.eeByRef.Item1.beNil;
		}

	

		public bool notHasNil()
		{
			return !hasNil();
		}
		static public implicit operator denomNonnil.Bound( Clasp range)
		{
			return new Bound(range.lower,range.upper);
		}
		static public Clasp operator *(Q1 scale, Clasp range)
		{
			return new Clasp(scale*range.boxed.eeByRef.Item1,scale*range.boxed.eeByRef.Item2);
		}

		static public Clasp operator *(Clasp x, Clasp y) {

			var points = new[] {
				x.boxed.eeByRef.Item1*y.boxed.eeByRef.Item1
				,
				x.boxed.eeByRef.Item1*y.boxed.eeByRef.Item2
				,
				x.boxed.eeByRef.Item2*y.boxed.eeByRef.Item1
				,
				x.boxed.eeByRef.Item2*y.boxed.eeByRef.Item2

			};

			return new Clasp(
				nilnul.num.quotient_.denomNonnilEs_.headed.to_.scalar_.Min.Singleton.to(points)
				,
				nilnul.num.quotient_.denomNonnilEs_.headed.to_.scalar_.Max.Singleton.to(points)
			);

		}


		static public Clasp operator +(Clasp a, Clasp b)
		{
			return new Clasp(a.lower.mark.ToImpl() + b.lower.mark, a.upper.mark.ToImpl() + b.upper.mark);
		}

		static public Clasp operator -(Clasp a)
		{
			return new Clasp(-a.boxed.eeByRef.Item2,a.boxed.eeByRef.Item1);
		}

		static public Clasp Create_orderIfNecessary(Q1 a, Q1 b)
		{
			if (a <= b)
			{
				return new Clasp(a, b);

			}
			return new Clasp(b, a);
		}

		//static public Closed1 Create_byMergeBorder(quotient.Bound bound)
		//{
		//	return new Closed1(bound.lower.mark, bound.upper.mark);
		//}


	}


}
