﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzDecorator
{
    class DarkRoast : Beverage
    {
		public DarkRoast()
		{
			description = "Dark Roast Coffee";
		}

		public override double cost()
		{
			return .99;
		}
	}
}
