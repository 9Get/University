from abc import ABC, abstractmethod


class Transport(ABC):
    def __init__(self, max_speed=0, weight=0):
        self.__max_speed = max_speed
        self.__weight = weight

    def __str__(self):
        return f"Max speed: {self.__max_speed}  Weight: {self.__weight} kg"

    @abstractmethod
    def get_brand(self):
        pass


class Car(Transport):
    def __init__(self, max_speed=0, weight=0, brand=""):
        Transport.__init__(self, max_speed, weight)
        self.__brand = brand

    def get_brand(self):
        return self.__brand

    def __str__(self):
        return super().__str__() + f"  Brand: {self.__brand}"


car1 = Car(240, 600, "Toyota")
print(car1)
# transport1 = Transport()