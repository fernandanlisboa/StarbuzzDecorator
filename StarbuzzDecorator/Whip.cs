using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzDecorator
{
    public class Whip : CondimentDecorator
    {
		public Whip(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override string getDescription()
		{
			return beverage.getDescription() + ", Whip";
		}

		public override double cost()
		{
			return .10 + beverage.cost();
		}
	}
}
