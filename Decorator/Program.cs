using System;
using System.Threading;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pizza preparation started");
            new PizzaBase(new Cheese(new Chicken(null))).Show();
            Console.WriteLine("Pizza ready !!!!!");
        }

        class BasePizza: IPizza
        {
            IPizza _pizza;
            public BasePizza(IPizza pizza)
            {
                _pizza = pizza;
            }

            public virtual void Show()
            {
                _pizza?.Show();
            }
        }

        class PizzaBase: BasePizza
        {
            public PizzaBase(IPizza pizza):base(pizza)
            {             
            }
            public override void Show()
            {
                Console.WriteLine("Added base");
                base.Show();
            }
        }
        class Cheese : BasePizza
        {
            public Cheese(IPizza pizza) : base(pizza)
            {
            }
            public override void Show()
            {
                Console.WriteLine("Added Cheese");
                base.Show();
            }
        }
        class Chicken : BasePizza
        {
            public Chicken(IPizza pizza) : base(pizza)
            {
            }
            public override void Show()
            {
                Console.WriteLine("Added Chicken");
                base.Show();
            }
        }

    }

    interface IPizza
    {
        void Show();
    }
}
