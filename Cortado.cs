namespace Coffee
{
    public class Cortado : Coffee
    {

        public override string CoffeeName()
        {
            return "Cortado";
        }
        public override int Price()
        {
            return 25;
        }
        public override string Strength()
        {
            return "Medium";
        }
        public int mlMilk()
        {
            return 40;
        }
        public override string ToString()
        {
            return base.ToString() + $" Mængde mælk: {mlMilk()} ml.";
        }

    }
}