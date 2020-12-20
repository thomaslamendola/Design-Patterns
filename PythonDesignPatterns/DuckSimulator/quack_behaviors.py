from abc import ABC, abstractmethod

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
