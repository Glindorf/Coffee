namespace Coffee
{
    public class Latte : Coffee
    {
        public override string CoffeeName()
        {
            return "Latte";
        }
        public override int Price()
        {
            return 40;
        }
        public override string Strength()
        {
            return "weak";
        }
        public int mlMilk()
        {
            return 200;
        }
        public override string ToString()
        {
            return base.ToString() + $" Mængde mælk: {mlMilk()} ml.";
        }
    }
}