from abc import ABC, abstractmethod
from DuckSimulator.fly_behaviours import FlyNoWay, FlyWithWings
from DuckSimulator.quack_behaviors import Quack, Squeak

class Duck(ABC):
    def __init__(self):
        self.fly_behaviour = None
        self.quack_behaviour = None

    @abstractmethod
    def display(self):
        pass

    def swim(self):
        print("Swim, swim...")

    def perform_quack(self):
        self.quack_behaviour.quack()

    def perform_fly(self):
        self.fly_behaviour.fly()

    def set_quack_behaviour(self, qb):
        self.quack_behaviour = qb

    def set_fly_behaviour(self, fb):
        self.fly_behaviour = fb

class MallardDuck(Duck):
    def __init__(self):
        self.quack_behaviour = Quack()
        self.fly_behaviour = FlyWithWings()

    def display(self):
        print("I am a Mallard Duck!")

class RubberDuck(Duck):
    def __init__(self):
        self.quack_behaviour = Squeak()
        self.fly_behaviour = FlyNoWay()

    def display(self):
        print("I am a Rubber Duck!")