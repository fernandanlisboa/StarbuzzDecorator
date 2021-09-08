using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzDecorator
{
    public class Milk : CondimentDecorator
    {
		public Milk(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override string getDescription()
		{
			return beverage.getDescription() + ", Milk";
		}

		public override double cost()
		{
			if (beverage.getSize() == Size.TALL)
			{
				return .15 + beverage.cost();
			}

			else if (beverage.getSize() == Size.GRANDE)
			{
				return .20 + beverage.cost();
			}

			return .30 + beverage.cost();
		}
	}
}
