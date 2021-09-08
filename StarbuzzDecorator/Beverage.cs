using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzDecorator
{
    public abstract class Beverage
    {
        public enum Size { TALL, GRANDE, VENTI };
        Size size = Size.TALL;
        public string description = "Unknown Beverage";

        public virtual string getDescription()
        {
            return description;
        }

        public void setSize(Size size)
        {
            this.size = size;
        }
        public Size getSize()
        {
            return this.size;
        }

        public abstract double cost();
    }
}
