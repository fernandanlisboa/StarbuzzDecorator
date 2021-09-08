using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzDecorator
{
    public class Soy : CondimentDecorator
    {
		public Soy(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override string getDescription()
		{
			return beverage.getDescription() + ", Soy";
		}

		public override double cost()
		{
            if (beverage.getSize() == Size.TALL)
            {
				return .10 + beverage.cost();
			}

			else if (beverage.getSize() == Size.GRANDE)
			{
				return .15 + beverage.cost();
			}

			return .20 + beverage.cost();
		}
	}
}
