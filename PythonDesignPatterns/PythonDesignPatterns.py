from abc import ABC, abstractmethod
from DuckSimulator.ducks import MallardDuck, RubberDuck

print("Mallard Duck:")
duck = MallardDuck()
duck.swim()
duck.perform_fly()
duck.perform_quack()

print("Rubber Duck:")
duck = RubberDuck()
duck.swim()
duck.perform_fly()
duck.perform_quack()