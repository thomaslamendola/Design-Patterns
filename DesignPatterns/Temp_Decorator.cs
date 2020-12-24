using System;
					
public class Program
{
	public static void Main()
	{
		IIngredient pizza = new PizzaBase();
		pizza = new Tomato(pizza);
		pizza = new Mozzarella(pizza);
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
		IIngredient _ingredient;
		
		public BaseDecorator(IIngredient ingredient)
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
		IIngredient _ingredient;
		
		public Tomato(IIngredient ingredient) : base(ingredient) {}
		
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
		IIngredient _ingredient;
		
		public Mozzarella(IIngredient ingredient) : base(ingredient) {}
		
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
