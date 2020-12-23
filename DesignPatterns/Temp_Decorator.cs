using System;
					
public class Program
{
	public static void Main()
	{
		Ingredient pizza = new PizzaBase();
		pizza = new Tomato(pizza);
		pizza = new Mozzarella(pizza);
		Console.WriteLine(pizza.GetDescription());
		Console.WriteLine(pizza.GetCost());
	}
	
	public interface Ingredient
	{
		decimal GetCost();
		string GetDescription();
	}
	
	public abstract class BaseDecorator : Ingredient
	{
		Ingredient _ingredient;
		
		public BaseDecorator(Ingredient ingredient)
		{
			_ingredient = ingredient;
		}
		
		public virtual decimal GetCost()
		{
			if(_ingredient != null)
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
			if(_ingredient != null)
			{
				return _ingredient.GetDescription();
			}
			else
			{
				return string.Empty;
			}
		}
	}
	
	public class PizzaBase : Ingredient
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
		Ingredient _ingredient;
		
		public Tomato(Ingredient ingredient) : base(ingredient) {}
		
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
		Ingredient _ingredient;
		
		public Mozzarella(Ingredient ingredient) : base(ingredient) {}
		
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
