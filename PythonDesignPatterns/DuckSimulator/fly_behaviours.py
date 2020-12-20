from abc import ABC, abstractmethod

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
