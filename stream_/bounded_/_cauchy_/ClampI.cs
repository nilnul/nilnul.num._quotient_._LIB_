using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.bounded_._cauchy_
{
	/*	bound merge border will not need to squeeze again*/

	/// <summary>
	/// this class is not needed if we use the general default squeezer: repeating the next() till we get the range we wwwant.
	/// But we can better this process by providing a custom "squeezer"
	/// </summary>
	public interface MakeBoundDiameterLtI
	{
		/// <summary>
		///	dependent on the following interpretations
		/// </summary>
		/// <param name="diameter"></param>
		void makeBoundDiameterLt(nilnul.num.quotient_.Positive1 diameter);
	}

	public interface MakeBoundDiameterLeI
	{
		/// <summary>
		///	dependent on the following interpretations
		/// </summary>
		/// <param name="diameter"></param>
		void makeBoundDiameterLe(nilnul.num.quotient_.Positive1 diameter);
	}

	/// <summary>
	/// interpret squeeze as:
	///		the distance of any two lements in the bound, shall be le given para.
	///			if the para is b-a, then the bound can be (a,b), [a,b), (a,b], [a,b]
	///	this implies:
	///		boundDiameterLe
	///	for elsLt (P),
	///		we have to choose a smaller given para (P1), which is lt (P).
	///	for
	///		Squeeze_boundDiameterLt b-a  doesnot hold
	///			we have to choose b1-a1, which is smaller than b-a, to make the above hold
	///		
	/// </summary>
	public interface SqueezeI_elsLe : MakeBoundDiameterLtI { }
	/// <summary>
	/// implement squeeze as:
	///		the diameter of bound shall be le given para
	///		make the bound.diamter strictly lessThan, not less than or equal to, given diameter.
	///		if the para is b-a, then the bound can be (a,b), [a,b), (a,b], [a,b]
	///	this implies:
	///		squeeze_eleLe b-a
	///	for
	///		Squeeze_boundDiameterLt b-a  IS FALSE
	///			we have to choose b1-a1, which is smaller than b-a, to make the above hold
	///		squeeze_elesLt b-a,  DOES NOT HOLD
	///			we have to choose b1-a1, which is smaller than b-a, to make the above hold
	/// </summary>
	public interface SqueezeI_boundDiameterLe : MakeBoundDiameterLtI { }

	/// <summary>
	/// interpret squeeze as:
	///		the distance of any two lements in the bound, shall be lt given para.
	///			if the para is b-a, then the bound can be (a,b) [a,b), (a,b], but not [a,b]
	///	this implies:
	///		squeeze_eleLe b-a
	///		diameterLe  b-a
	///		
	///	for
	///		Squeeze_boundDiameterLt b-a  doesnot hold
	///			we have to choose b1-a1, which is smaller than b-a, to make the above hold
	///		
	/// </summary>
	public interface SqueezeI_elsLt : MakeBoundDiameterLtI { }


	/// <summary>
	/// implement squeeze as:
	///		the diameter of bound shall be lt given para
	///	if the para is b-a, then the bound can not be (a,b), [a,b), (a,b], [a,b]
	///		but (a1,b1),(a1,b1], [a1,b1),[a1,b1]
	///	this implies
	///		Squeeze_boundDiameterLe b-a
	///		squeeze_elesLt b-a
	///		squeeze_eleLe b-a
	/// </summary>
	public interface SqueezeI_boundDiameterLt : MakeBoundDiameterLtI { }

	///becuase the first two are equivalent, so we have three tiers to squeeze
	///  all
	///  excluding [a,b]
	///  none
	///
	/// for real numbers, the bound is always expanded to close. so we will not choose the middle gear.
	/// and the given parameter is positive, and the closed bound might be of diameter 0, which is always lt given para
	/// and lt can always be achieved, but eq is impossible sometimes. so to fully, consistently meaning the relation, we use lt, rather than le.
	/// so we''l choose the last gear.
	/// we will not need to squeeze more if we convert quotient.stream_.bounded_.Cauchy to Real by letting bound mergingBorders.
	///
	/// we want to keep the semantics over to real number, where the bound is always closed,
	///
	//

}
