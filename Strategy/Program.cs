using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[A Mallard Duck is born...]");
            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();

            Console.WriteLine("[A Rubber Duck is made...]");
            Duck rubber = new RubberDuck();
            rubber.PerformFly();
            rubber.PerformQuack();

            Console.WriteLine("[Attaching a JetPack to the Rubber Duck...]");
            rubber.SetFlyBehaviour(new FlyWithJetPack());
            rubber.PerformFly();

            Console.ReadLine();
        }

        #region Ducks

        public abstract class Duck
        {
            public IQuackBehaviour QuackBehaviour { get; set; }
            public IFlyBehaviour FlyBehaviour { get; set; }

            public void Swim()
            {
                Console.WriteLine("Floating...");
            }

            public abstract void Display();

            public void PerformQuack()
            {
                QuackBehaviour.Quack();
            }

            public void PerformFly()
            {
                FlyBehaviour.Fly();
            }

            public void SetQuackBehaviour(IQuackBehaviour qb)
            {
                QuackBehaviour = qb;
            }

            public void SetFlyBehaviour(IFlyBehaviour fb)
            {
                FlyBehaviour = fb;
            }
        }

        public class MallardDuck : Duck
        {
            public MallardDuck()
            {
                QuackBehaviour = new Quack();
                FlyBehaviour = new FlyWithWings();
            }

            public override void Display()
            {
                Console.WriteLine("I'm a Mallard Duck");
            }
        }

        public class RubberDuck : Duck
        {
            public RubberDuck()
            {
                FlyBehaviour = new FlyNoWay();
                QuackBehaviour = new Squeak();
            }
            public override void Display()
            {
                Console.WriteLine("I'm a Rubber Duck!");
            }
        }

        #endregion

        #region Fly Behaviour

        public interface IFlyBehaviour
        {
            void Fly();
        }

        public class FlyWithWings : IFlyBehaviour
        {
            public void Fly()
            {
                Console.WriteLine("Flying with wings");
            }
        }

        public class FlyNoWay : IFlyBehaviour
        {
            public void Fly()
            {
                Console.WriteLine("Cannot fly");
            }
        }

        public class FlyWithJetPack : IFlyBehaviour
        {
            public void Fly()
            {
                Console.WriteLine("Flying with a JetPack! Swoosh!");
            }
        }

        #endregion

        #region Quack Behaviour

        public interface IQuackBehaviour
        {
            void Quack();
        }

        public class Quack : IQuackBehaviour
        {
            void IQuackBehaviour.Quack()
            {
                Console.WriteLine("Quack!");
            }
        }

        public class Squeak : IQuackBehaviour
        {
            public void Quack()
            {
                Console.WriteLine("Squeak!");
            }
        }

        public class MuteQuack : IQuackBehaviour
        {
            public void Quack()
            {
                Console.WriteLine("...");
            }
        }

        #endregion
    }
}
