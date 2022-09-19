﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.rational.float_.order
{
	public partial class ExtendedOrder
		
		:nilnul.order.extended.Order<Float3>
	{

		static private readonly ExtendedOrder _Instance = new ExtendedOrder();
		static public ExtendedOrder Instance
		{
			get
			{
				return _Instance;
			}
		}
		private ExtendedOrder()
			:base(Order.Instance)
		{
		}

				


	}
}
