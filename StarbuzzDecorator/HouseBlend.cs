using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzDecorator
{
    class HouseBlend : Beverage
    {
		public HouseBlend()
		{
			description = "House Blend Coffee";
		}

		public override double cost()
		{
			return .89;
		}
	}
}
