namespace nilnul.num.quotient.of_.binary_.fractile
{

	public class Converse:
		of_.binary.converse_.OpDefault<
			of_.binary_.Fractile
		>
	{

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// for 4,3,2,1:
		///		4 ~+ (3 ~+2 ) ~+ 1=
		///		4 ~+ (1/3 +2) ~+1
		///		=1/4 + (7/3) ~+1
		///		= 31/12 ~+1
		///		= 1/ (31/12) +1
		///		= 43/31
		///
		///		or:
		///		 = 1/ (1/4 + (1/3 +2) )+1
		///		= 1/ ( (3+28) /12 ) +1
		///		= 43/32
		///	but
		///		4 ~+ 3 ~+2  ~+ 1
		///		in fractile form:
		///		=1/ (2+1/(3+1/4))
		///		= 1/ (2+ 1/( 13/4)    )
		///		= 1/ ( 2+ 4/13     )
		///		= 1/ (30/13)
		///		= 13/30
		///	so we cannot put prenthesis around some terms in between.
		///	it's only left associable, not right associable; and cuz it's not right associable, it's not associalbe to the right even in the middle;
		///
		/// that means, in fractile form, only the tail (the leading of the unreversed str here) can be assoicated. <see cref="quotient.str_.started.scala_.Fractile"/>;
		/// for a stream, it's not possible to reverse. So we cannot reuse prviously computed result. we need to find a way to make the fractile terms left associable, <see cref="integer.str_.started_.nonhead8positive._IFractile"/>
		public override string ToString()
		{
			/// where ~ is the inverse operator:<see cref="of_.unary_.Inverse"/>
			return "~+";
		}

		static public Converse Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Converse>.Unison;
			}
		}


	}



}
