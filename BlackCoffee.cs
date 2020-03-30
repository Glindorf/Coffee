using System;

namespace Coffee
{
    public class BlackCoffee : Coffee
    {
        public override string CoffeeName()
        {
            return "Black Coffee";
        }
        public override int Price()
        {
            return 20;
        }
        public override string Strength()
        {
            return "Strong";
        }
    }
}