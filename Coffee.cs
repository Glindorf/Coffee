using System;

namespace Coffee
{
    public abstract class Coffee

    {
        public abstract string CoffeeName();

        public virtual int Price()
        {
            return 20;
        }

        public abstract string Strength();
        public override string ToString()
        {
            return $"{CoffeeName()} koster {Price()}, kaffestyrke: {Strength()}.";
        }



    } 
}