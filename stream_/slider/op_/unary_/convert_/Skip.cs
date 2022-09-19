using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.slider.convert_
{
	public class Skip : ConvertI
	{
		private int _skipped;

		public int skipped
		{
			get { return _skipped; }
			set { _skipped = value; }
		}

		public Skip(int skipped)
		{
			_skipped = skipped;
		}

		public SliderI eval(SliderI arg)
		{
			return new _skip.Ret(_skipped, arg);
		}

		static public Skip SkipOne = new Skip(1);
	}
}
