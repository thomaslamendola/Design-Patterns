using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
			IIngredient pizza;

			//pizza = new PizzaBase();
			//pizza = new Tomato(pizza);
			//pizza = new Mozzarella(pizza);

			pizza = new Tomato(new Mozzarella(new PizzaBase()));

            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.GetCost());
        }

		public interface IIngredient
		{
			decimal GetCost();
			string GetDescription();
		}

		public abstract class BaseDecorator : IIngredient
		{
            readonly IIngredient _ingredient;

			public BaseDecorator(IIngredient ingredient)
			{
				_ingredient = ingredient;
			}

			public virtual decimal GetCost()
			{
				if (_ingredient != null)
				{
					return _ingredient.GetCost();
				}
				else
				{
					return 0M;
				}
			}

			public virtual string GetDescription()
			{
				if (_ingredient != null)
				{
					return _ingredient.GetDescription();
				}
				else
				{
					return string.Empty;
				}
			}
		}

		public class PizzaBase : IIngredient
		{
			public decimal GetCost()
			{
				return 40M;
			}

			public string GetDescription()
			{
				return "Pizza Base";
			}
		}

		public class Tomato : BaseDecorator
		{
			public Tomato(IIngredient ingredient) : base(ingredient) { }

			public override decimal GetCost()
			{
				return 10M + base.GetCost();
			}

			public override string GetDescription()
			{
				return base.GetDescription() + ", Tomato";
			}
		}

		public class Mozzarella : BaseDecorator
		{
			public Mozzarella(IIngredient ingredient) : base(ingredient) { }

			public override decimal GetCost()
			{
				return 15M + base.GetCost();
			}

			public override string GetDescription()
			{
				return base.GetDescription() + ", Mozzarella";
			}
		}
	}
}
