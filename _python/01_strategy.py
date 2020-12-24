from abc import ABC, abstractmethod

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

class FlyBehaviour(ABC):
    @abstractmethod
    def fly(self):
        pass

class FlyWithWings(FlyBehaviour):
    def fly(self):
        print("Flying with wings...")

class FlyNoWay(FlyBehaviour):
    def fly(self):
        print("Not flying...")

class QuackBehaviour(ABC):
    @abstractmethod
    def quack(self):
        pass

class Quack(QuackBehaviour):
    def quack(self):
        print("Quack Quack!")

class Squeak(QuackBehaviour):
    def quack(self):
        print("Squeak Squeak!")


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