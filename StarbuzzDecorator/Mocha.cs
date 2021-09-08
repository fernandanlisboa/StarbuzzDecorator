using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzDecorator
{
    public class Mocha : CondimentDecorator
    {
		public Mocha(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override string getDescription()
		{
			return beverage.getDescription() + ", Mocha";
		}

		public override double cost()
		{
			if (beverage.getSize() == Size.TALL)
			{
				return .15 + beverage.cost();
			}

			else if (beverage.getSize() == Size.GRANDE)
			{
				return .25 + beverage.cost();
			}

			return .30 + beverage.cost();
		}
	}
}
