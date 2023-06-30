using nilnul.num.natural;
using nilnul.num.rational.cf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile.of_.dbl_.approx_
{
	static public class _ByIndexX
	{
		static public Fractile _ToFractile_0finite(double x, num.natural.Natural2 tailLength)
		{


			var floorTail =
				nilnul_obj.num.NumX.FloorAndTail(x);

			var tail = floorTail.Item2;




			var tailCf = num.integer.str_.started_.nonhead8positive._fractile.denoms.of_.dbl_.probal_.approx_._ByIndexX._ToDenoms_0prob(tail, tailLength).Select(
				x => new PositiveNatural_inheritNatural(x)
			).ToList();

			return new integer.str_.started_.nonhead8positive.Fractile(
				floorTail.Item1, tailCf.Select(x=>x.val)
			);


		}

		public static Fractile _ToFractile_0finite(double x, int tailLength)
		{
			return _ToFractile_0finite(x, new num.natural.Natural2(tailLength));
		}
	}
}
